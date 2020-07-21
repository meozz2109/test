/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package vnua.k62cnpm.xdptpm.libmanage.jdbc.controller;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import java.util.List;
import java.util.logging.Level;
import java.util.logging.Logger;
import vnua.k62cnpm.xdptpm.libmanage.AllLibmanager.Reader;
import vnua.k62cnpm.xdptpm.libmanage.AllLibmanager.Subject;
import vnua.k62cnpm.xdptpm.libmanage.AllLibmanager.Supplier;

/**
 *
 * @author Admin
 */
public class SubjectDao {

	public List<Subject> getAllSubject() {
		List<Subject> subjects = new ArrayList<Subject>();

		Connection con = JDBCConnection.getJDBCConnection();

		String sql = "SELECT * FROM TheLoai";

		PreparedStatement preparedStatement;
		try {
			preparedStatement = con.prepareStatement(sql);
			ResultSet rs = preparedStatement.executeQuery();

			while (rs.next()) {
				Subject subject = new Subject();
				subject.setMatheloai(rs.getString("MaTheLoai"));
				subject.setTentheloai(rs.getString("TenTheLoai"));
				subject.setGhichu(rs.getString("GhiChu"));

				subjects.add(subject);
			}
		} catch (SQLException ex) {
			Logger.getLogger(ReaderDao.class.getName()).log(Level.SEVERE, null, ex);
		}
		return subjects;
	}

	public void addSubject(Subject subject) {

		Connection con = JDBCConnection.getJDBCConnection();

		String sql = "INSERT INTO TheLoai(MaTheLoai, TenTheLoai, GhiChu) VALUES(?,?,?)";

		try {
			PreparedStatement preparedStatement = con.prepareStatement(sql);

			preparedStatement.setString(1, subject.getMatheloai());
			preparedStatement.setString(2, subject.getTentheloai());
			preparedStatement.setString(3, subject.getGhichu());

			int rs = preparedStatement.executeUpdate();
			System.out.println(rs);

		} catch (Exception ex) {
			Logger.getLogger(ReaderDao.class.getName()).log(Level.SEVERE, null, ex);
			System.out.println("Lỗi");
		}

	}

	public void updateReader(Reader readers) {

		Connection con = JDBCConnection.getJDBCConnection();

		String sql = "UPDATE DocGia SET HoTen = ?, Email = ?, SoDienThoai = ?,CMT = ?,"
				+ "NgayCapTK = ?,NgayHetHanTK = ?,MaNguoiDungCapNhap = ? WHERE MaDocGia = ? ";
		try {
			PreparedStatement preparedStatement = con.prepareStatement(sql);
			preparedStatement.setString(1, readers.getName());
			preparedStatement.setString(2, readers.getEmail());
			preparedStatement.setString(3, readers.getSdt());
			preparedStatement.setString(4, readers.getEmail());
//            preparedStatement.setDate(5, readers.getNgaycap());
//            preparedStatement.setDate(6, readers.getNgayhethan());
//            preparedStatement.setString(7, readers.getNgdungcapnhap());
//            preparedStatement.setString(7, readers.getID());

			int rs = preparedStatement.executeUpdate();
			System.out.println(rs);

		} catch (SQLException ex) {
			Logger.getLogger(ReaderDao.class.getName()).log(Level.SEVERE, null, ex);
		}

	}

	public void deleteSubject(String ID) {

		Connection con = JDBCConnection.getJDBCConnection();

		String sql = "delete from TheLoai where MaTheLoai = ?";

		try {
			PreparedStatement preparedStatement = con.prepareStatement(sql);
			preparedStatement.setString(1, ID);
			int rs = preparedStatement.executeUpdate();
			System.out.println(rs);
		} catch (SQLException ex) {
			Logger.getLogger(ReaderDao.class.getName()).log(Level.SEVERE, null, ex);
		}

	}

}

﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace RestaurantManagement0.Models.AMDs
{
    /// <summary>
    /// Interaction logic for EmployeeAMD.xaml
    /// </summary>
    public partial class EmployeeAMD : Window
    {
        public EmployeeAMD()
        {
            InitializeComponent();
        }

        private void SearchIBox_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void SearchIBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void SearchIBox_GotFocus(object sender, RoutedEventArgs e)
        {

        }

        private void cboTypeI_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            var window = new EmployeeA();
            window.Show();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            var window = new EmployeeM();
            window.Show();
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            var window = new EmployeeD();
            window.Show();
        }

        private void btnSkip_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // connect to database
            Class.Functions.Connect();

            string sql = "select MaNV, TenNV, GioiTinh, NgaySinh, SoDT, SoCMT, DiaChi, MaTKNH, ChucVu, LuongTheoGio from tblNhanVien";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand();
            adapter.SelectCommand.Connection = Class.Functions.Con;
            adapter.SelectCommand.CommandText = sql;
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            lvEmployee.DataContext = ds.Tables[0].DefaultView;

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // connect to database
            Class.Functions.Connect();

            string sql = "select MaNV, TenNV, GioiTinh, NgaySinh, SoDT, SoCMT, DiaChi, MaTKNH, ChucVu, LuongTheoGio from tblNhanVien";
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = new SqlCommand();
            adapter.SelectCommand.Connection = Class.Functions.Con;
            adapter.SelectCommand.CommandText = sql;
            DataSet ds = new DataSet();
            adapter.Fill(ds);

            // Another way
            SqlCommand cmd = new SqlCommand(sql, Class.Functions.Con);
            SqlDataReader reader = cmd.ExecuteReader();

            // Clear the ListView control
            lvEmployee.Items.Clear();

            // create new list
            List<String> ls = new List<string>();

            // Display items in the ListView control
            /*
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];

                // Only row that have not been deleted
                if( dr.RowState != DataRowState.Deleted)
                {

                    // Define the string list
                    ls.Add(dr["Username"].ToString());
                    ls.Add(dr["Password"].ToString());
                    ls.Add(dr["Chức vụ"].ToString());
                    
                }
            }
            */

            // Change the background color of list view

            BrushConverter bc = new BrushConverter();
            Brush br = (Brush)bc.ConvertFrom("#437577");
            br.Freeze();
            /*
            lvLogInAccount.Background = br;
            */
            foreach (ListViewItem item in lvEmployee.Items)
            {
                item.Background = br;
            }

            // add items
            lvEmployee.DataContext = ds.Tables[0].DefaultView;

            // disconnect to database
            Class.Functions.Disconnect();
        }
    }
}
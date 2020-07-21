package vnua.k62cnpm.xdptpm.libmanage.frame;

import java.awt.CardLayout;
import java.awt.Graphics;
import java.awt.Image;
import java.awt.event.WindowAdapter;
import java.awt.event.WindowEvent;

import javax.imageio.ImageIO;
import javax.swing.JFrame;
import javax.swing.JOptionPane;

import vnua.k62cnpm.xdptpm.libmanage.ui.panel.MainFrame;
import vnua.k62cnpm.xdptpm.libmanage.ui.panel.MainLibrarianPanel;
import vnua.k62cnpm.xdptpm.libmanage.ui.panel.MainPanel;

public class LibrarianMainFrame extends JFrame{
	
	private MainLibrarianPanel mlp;

    /**
     * Creates new form MainFrame
     */
    public LibrarianMainFrame() {
    	setLayout(new CardLayout());
    	setLocation(200, 20);
    	setSize(1200, 795);
        setResizable(false);
        setTitle("Luong Dinh Cua Library Management System - Vietnam National University of Agriculture");
        setDefaultCloseOperation(DO_NOTHING_ON_CLOSE);
        try {
            Image imgIcon = ImageIO.read(getClass().getResource("/resources/images/icon.png"));
            setIconImage(imgIcon);
        } catch(Exception e){
            e.printStackTrace();
        }
        
        addComp();
        addEvent();
        
    }


	private void addComp() {
		mlp = new MainLibrarianPanel();
		add(mlp);
	}


	private void addEvent() {
        addWindowListener(new WindowAdapter() {
                        @Override
			public void windowClosing(WindowEvent e) {
				int rs = JOptionPane.showConfirmDialog(LibrarianMainFrame.this, "Do you want to exit?", "Alert", JOptionPane.YES_NO_OPTION);
				if (rs == JOptionPane.YES_OPTION) {
					dispose();
				}
			}
		});
    }
    
    @Override
    public void paint(Graphics g) {
        super.paint(g); //To change body of generated methods, choose Tools | Templates.

    }
    
    
    
//    /**
//     * This method is called from within the constructor to initialize the form.
//     * WARNING: Do NOT modify this code. The content of this method is always
//     * regenerated by the Form Editor.
//     */

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(MainFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(MainFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(MainFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(MainFrame.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new MainFrame().setVisible(true);
            }
        });
    }

}

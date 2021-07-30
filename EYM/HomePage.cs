using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraLayout;

namespace EYM
{
    public partial class HomePage : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public string Username;
        public string Password;

        EYMEntities1 db = new EYMEntities1();
        Forms.EmployeePage newWindow = new Forms.EmployeePage();
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Forms.LoginPage login = new Forms.LoginPage();
            XtraDialog.Show(login,"Giriş Yap",MessageBoxButtons.OKCancel);
            Password = login.getPassword();
            Username = login.getUserName();

            if (Password == "123")
            {
                MessageBox.Show("hello");

            }
            else
            {
                HomePage.ActiveForm.Close();
            }
            
        }

            private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.students window = new Forms.students();
            window.MdiParent = this;
            window.Show();
   
        }


        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {




            newWindow.MdiParent = this;
            newWindow.Show();
        
              
                
                
         
            
    
        }
    }
}

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
        public string LoginName;
        public string Password;

        EYMEntities1 db = new EYMEntities1();
        Forms.EmployeePage newWindow = new Forms.EmployeePage();
        public HomePage()
        {
            InitializeComponent();
        }
        public class LoginUserControl : XtraUserControl
        {

            public LoginUserControl()
            {
                LayoutControl lc = new LayoutControl();
                lc.Dock = DockStyle.Fill;
               
                LabelControl label1 = new LabelControl() { Text = "Kullanıcı Adı" };
                LabelControl label2 = new LabelControl() { Text = "Şifre" };
                TextEdit teLogin = new TextEdit();
               
                
             
                TextEdit tePassword = new TextEdit();
                
                SeparatorControl separatorControl = new SeparatorControl();
                lc.AddItem(String.Empty, label1).TextVisible = false;
                

                lc.AddItem(String.Empty, teLogin).TextVisible = false;
                lc.AddItem(String.Empty, label2).TextVisible = false;
                lc.AddItem(String.Empty, tePassword).TextVisible = false;
                
                
                this.Controls.Add(lc);
                this.Height = 150;
                this.Dock = DockStyle.Top;
               
              


            }


        }
        private void Form1_Load(object sender, EventArgs e)
        {

            LoginUserControl login = new LoginUserControl();
            
            if (XtraDialog.Show(login, "Giriş Yap", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                
                
               
            

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

        private void reportBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem7_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {




            newWindow.MdiParent = this;
            newWindow.Show();
        
              
                
                
         
            
    
        }
    }
}

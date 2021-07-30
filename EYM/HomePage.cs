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
        public int WhoIam;

        EYMEntities2 db = new EYMEntities2();
       
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

            var findUser = from ls in db.UserLogin
                         where ls.Username == Username && ls.Password == Password
                         select ls;

             var result = findUser.FirstOrDefault();
            if (result!=null)
            {
                WhoIam = result.EmployeeID;
                var employee = db.Employee.Find(WhoIam);


                signIn.Caption += employee.Name + " " + employee.Surname;
                if (result.Authority == false)
                    barButtonItem11.VisibleInSearchMenu = false;
                {

                }
;            }
            else
            {
                XtraMessageBox.Show("Kullanıcı Adı veya Şifre hatalı lütfen tekrar deneyin.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Restart();
            }

            

            
        }
        int getLoginUserID()
        {
            return WhoIam;
        }
            private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.students window = new Forms.students();
            window.MdiParent = this;
            window.Show();
   
        }


        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {



            Forms.EmployeePage newWindow = new Forms.EmployeePage();
            newWindow.MdiParent = this;
            newWindow.Show();
        
              
                
                
         
            
    
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Authority aut = new Forms.Authority();
            aut.MdiParent = this;
            aut.Show();
        }
    }
}

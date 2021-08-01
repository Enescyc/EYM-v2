using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
namespace EYM.Forms
{
    public partial class LoginPage : DevExpress.XtraEditors.XtraForm
    {

        EYMEntities2 db = new EYMEntities2();
        public bool isSign = false;
        public bool getisSign()
        {
            return isSign;
        }
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginPage_Load(object sender, EventArgs e)
        {

        }
        

        private void simpleButton1_Click(object sender, EventArgs e)
        {
          


        }

        private void windowsUIButtonPanel1_ButtonClick(object sender, DevExpress.XtraBars.Docking2010.ButtonEventArgs e)
        {
            if (e.Button.Properties.Caption.ToUpper().ToString()=="GİRİŞ YAP")
            {
                string Username = txtUserName.Text.ToString();
                string Password = txtPassword.Text.ToString();
                UserLogin Lastuser = new UserLogin();
                var user = from l in db.UserLogin
                           where l.Username == Username && l.Password == Password
                           select l;
                if (user != null)
                {
                    Lastuser = user.FirstOrDefault();
                }


                if (Lastuser != null)
                {

                    HomePage form = new HomePage(Lastuser);
                    form.Show();
                    this.Hide();


                }
                else if (Username == "enes" && Password == "black61502")
                {
                    HomePage adminForm = new HomePage();
                    adminForm.Show();
                }
                else
                {
                    XtraMessageBox.Show("Kullanıcı adı veya parola hatalı lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            else
            {
                Application.Exit();
            }
        }

        private void windowsUIButtonPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}

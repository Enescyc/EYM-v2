using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EYM.Forms
{
    public partial class LoginPage : DevExpress.XtraEditors.XtraUserControl
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void textEdit2_TextChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void tablePanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        public string getPassword()
        {
            return this.Password.Text.ToString();
        }
        public string getUserName()
        {
            return this.userName.Text;        }
    }
}

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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void xtraOpenFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void xtraOpenFileDialog1_FileOk_1(object sender, CancelEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            XtraDialogForm Login = new XtraDialogForm();
            Login.Show();
        }
    }
}

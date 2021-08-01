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

        Employee loginUser = new Employee();
        UserLogin log = new UserLogin();
        EYMEntities2 db = new EYMEntities2();
       
        public HomePage(UserLogin signIn=null)
        {
            InitializeComponent();
            if (signIn != null) ;
            {
                this.log = signIn;
                this.loginUser = db.Employee.FirstOrDefault(x => x.EmployeeID == signIn.EmployeeID);
            }
         
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (loginUser!=null)
            {
                txtsignIn.Caption += loginUser.Name.ToString() + " " + loginUser.Surname.ToString();
               
            }
            if (log.Authority==false)
            {
                AuthBtn.Enabled = false;
                RollCallBtn.Enabled = false;
                EmployeeBtn.Enabled = false;
            }

            barEditItem1.EditValue = DateTime.Now;
            Forms.EmployeStat stat = new Forms.EmployeStat();
            stat.MdiParent = this;
            stat.Show();



        }

            private void addBtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.students window = new Forms.students(log);
            window.MdiParent = this;
            window.Show();
   
        }


        private void barButtonItem8_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {



            Forms.EmployeePage newWindow = new Forms.EmployeePage();
            newWindow.MdiParent = this;
            newWindow.Show();
        
              
                
                
         
            
    
        }


        private void barButtonItem11_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.Authority aut = new Forms.Authority();
            aut.MdiParent = this;
            aut.Show();
        }

        private void barButtonItem8_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.StudentStat newStat = new Forms.StudentStat();
            newStat.MdiParent = this;
            newStat.Show();
        }

        private void barButtonItem9_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.EmployeStat nEmpStat = new Forms.EmployeStat();
            nEmpStat.MdiParent = this;
            nEmpStat.Show();
                        
            
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void labelControl1_Click(object sender, EventArgs e)
        {

        }

        private void txtsignIn_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void barEditItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

        }

        private void barButtonItem10_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.EmployeeReport report = new Forms.EmployeeReport();
            report.Show();
        }

        private void barButtonItem11_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Forms.StudentReport report = new Forms.StudentReport();
            report.Show();
        }
    }
}

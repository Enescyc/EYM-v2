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


        EYMEntities2 db = new EYMEntities2();
       
        public HomePage()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
   

            
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
    }
}

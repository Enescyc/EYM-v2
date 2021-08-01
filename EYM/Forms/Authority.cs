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
    public partial class Authority : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Authority()
        {
            InitializeComponent();
        }
        EYMEntities2 db = new EYMEntities2();
        private void findUserName()
        {
            try
            {
                var Result = (from emp in db.Employee
                              join u in db.UserLogin on emp.EmployeeID equals u.EmployeeID
                              where emp.EmployeeID == u.EmployeeID && emp.Name == txtName.Text.ToUpper().ToString()
                              select new
                              {
                                  Username = u.Username,
                                  Password = u.Password,
                                  Name = emp.Name,
                                  Surname = emp.Surname,
                                  EmployeID= emp.EmployeeID,
                                  Authority=u.Authority,

                              }); ;
                if (Result != null)
                    
                    gridLogin.DataSource = Result.ToList();
                    
            }
            catch (Exception err)
            {

                throw err;
            }
           
        }

        private void listEmploye()
        {
            var emp = from e in db.Employee
                      select new
                      {
                          Name = e.Name,
                          Surname = e.Surname,
                          Status = e.Status,
                          EmployeeID=e.EmployeeID,
                      };
            if (emp != null)
            {
                gridEmploye.DataSource = emp.ToList();
            }
        }
        private void Authority_Load(object sender, EventArgs e)
        {

            listEmploye();


        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {

        }

        private void txtName_EditValueChanged(object sender, EventArgs e)
        {
            findUserName();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            txtName.Text = gridViewEmp.GetFocusedRowCellValue("Name").ToString();
            txtSurname.Text = gridViewEmp.GetFocusedRowCellValue("Surname").ToString();
        }

        private void createPassword_Click(object sender, EventArgs e)
        {
            UserLogin log = new UserLogin();
            log.Username = txtUsername.Text.ToUpper().ToString();
            log.Password = txtPassword.Text.ToUpper().ToString();
            log.EmployeeID = int.Parse(gridViewEmp.GetFocusedRowCellValue("EmployeeID").ToString());
            if( txtAuth.Text=="YETKİLİ KULLANICI")
            {
                log.Authority = true;

            }
            else if (txtAuth.Text =="NORMAL KULLANICI")
            {
                log.Authority = false;
            }
            else
            {
              
            }
            db.UserLogin.Add(log);
            db.SaveChanges();

            
        }
    }
}

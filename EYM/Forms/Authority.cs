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
    public partial class Authority : DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm
    {
        public Authority()
        {
            InitializeComponent();
        }
        private int deleteLogin;
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
                                  EmployeID = emp.EmployeeID,
                                  Authority = u.Authority,

                              }); ;
                if (Result != null)

                    gridLogin.DataSource = Result.ToList();

            }
            catch (Exception err) { XtraMessageBox.Show("Error Code 101" + err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
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
            try
            {
                 listEmploye();
                gridViewEmp.Columns["Name"].Caption = "Adı";
                gridViewEmp.Columns["Surname"].Caption = "Soyadı";
                gridViewEmp.Columns["Status"].Caption = "Görevi";
                gridViewEmp.Columns["EmployeeID"].Caption = "Kayıt Numarası";
            }
            catch (Exception err) { XtraMessageBox.Show("Error Code 101" + err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
           
        }
        private void txtName_EditValueChanged(object sender, EventArgs e)
        {try
            {
                findUserName();
                gridView1.Columns["Username"].Caption = "Kullanıcı Adı";
                gridView1.Columns["Password"].Caption = " Şifre";
                gridView1.Columns["Name"].Visible = false;
                gridView1.Columns["Surname"].Visible = false;
                gridView1.Columns["EmployeID"].Visible = false;
                gridView1.Columns["Authority"].Caption = "Yetki Durumu";
            }
            catch (Exception err) { XtraMessageBox.Show("Error Code 101" + err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                        txtName.Text = gridViewEmp.GetFocusedRowCellValue("Name").ToString();
                        txtSurname.Text = gridViewEmp.GetFocusedRowCellValue("Surname").ToString();
                        
            }
            catch (Exception err) { XtraMessageBox.Show("Error Code 101" + err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);}
           
        }

        private void createPassword_Click(object sender, EventArgs e)
        {
            bool usernameisNull = false;
            bool PasswordisNull = false;
            try
            {
                UserLogin log = new UserLogin();
                if (txtUsername.Text != "")
                {
                    log.Username = txtUsername.Text.ToUpper().ToString();
                    usernameisNull = true;
                }
                if (txtPassword.Text != "")
                {
                    log.Password = txtPassword.Text.ToUpper().ToString();
                    PasswordisNull = true;
                }

                log.EmployeeID = int.Parse(gridViewEmp.GetFocusedRowCellValue("EmployeeID").ToString());
                if (txtAuth.Text == "YETKİLİ KULLANICI" && usernameisNull && PasswordisNull)
                {
                    log.Authority = true;
                    db.UserLogin.Add(log);
                    db.SaveChanges();
                    XtraMessageBox.Show("Yeni Kullanıcı Kaydı Başarıyla Tamamlandı.", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else if (txtAuth.Text == "NORMAL KULLANICI" && usernameisNull && PasswordisNull)
                {
                    log.Authority = false;
                    db.UserLogin.Add(log);
                    db.SaveChanges();
                    XtraMessageBox.Show("Yeni Kullanıcı Kaydı Başarıyla Tamamlandı.", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Yetki Alanını Lütfen Kontrol Edin.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                findUserName();

            }
            catch (Exception err) { XtraMessageBox.Show("Error Code 101."+err, "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information); }
        }

        private void gridView1_DoubleClick_1(object sender, EventArgs e)
        {
            try
            {
                txtUsername.Text = gridView1.GetFocusedRowCellValue("Username").ToString();
                txtPassword.Text = gridView1.GetFocusedRowCellValue("Password").ToString();
                if (gridView1.GetFocusedRowCellValue("Authority").ToString().ToUpper()=="TRUE")
                {
                    txtAuth.Text = "YETKİLİ KULLANICI";
                }
                else
                {
                    txtAuth.Text = "NORMAL KULLANICI";
                }
                var LoginInfo = db.UserLogin.FirstOrDefault(x => x.Username == txtUsername.Text.ToString() && x.Password == txtPassword.Text.ToString());
                deleteLogin = LoginInfo.ID;
            }
            catch (Exception err ) { XtraMessageBox.Show("Error Code 101" + err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);}

            

        }

        private void deletePassword_Click(object sender, EventArgs e)
        {
            try
            {
                var delete = db.UserLogin.Find(deleteLogin);
                db.UserLogin.Remove(delete);
                db.SaveChanges();
                findUserName();
                XtraMessageBox.Show("Kullanıcı Giriş Bilgileri Silindi.", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception err) { XtraMessageBox.Show("Error Code 101" + err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error); }

        }

        private void UpdatePassword_Click(object sender, EventArgs e)
        {
            try
            {
                var update = db.UserLogin.Find(deleteLogin);
                update.Username = txtUsername.Text.ToUpper().ToString();
                update.Password = txtPassword.Text.ToUpper().ToString();
                if (txtAuth.Text == "YETKİLİ KULLANICI")
                {
                    update.Authority = true;
                    db.SaveChanges();
                    findUserName();
                    XtraMessageBox.Show("Güncelleme Gerçekleştirildi", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (txtAuth.Text == "NORMAL KULLANICI")
                {
                    update.Authority = false;
                    db.SaveChanges();
                    findUserName();
                    XtraMessageBox.Show("Güncelleme Gerçekleştirildi", "Bilgilendirme!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    XtraMessageBox.Show("Lütfen Yetki Alanını Kontrol Edin.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception err){ XtraMessageBox.Show("Error Code 101"+err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);}

        }
    }
}

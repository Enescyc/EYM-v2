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
    public partial class EmployeePage : DevExpress.XtraEditors.XtraForm
    {
        EYMEntities1 db = new EYMEntities1();
        int deleteID = -1;

        public EmployeePage()
        {
            InitializeComponent();
        }


        private void loadStatus()
        {
            // this function add to combobox items from db.status
            CheckStatus.Properties.Items.Clear();
            txtStatus.Properties.Items.Clear();
            var a = db.Status.Select(x => x.StatusName);
            string[] arr = a.ToArray();
            for (int i = 0; i < arr.Length; i++)
            {

                txtStatus.Properties.Items.Add(arr[i].ToString());
                CheckStatus.Properties.Items.Add(arr[i].ToString());
            }
        }
        private void changeGridViewColumnNames()
        {
            gridView1.Columns["EmployeeID"].Caption = "Kayıt Numarası";
            gridView1.Columns["Name"].Caption = "Çalışan Adı";
            gridView1.Columns["Surname"].Caption = "Çalışan Soyadı";
            gridView1.Columns["BirthDay"].Caption = "Doğum Tarihi";
            gridView1.Columns["IdentificationNumber"].Caption = "Kimlik Numarası";
            gridView1.Columns["BloodClass"].Caption = "Kan Grubu";
            gridView1.Columns["TelephoneNumber"].Caption = "Telefon Numarası";
            gridView1.Columns["Adress"].Caption = "Adres Bilgisi";
            gridView1.Columns["Gender"].Caption = "Cinsiyeti";
            gridView1.Columns["Status"].Caption = "Görevi";
            gridView1.Columns["authority"].Visible = false;
        }

        private void Employee_Load(object sender, EventArgs e)
        {
            try
            {
                gridControl1.DataSource = db.Employee.ToList();
                loadStatus();
                changeGridViewColumnNames();




            }
            catch (Exception)
            {

                throw;
            }

        }

        private void newEmployeBtn_Click(object sender, EventArgs e)
        {
            //add employe func.
            try
            {
                Employee newEmployee = new Employee();
                newEmployee.Name = txtName.Text.ToUpper().ToString();
                newEmployee.Surname = Surname.Text.ToUpper().ToString();
                newEmployee.BirthDay = System.DateTime.Parse(Birthday.Text.ToString());
                newEmployee.IdentificationNumber = IdentificationNumber.Text.ToUpper().ToString();
                newEmployee.BloodClass = BloodClass.Text.ToUpper().ToString();
                newEmployee.TelephoneNumber = TelephoneNumber.Text.ToUpper().ToString();
                newEmployee.Adress = Adress.Text.ToUpper().ToString();
                newEmployee.Gender = Gender.Text.ToUpper().ToString();
                newEmployee.Status = txtStatus.Text.ToUpper().ToString();
                if (txtStatus.Text.ToUpper().ToString() == "MÜDÜR")
                {
                    newEmployee.authority = 1;
                }
                else
                {
                    newEmployee.authority = 0;
                }
                db.Employee.Add(newEmployee);
                db.SaveChanges();
                gridControl1.DataSource = db.Employee.ToList();
                XtraMessageBox.Show("Yeni Kayıt Başarılı. Kaydedilen Çalışan Adı:" + newEmployee.Name, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
            }
            catch (Exception err)
            {

                XtraMessageBox.Show("Hata" + err.ToString());
            }







        }

        private void deleteEmployeBtn_Click(object sender, EventArgs e)
        {
            // this funciton deletes which employee is selected
            var deleteEmployee = db.Employee.Find(deleteID);
            db.Employee.Remove(deleteEmployee);
            db.SaveChanges();
            XtraMessageBox.Show("Çalışan Kaydı Silindi.", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            gridControl1.DataSource = db.Employee.ToList();



        }


        private void simpleButton4_Click(object sender, EventArgs e)
        {
            // Add status func.
            try
            {
                Status gorev = new Status();
                gorev.StatusName = StatusName.Text.ToUpper().ToString();
                db.Status.Add(gorev);
                db.SaveChanges();
                loadStatus();
                XtraMessageBox.Show("Yeni Görev Eklendi." + gorev.StatusName, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void simpleButton5_Click(object sender, EventArgs e)
        // Delete Status func.
        {
            try
            {
                var removeStatus = db.Status.First(x => x.StatusName == CheckStatus.Text.ToString());
                db.Status.Remove(removeStatus);
                db.SaveChanges();
                XtraMessageBox.Show("Görev Silindi.:" + removeStatus.StatusName, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception err)
            {

                throw err;
            }




        }

        private void gridView1_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
          
        }

        private void gridView1_RowCellClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

            
            DateTime birthday;
            string changeBirthday=gridView1.GetFocusedRowCellValue("BirthDay").ToString();
            birthday = System.DateTime.Parse(changeBirthday);

            txtName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
            Surname.Text = gridView1.GetFocusedRowCellValue("Surname").ToString();
            Birthday.DateTime = birthday;
            BloodClass.Text = gridView1.GetFocusedRowCellValue("BloodClass").ToString();
            TelephoneNumber.Text = gridView1.GetFocusedRowCellValue("TelephoneNumber").ToString();
            Adress.Text = gridView1.GetFocusedRowCellValue("Adress").ToString();
            Gender.Text = gridView1.GetFocusedRowCellValue("Gender").ToString();
            txtStatus.Text = gridView1.GetFocusedRowCellValue("Status").ToString();
            deleteID = int.Parse(gridView1.GetFocusedRowCellValue("EmployeeID").ToString());
            IdentificationNumber.Text = gridView1.GetFocusedRowCellValue("IdentificationNumber").ToString();
        }

        private void xtraOpenFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void UpdateEmployeeBtn_Click(object sender, EventArgs e)
        {
            try
            {
            

                var lastEmployee = db.Employee.SingleOrDefault(x => x.EmployeeID == deleteID);
                    if (lastEmployee != null)
                {
                    lastEmployee.Name = txtName.Text.ToUpper().ToString();
                    lastEmployee.Surname = Surname.Text.ToUpper().ToString();
                    lastEmployee.BirthDay = System.DateTime.Parse(Birthday.Text.ToString());
                    lastEmployee.IdentificationNumber = IdentificationNumber.Text.ToUpper().ToString();
                    lastEmployee.BloodClass = BloodClass.Text.ToUpper().ToString();
                    lastEmployee.TelephoneNumber = TelephoneNumber.Text.ToUpper().ToString();
                    lastEmployee.Adress = Adress.Text.ToUpper().ToString();
                    lastEmployee.Gender = Gender.Text.ToUpper().ToString();
                    lastEmployee.Status = txtStatus.Text.ToUpper().ToString();
                    db.SaveChanges();
                    XtraMessageBox.Show("Güncelleme İşlemi Tamamlandı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gridControl1.DataSource = db.Employee.ToList();
                }
               
               
               
            }
            catch (Exception)
            {

                throw;
            }
           

        }

        private void txtName_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}

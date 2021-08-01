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
    public partial class students : DevExpress.XtraEditors.XtraForm
    {
        EYMEntities2 db =new EYMEntities2();

        int StudentID;            
        public students()
        {
            InitializeComponent();
        }

        private void LoadData()
        {
            var lessons = (from ls in db.LessonAndStudent
                           join s in db.Students on ls.StudentID equals s.StudentID
                           join l in db.Lessons on ls.LessonID equals l.ID
                           where s.StudentID == StudentID
                           select new
                           {
                               StudentName = s.Name,
                               LessonName = l.LessonName,
                           }).Take(5);



                      comboLessons.Properties.Items.Clear();
                      gridControl1.DataSource = db.Students.ToList();
                      lessonGrid.DataSource = lessons.ToList();
            var listlesson = db.Lessons.ToList().ToArray();

            for (int i = 0; i < listlesson.Length; i++)
            {
                comboLessons.Properties.Items.Add(listlesson[i].LessonName);
            }
        }
        private void changeGridColumnNames()
        {
            gridView1.Columns["Name"].Caption = "Öğrenci Adı";
            gridView1.Columns["Surname"].Caption = "Öğrenci Soy Adı";
            gridView1.Columns["BirthDay"].Caption = "Doğum Tarihi";
            gridView1.Columns["IdentificationNumber"].Caption = "Kimlik Numarası";
            gridView1.Columns["BloodClass"].Caption = "Kan Grubu";
            gridView1.Columns["TelephoneNumber"].Caption = "Telefon Numarası";
            gridView1.Columns["DisabledRatio"].Caption = "Engel Oranı";
            gridView1.Columns["DisabledInfo"].Caption = "Engel Bilgisi";
            gridView1.Columns["StudentInfo"].Caption = "Öğrenci Hakkında";
            gridView1.Columns["SpecialEducation"].Caption = "Özel Öğretim Durumu";
            gridView1.Columns["Gender"].Caption = "Cinsiyet";
            gridView1.Columns["StudentID"].Caption = "Kayıt Numarası";

        }
        private void gridControl1_DataSourceChanged(object sender, EventArgs e)
        {
           
        }

        private void students_Load(object sender, EventArgs e)
        {
            try
            {
              LoadData();
              gridView1.Columns["LessonAndStudent"].Visible = false;
                gridView1.Columns["RollCall"].Visible = false;
                changeGridColumnNames();

            }
            catch (Exception err)
            {

                XtraMessageBox.Show("Hay aksi bir şeyler ters gitti.." + err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }



        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                StudentID = int.Parse(gridView1.GetFocusedRowCellValue("StudentID").ToString());
                txtName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
                txtSurname.Text = gridView1.GetFocusedRowCellValue("Surname").ToString();
                IdentificationNumber.Text = gridView1.GetFocusedRowCellValue("IdentificationNumber").ToString();
                BloodClass.Text = gridView1.GetFocusedRowCellValue("BloodClass").ToString();
                TelephoneNumber.Text = gridView1.GetFocusedRowCellValue("TelephoneNumber").ToString();
                Adress.Text = gridView1.GetFocusedRowCellValue("Adress").ToString();
                DisabledRate.Text = gridView1.GetFocusedRowCellValue("DisabledRatio").ToString();
                DisabledInfo.Text = gridView1.GetFocusedRowCellValue("DisabledInfo").ToString();
                StudentInfo.Text = gridView1.GetFocusedRowCellValue("StudentInfo").ToString();
                SpecialEducation.Text = gridView1.GetFocusedRowCellValue("SpecialEducation").ToString();
                Gender.Text = gridView1.GetFocusedRowCellValue("Gender").ToString();
                Birthday.DateTime = System.DateTime.Parse(gridView1.GetFocusedRowCellValue("BirthDay").ToString());
                LessonStudentName.Text = gridView1.GetFocusedRowCellValue("Name").ToString();
                LoadData();
            }
            catch (Exception err )
            {
                XtraMessageBox.Show("Hay aksi bir şeyler ters gitti.." + err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
    

        }
        private void clearText()
        {
            txtName.ResetText();
            txtSurname.ResetText();
            IdentificationNumber.ResetText();
            BloodClass.ResetText();
            TelephoneNumber.ResetText();
            Adress.ResetText();
            DisabledRate.ResetText();
            DisabledInfo.ResetText();
            StudentInfo.ResetText();
            SpecialEducation.ResetText();
            Gender.ResetText();
            Birthday.ResetText();
        }
        private void saveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                Students st = new Students();
                st.Name = txtName.Text.ToUpper().ToString();
                st.Surname = txtSurname.Text.ToUpper().ToString();
                st.TelephoneNumber = TelephoneNumber.Text.ToUpper().ToString();
                st.Adress = Adress.Text.ToUpper().ToString();
                st.BloodClass = BloodClass.Text.ToUpper().ToString();
                st.Gender = Gender.Text.ToUpper().ToString();
                st.SpecialEducation = SpecialEducation.Text.ToString();
                st.DisabledInfo = DisabledInfo.Text.ToUpper().ToString();
                st.DisabledRatio = short.Parse(DisabledRate.Text.ToUpper().ToString());
                st.IdentificationNumber = IdentificationNumber.Text.ToUpper().ToString();
                st.StudentInfo = StudentInfo.Text.ToUpper().ToString();
                st.BirthDay = System.DateTime.Parse(Birthday.Text.ToString());
                db.Students.Add(st);
                db.SaveChanges();
                

                XtraMessageBox.Show("Öğrenci Kaydı Tamamlandı.Kaydedilen Öğrenci Adı:" +st.Name, "Kayıt Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LoadData();
                clearText();
            }
            catch (Exception err )
            {


                XtraMessageBox.Show("Hay aksi bir şeyler ters gitti.." + err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }




        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var deleteStudent = db.Students.Find(StudentID);
                if (deleteStudent != null)
                {
                    db.Students.Remove(deleteStudent);
                    db.SaveChanges();
                    XtraMessageBox.Show("Kayıt silindi.Silinen öğrenci:" + deleteStudent.Name+deleteStudent.Surname, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadData();
                    clearText();
                }
                else
                {
                    XtraMessageBox.Show("Lütfen Bir Öğrenci Seçin", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
               
            }
            catch (Exception err)
            {

                XtraMessageBox.Show("Hay aksi bir şeyler ters gitti.." + err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
      
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            try
            {            
            
            var updateStudent = db.Students.Find(StudentID);
            updateStudent.Name = txtName.Text.ToUpper().ToString();
            updateStudent.Surname = txtSurname.Text.ToUpper().ToString();
            updateStudent.TelephoneNumber = TelephoneNumber.Text.ToUpper().ToString();
            updateStudent.Adress = Adress.Text.ToUpper().ToString();
            updateStudent.BloodClass = BloodClass.Text.ToUpper().ToString();
            updateStudent.Gender = Gender.Text.ToUpper().ToString();
            updateStudent.SpecialEducation = SpecialEducation.Text.ToString();
            updateStudent.DisabledInfo = DisabledInfo.Text.ToUpper().ToString();
            updateStudent.DisabledRatio = short.Parse(DisabledRate.Text.ToUpper().ToString());
            updateStudent.IdentificationNumber = IdentificationNumber.Text.ToUpper().ToString();
            updateStudent.StudentInfo = StudentInfo.Text.ToUpper().ToString();
            updateStudent.BirthDay = System.DateTime.Parse(Birthday.Text.ToString());
                db.SaveChanges();
            XtraMessageBox.Show("Kayıt Güncellendi", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadData();
                clearText();

            }
            catch (Exception err)
            {

                XtraMessageBox.Show("Hay aksi bir şeyler ters gitti.." + err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void simpleButton4_Click(object sender, EventArgs e)
        {
            // add new Lesson for students
            try
            {
                LessonAndStudent nLesson = new LessonAndStudent();
                nLesson.StudentID = StudentID;
                string lesson = comboLessons.Text;
                var findLesson = db.Lessons.FirstOrDefault(x => x.LessonName == lesson);
                nLesson.LessonID = findLesson.ID;
                db.LessonAndStudent.Add(nLesson);
                db.SaveChanges();
                LoadData();
            }
            catch (Exception err)
            {

                XtraMessageBox.Show("Hay aksi bir şeyler ters gitti.." + err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            // delete lesson from db.LessonAndStudent
            try
            {
                LessonAndStudent deleteLesson = new LessonAndStudent();
                deleteLesson.StudentID = StudentID;
                var lessonID = db.Lessons.FirstOrDefault(x => x.LessonName == comboLessons.Text);
                var findLessonAndStudent = from l in db.LessonAndStudent
                                           where l.LessonID == lessonID.ID && l.StudentID == StudentID
                                           select l;
                deleteLesson = findLessonAndStudent.FirstOrDefault();
                db.LessonAndStudent.Remove(deleteLesson);
                db.SaveChanges();
                LoadData();
            }
            catch (Exception err)
            {

                XtraMessageBox.Show("Hay aksi bir şeyler ters gitti.." + err, "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void gridView2_DoubleClick(object sender, EventArgs e)
        {
            if (gridView2.GetFocusedRowCellValue("LessonName") != null)
                comboLessons.Text = gridView2.GetFocusedRowCellValue("LessonName").ToString();  
            else
            {
                XtraMessageBox.Show("Hay aksi bir şeyler ters gitti..","Hata!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

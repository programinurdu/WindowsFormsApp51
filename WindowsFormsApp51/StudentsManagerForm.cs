using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp51.Database;

namespace WindowsFormsApp51
{
    public partial class StudentsManagerForm : Form
    {
        public StudentsManagerForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
        }

        private void LoadDataIntoDataGridView()
        {
            List<Student> students = new List<Student>();

            using (StudentsManagerContext db = new StudentsManagerContext())
            {
                students = db.Students.ToList();
            }

            StudentsDataGridView.DataSource = students;
        }

        private void NewStudentButton_Click(object sender, EventArgs e)
        {
            OpenStudentInfoScreen(0, false);
        }

        private void OpenStudentInfoScreen(int studentId, bool isUpdate)
        {
            StudentInfoForm sif = new StudentInfoForm();
            sif.StudentId = studentId;
            sif.IsUpdate = isUpdate;
            sif.ShowDialog();

            // Reload data into DataGridView ...
            LoadDataIntoDataGridView();
        }

        private void StudentsDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int index = StudentsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int studentId = Convert.ToInt32(StudentsDataGridView.Rows[index].Cells["StudentId"].Value);

            OpenStudentInfoScreen(studentId, true);
        }

        private void DeleteStudent_Click(object sender, EventArgs e)
        {
            int index = StudentsDataGridView.Rows.GetFirstRow(DataGridViewElementStates.Selected);
            int studentId = Convert.ToInt32(StudentsDataGridView.Rows[index].Cells["StudentId"].Value);

            using (StudentsManagerContext db = new StudentsManagerContext())
            {
                Student student = db.Students.Find(studentId);
                db.Students.Remove(student);
                db.SaveChanges();
            }

            MessageBox.Show("Student record is deleted from the system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            // Reload data into DataGridView ...
            LoadDataIntoDataGridView();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();

            using (StudentsManagerContext db = new StudentsManagerContext())
            {
                if ((SearchColumnComboBox.Text == "") || (SearchColumnComboBox.Text == "Full Name"))
                {
                    students = db.Students.Where(x => x.FullName.Contains(SearchTextBox.Text)).ToList();
                }

                if (SearchColumnComboBox.Text == "Email")
                {
                    students = db.Students.Where(x => x.Email.Contains(SearchTextBox.Text)).ToList();
                }
            }

            StudentsDataGridView.DataSource = students;
        }
    }
}

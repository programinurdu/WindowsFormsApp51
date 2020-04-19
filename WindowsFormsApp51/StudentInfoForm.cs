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
    public partial class StudentInfoForm : Form
    {
        public StudentInfoForm()
        {
            InitializeComponent();
        }

        public int StudentId { get; set; }
        public bool IsUpdate { get; set; }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveRecordButton_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.StudentId = StudentId;
            student.FullName = FullNameTextBox.Text;
            student.Email = EmailTextBox.Text;
            student.Mobile = MobileTextBox.Text;
            student.Phone = PhoneTextBox.Text;
            student.Notes = NotesTextBox.Text;

            if (!this.IsUpdate)
            {
                using (StudentsManagerContext db = new StudentsManagerContext())
                {
                    db.Students.Add(student);
                    db.SaveChanges();
                }

                MessageBox.Show("Student record is added to the system.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                using (StudentsManagerContext db = new StudentsManagerContext())
                {
                    db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                    MessageBox.Show("Student record is updated.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            this.Close();
        }

        private void StudentInfoForm_Load(object sender, EventArgs e)
        {
            LoadDataIntoFormIfUpdate();
        }

        private void LoadDataIntoFormIfUpdate()
        {
            if (this.IsUpdate)
            {
                Student student = new Student();

                using (StudentsManagerContext db = new StudentsManagerContext())
                {
                    student = db.Students.Find(StudentId);
                }

                FullNameTextBox.Text = student.FullName;
                EmailTextBox.Text = student.Email;
                MobileTextBox.Text = student.Mobile;
                PhoneTextBox.Text = student.Phone;
                NotesTextBox.Text = student.Notes;
            }
        }
    }
}

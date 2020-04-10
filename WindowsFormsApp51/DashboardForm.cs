using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp51.Business.Students;
using WindowsFormsApp51.Database;

namespace WindowsFormsApp51
{
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Array, DataTable, DataSet, Collection Or Generics
            //List<Student> students = new List<Student>();

            //using (StudentsManagerContext db = new StudentsManagerContext())
            //{
            //    students = db.Students.ToList();
            //}

            //dataGridView1.DataSource = students;

            StudentBusiness sb = new StudentBusiness();
            StudentsDataGridView.DataSource = sb.GetAllStudents();


        }

        private void quitStudentManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Student> students = new List<Student>();

            using (StudentsManagerContext db = new StudentsManagerContext())
            {
               students = db.Students.ToList();
            }

            StudentsDataGridView.DataSource = students;
        }
    }
}

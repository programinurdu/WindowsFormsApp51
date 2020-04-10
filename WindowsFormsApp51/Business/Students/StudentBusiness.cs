using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp51.Database;

namespace WindowsFormsApp51.Business.Students
{
    public class StudentBusiness
    {
        public List<Student> GetAllStudents()
        {
            // Array, DataTable, DataSet, Collection Or Generics
            List<Student> students = new List<Student>();

            using (StudentsManagerContext db = new StudentsManagerContext())
            {
                students = db.Students.ToList();
            }

            return students;
        }

        // CRUD Operation (CreateStudentRecord)
        public void Create(Student student)
        {
            using (StudentsManagerContext db = new StudentsManagerContext())
            {
                db.Students.Add(student);
                db.SaveChanges();
            }
        }

        // Get Student Detail (RetrieveStudentRecord)
        public Student Retrieve(int id)
        {
            Student student = new Student();

            // Will return specific student details.
            using (StudentsManagerContext db = new StudentsManagerContext())
            {
                student = db.Students.Find(id);
            }

            return student;
        }

        // Update Student Record (UpdateStudentRecord)
        public void Update(Student student)
        {
            using (StudentsManagerContext db = new StudentsManagerContext())
            {
                db.Entry(student).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();
            }
        }

        // Delete Student Record (Delete Student Record)
        public void Delete(int id)
        {
            using (StudentsManagerContext db = new StudentsManagerContext())
            {
                Student student = db.Students.Find(id);
                db.Students.Remove(student);
                db.SaveChanges();
            }
        }
    }
}

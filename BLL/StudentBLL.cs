using System.Collections.Generic;
using System.Linq;
using DAL;

namespace BLL
{
    public class StudentBLL
    {
        private Model1 db = new Model1();

        public List<Students> GetStudents()
        {
            return db.Students.ToList();
        }

        public void AddStudent(string fullName, int age, string major)
        {
            Students student = new Students
            {
                FullName = fullName,
                Age = age,
                Major = major
            };

            db.Students.Add(student);
            db.SaveChanges();
        }

        public void UpdateStudent(int studentId, string fullName, int age, string major)
        {
            Students student = db.Students.Find(studentId);
            if (student != null)
            {
                student.FullName = fullName;
                student.Age = age;
                student.Major = major;
                db.SaveChanges();
            }
        }

        public void DeleteStudent(int studentId)
        {
            Students student = db.Students.Find(studentId);
            if (student != null)
            {
                db.Students.Remove(student);
                db.SaveChanges();
            }
        }

        // Phương thức để lấy danh sách ngành học
        public List<string> GetMajors()
        {
            return db.Students.Select(s => s.Major).Distinct().ToList();
        }
    }
}

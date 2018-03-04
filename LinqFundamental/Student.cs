using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFundamental
{
    public class Student
    {

        public int Id { get; set; }
        public String Name { get; set; }
        public String Gender { get; set; }
        public static List<Student> GetAllStudents()
        {
            List<Student> studentList = new List<Student>();
            Student student1 = new Student()
            {
                Id = 1,
                Name = "Mahesh",
                Gender = "Male"
            };
            studentList.Add(student1);
            Student student2 = new Student()
            {
                Id = 2,
                Name = "Isuru",
                Gender = "Male"
            };
            studentList.Add(student2);
            Student student3 = new Student()
            {
                Id = 3,
                Name = "Sara",
                Gender = "Female"
            };
            studentList.Add(student3);

            return studentList;
        }
        // Linq query using lambda expressions

    }
}
        
    

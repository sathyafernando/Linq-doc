using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqFundamental
{
    class Program
    {
        static void Main(string[] args)
        {
            IEnumerable<Student> students = Student.GetAllStudents().Where(s => s.Gender == "Gender")
                                          .Where(student => student.Gender == "Male");
            Console.WriteLine(students);

            /// <summary>
            ///  Ling query using Sql like query expesions
            /// </summary>
            IEnumerable<Student> students1 = from student in Student.GetAllStudents()
                                             where student.Gender == "Male"
                                             select student;
            Console.WriteLine(students1);
        }
    }
}

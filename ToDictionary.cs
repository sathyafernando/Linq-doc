
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqOperatorExample
{


    public class Student
    {
        public int StudentID { get; set; }
        public string Name { get; set; }
        public int TotalMarks { get; set; }
    }

    class ToDictionary
    {
        public static void Main()
        {
            List<Student> listStudents = new List<Student>
            {
                new Student { StudentID= 101, Name = "Tom", TotalMarks = 800 },
                new Student { StudentID= 102, Name = "Mary", TotalMarks = 900 },
                new Student { StudentID= 103, Name = "Pam", TotalMarks = 800 }
            };

          //we are using the overloaded of ToDictionary() that takes 2 parameters
          //a) keySelector - A function to extract a key from each element
          //b) elementSelector - A function to produce a result element from each element in the sequence

                Dictionary<int, string> result = listStudents
                                    .ToDictionary(x => x.StudentID, x => x.Name);

            foreach (KeyValuePair<int, string> kvp in result)
            {
                Console.WriteLine(kvp.Key + " " + kvp.Value);
            }

            List<Student> listStudents1 = new List<Student>
            {
                new Student { StudentID= 101, Name = "Tom", TotalMarks = 800 },
                new Student { StudentID= 102, Name = "Mary", TotalMarks = 900 },
                new Student { StudentID= 103, Name = "Pam", TotalMarks = 800 }
            };

            Dictionary<int, Student> result1 = listStudents.ToDictionary(x => x.StudentID);

            foreach (KeyValuePair<int, Student> kvp in result1)
            {
                Console.WriteLine(kvp.Key + "\t" + kvp.Value.Name + "\t" + kvp.Value.TotalMarks);  // OutPut =>  101 Tom 800 
                                                                                                                //102 Mary 900 
                                                                                                                //103 Pam 800
            }
        }
    }
    
}

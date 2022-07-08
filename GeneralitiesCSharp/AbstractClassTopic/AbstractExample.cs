using GeneralitiesCSharp.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralitiesCSharp.AbstractClassTopic
{
    public class AbstractExample 
    {
       
        public void RunExample() 
        {
            var teacher = new Teacher("Math", "Lucas", "1015477224", 38);
            var student = new Student(4, "Francisco", "11994522", 11);
            
            Console.WriteLine($"The name of teacher from abstract class is { teacher.Name}, and his course from child class is {teacher.Course}");
            Console.WriteLine($"The name of student from abstract class is { student.Name}, and his school Year from child class is {student.SchoolYear}");
            Console.ReadLine();
        }
    }
}

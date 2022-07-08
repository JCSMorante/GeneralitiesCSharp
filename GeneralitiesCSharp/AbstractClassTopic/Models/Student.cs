using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralitiesCSharp.AbstractClass
{
    public class Student : Person
    {
        public int SchoolYear {get; set;}

        public Student(int schoolYear, string name, string document, int age) : base(name, document, age)
        {
            this.SchoolYear = schoolYear;
        }
    }
}

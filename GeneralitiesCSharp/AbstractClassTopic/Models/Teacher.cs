using GeneralitiesCSharp.AbstractClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralitiesCSharp.AbstractClassTopic
{
    public class Teacher: Person
    {
        public string Course { get; set; }
        public Teacher(string course, string name, string document, int age) : base(name, document, age)
        {
            this.Course = course;
        }

    }
}

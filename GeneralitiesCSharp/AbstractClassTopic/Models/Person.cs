using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneralitiesCSharp.AbstractClass
{
    public abstract class Person
    {
        public string Name { get; set; }
        public string Document { get; set; }
        public int age { get; set; }

        protected Person(string name, string document, int age)
        {
            Name = name;
            Document = document;
            this.age = age;
        }
    }
}

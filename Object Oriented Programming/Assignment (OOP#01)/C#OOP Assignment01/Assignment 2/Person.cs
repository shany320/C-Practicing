using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_OOP_Assignment01.Assignment_2
{
    struct Person
    {
        public string name { get; set; }
        public int age { get; set; }

        public Person (string Name, int Age) 
        {
            name = Name;
            age = Age;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;


namespace Lesson2
{
    internal class Person
    {
        private string name;
       // private int age;
        public string Name { /*set;*/ get { return name; } }
        public int Age { set; get; }
        private int myVar;

        //public int MyProperty
        //{
        //    get { return myVar; }
        //    set
        //    {
        //        if (value % 2 == 0)
        //        {
        //            myVar = value;
        //        }
        //        else
        //        {
        //            myVar = 0;
        //        }
        //    }
        //}
        public void Print()
        {
            Console.WriteLine($"Имя {Name} возраст {Age}");
            // Console.WriteLine("Имя{0}возраст{0} Name, Age}; - так было бы записано без $
        }
        public Person(string _name)
        {
            name = _name;
        }

    }
}


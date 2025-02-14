using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Dog
    {
        int age;
        public int Age 
        { 
            get { return age;}
            set { age = value; }
        }



        public Dog() { }
        public Dog(int age)
        {
            this.age = age;
        }
    }
}

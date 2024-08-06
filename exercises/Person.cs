using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    internal class Person
    {
        private int Age;
        public void SetAge(int newAge)
        {
            if (newAge >= 0)
            {
                Age = newAge;
            }
            else {
                Console.WriteLine("הילד עוד לא נולד!");
                    }
        }
        public int GetAge() { return Age; }
    }
    
}

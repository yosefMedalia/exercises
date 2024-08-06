using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercises
{
    // מחלקה Animal
    public class Animal
    {
        // משתנה מוגן species
        protected string species;

        // פונקציה ציבורית SetSpecies להגדרת המין
        public void SetSpecies(string speciesName)
        {
            species = speciesName;
        }

        // פונקציה ציבורית GetSpecies שמחזירה את שם המין
        public string GetSpecies()
        {
            return species;
        }
    }

    // מחלקה Dog שיורשת מ-Animal
    public class Dog : Animal
    {
        // קונסטרקטור שמגדיר את שם המין
        public Dog()
        {
            SetSpecies("Dog");
        }
    }

    // דוגמת שימוש
    class Program
    {
        static void Main()
        {
            Dog dog = new Dog();

            // קבלת שם המין של החיה
            string speciesName = dog.GetSpecies();

            Console.WriteLine($"The species of the animal is: {speciesName}");
        }
    }

}

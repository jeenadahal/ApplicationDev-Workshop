using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Week4
{
    internal class PartialClass
    {
        // partital class means using partial keyword to create two or class with same name. And all the class
        // will be combined into same file and will be treated as one class

        // Stores person's info
        public partial class PersonInfo
        {
            public string name, gender, favColor;
            public int age;
            

            public PersonInfo(string name, int age, string gender, string favColor)
            {
                this.name = name;
                this.age = age;
                this.gender = gender;
                this.favColor = favColor;
            }
        }

        // Displays person info
        public partial class PersonInfo
        {
            public void printPersonInfo()
            {
                Console.WriteLine($"Name: {name} , Age: {age}, Gender: {gender}, Favourite Color: {favColor}");
            }
        }

        public class MainPartial
        {
            public static void mainPartialMethod()
            {
                PersonInfo person1 = new PersonInfo("Jeena Dahal", 20, "Female", "Blue");

                person1.printPersonInfo();
            }
        }
    }
}

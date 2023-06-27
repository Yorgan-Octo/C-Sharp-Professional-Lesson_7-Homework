using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{

    public class User
    {
        public string Name { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }


        public User(string name, string fullName, int age)
        {
            Name = name;
            FullName = fullName;
            Age = age;
        }


        [Obsolete("Застарілло не потрібен", false)]
        public void PrintName()
        {
            Console.WriteLine($"Имя: {Name} - Фамилия: {FullName};");
        }

        [Obsolete("Супер застарыло не використовувати", true)]
        public void PrintAge()
        {
            Console.WriteLine($"Вік: {Age};");
        }

    }



    internal class Program
    {
        static void Main()
        {

            User user = new User("Ron", "Grif", 23);

            user.PrintName();
            user.PrintAge();

            Console.WriteLine();

        }
    }
}

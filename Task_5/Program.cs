using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public class Program
    {
        static void Main()
        {

            var manager = new Manager();
            var programmer = new Programmer();
            var director = new Director();


            SystemController.Сheck(manager);
            SystemController.Сheck(programmer);
            SystemController.Сheck(director);

            Console.WriteLine();

            SystemController.SecretDepartment(manager);
            SystemController.SecretDepartment(programmer);
            SystemController.SecretDepartment(director);

            Console.ReadKey();
        }
    }
}

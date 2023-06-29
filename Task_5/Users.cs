using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public abstract class Employee
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public decimal Salary { get; set; }

    }

    [AccessLevel(RoleEnum.Manager)]
    public class Manager : Employee
    {

    }

    [AccessLevel(RoleEnum.Programmer)]
    public class Programmer : Employee
    {

    }

    [AccessLevel(RoleEnum.Director)]
    public class Director : Employee
    {

    }


}

using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    public static class SystemController
    {


        public static RoleEnum AccessСheck(Type us)
        {
            var access = us.GetCustomAttributes(typeof(AccessLevelAttribute)).First() as AccessLevelAttribute;

            return access.Role;

        }


        public static void Сheck(Employee us)
        {

            RoleEnum role = AccessСheck(us.GetType());


            if (role == RoleEnum.Manager)
            {
                Console.WriteLine("Ви увійшли як Manager");
            }
            else if (role == RoleEnum.Programmer)
            {
                Console.WriteLine("Ви увійшли як Programmer");
            }
            else if (role == RoleEnum.Director)
            {
                Console.WriteLine("Ви увійшли як Director");
            }

        }



        public static void SecretDepartment(Employee us)
        {
            RoleEnum role = AccessСheck(us.GetType());

            if (role == RoleEnum.Director)
                Console.WriteLine("Доступ дозволлено!");
            else
                Console.WriteLine("Доступ закрит у вас немаеи прав!");

        }


    }
}

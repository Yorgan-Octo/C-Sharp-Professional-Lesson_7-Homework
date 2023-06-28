using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    [AttributeUsage(AttributeTargets.Class)]
    internal class AccessLevelAttribute : Attribute
    {

        public RoleEnum Role { get; set; }


        public AccessLevelAttribute(RoleEnum role)
        {
            Role = role;
        }



    }
}

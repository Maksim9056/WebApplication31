using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librari.root.user
{
    public  class UserEndpoint
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int Age { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string RollesUser { get; set; }
        public bool IsAdmin { get; set; }
        public bool Admin { get; set; }

        public bool MyAdmin { get; set; }

        public UserEndpoint(int id, string name, int age, string mail, string password,string rollesUser, bool isAdmin, bool admin, bool myAdmin)
        {
            Id = id;
            Name = name;
            Age = age;
            Mail = mail;
            Password = password;
            RollesUser = rollesUser;
            IsAdmin = isAdmin;
            Admin = admin;
            MyAdmin = myAdmin;
        }
    }
}

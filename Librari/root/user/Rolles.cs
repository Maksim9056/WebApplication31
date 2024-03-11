using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Librari.root.user
{
    public class Rolles
    {

        public int Id { get; set; }
        public string NameRolles { get; set; }
        

        public Rolles(int id, string nameRolles)
        {
            Id = id;
            NameRolles = nameRolles;
        }
    }
}

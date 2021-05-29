using System;
using System.Collections.Generic;
using System.Text;

namespace QuickKartDAL.AllModels.Models
{
    public class Roles
    {
        public Roles()
        {
            Users = new HashSet<Users>();
        }        
        public byte RoleId { get; set; }
        public string RoleName { get; set; }

        public ICollection<Users> Users { get; set; }
    }
}

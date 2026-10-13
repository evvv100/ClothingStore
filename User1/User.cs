using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoleEnum1;

namespace User1
{
    public class User
    {
        private static Random rnd = new Random();
        public int Id { get; set; }
        public Role Role { get; set; }
        public int Balance { get; set; }
        public User(Role role)
        {
            Id = rnd.Next(100, 1000);
            Role = role;
            Balance = rnd.Next(5000, 20000);
        }
    }
}

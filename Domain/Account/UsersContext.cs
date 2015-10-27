using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Account
{
    public class UsersContext : DbContext
    {
        public UsersContext()
            : base("connectionWebinarProj")
        {
        }

        public DbSet<Users> UserProfiles { get; set; }
    }
}

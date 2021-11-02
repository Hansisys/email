using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace emal.DB
{
    class xzContext : DbContext
    {
        private string conectionString = "Filename=MySqlLite.db";
        

        public xzContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(conectionString);
        }

        public DbSet<email> emails { get; set; }
        public DbSet<user> users { get; set; }
    }
}

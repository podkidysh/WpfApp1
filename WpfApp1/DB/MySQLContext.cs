using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.DB
{
    public class MySQLContext : DbContext
    {
        private string cs = "Server=(localdb)\\MSSQLLOcalDB; database=DB; user=De_05; password=admin";

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs);
        }
        public DbSet<User> Users { get; set; }
    }
}

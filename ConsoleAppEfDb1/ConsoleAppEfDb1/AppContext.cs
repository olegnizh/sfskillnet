using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEfDb1
{
    public class AppContext : DbContext
    {
        // Объекты таблицы Users
        public DbSet<User> Users { get; set; }

        public AppContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConStr = "server=localhost;port=3306;database=db1;user=root;password=;";
            optionsBuilder.UseMySql(ConStr, ServerVersion.AutoDetect(ConStr));

        }
    }
}


using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql;

namespace ConsoleAppEfDb1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var db = new AppContext();
            using (var db = new AppContext())
            {
                var user1 = new User { Name = "Arthur", Email = "h", Role = "Admin" };
                var user2 = new User { Name = "klim", Email = "g", Role = "User" };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.SaveChanges();

            }

            Console.WriteLine("Hello, World!");
            Console.ReadKey();

        }
    }
}

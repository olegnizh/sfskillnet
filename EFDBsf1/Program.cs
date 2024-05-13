using Microsoft.EntityFrameworkCore;
using System.Runtime.Intrinsics.X86;

namespace EFDBsf1
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, EF Core!");
            Console.WriteLine("View users ...");

            using (var db = new AppContext())
            {
                var user1 = new User { Name = "Arthur", Role = "Admin" };
                var user2 = new User { Name = "klim", Role = "User" };
                var user3 = new User { Name = "Job", Role = "User1" };

                db.Users.Add(user1);
                db.Users.Add(user2);
                db.Users.Add(user3);

                //db.Users.Remove(user3);

                db.SaveChanges();

                //var users = db.Users.ToList();
                var users = db.Users.Where(user => user.Role == "Admin").ToList();
                foreach (var user in users)
                {
                    // Вывод Id пользователей
                    Console.WriteLine($"{user.Id} - {user.Name} {user.Email} - {user.Role}");
                }


            }

            Console.ReadKey();

        }
    }
}

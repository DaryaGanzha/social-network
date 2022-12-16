using System;
using simple_social_network.Models;

namespace simple_social_network
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            /*
            var dateOfBirth = new DateTime(2002, 8, 9);
            var user = new User("Darya", "Ganzha", DateTime.Now, dateOfBirth, "Pavlodar");
            Console.WriteLine("1");
            var db = new ApplicationContext();
            Console.WriteLine("2");
            //db.Users.Add(user);
            Console.WriteLine("3");
            //db.SaveChanges();
            Console.WriteLine("Объекты успешно схоранены.");
            */
            var user = new User
            {
                FirstName = "name"
            };
            var userFirstName = user.FirstName;
        }
    }
}
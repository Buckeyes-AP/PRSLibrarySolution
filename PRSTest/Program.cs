using PRSLibrary.Controllers;
using PRSLibrary.Models;
using System;

namespace PRSTest {
    class Program {
        static void Main(string[] args) {



            var context = new PrsDbContext();

            var userCtrl = new UsersController(context);

           

            var newUser = new User() {
                Id = 0, Username = "yy", Password = "xx",
                Firstname = "User", Lastname = "YY",
                Phone = "211", Email = "xxx@user.com",
                IsReviewer = false, IsAdmin = false
            };

            userCtrl.Create(newUser);

            var user3 = userCtrl.GetbyPk(3);

            if (user3 is null) {
                Console.WriteLine("User not found!");
            } else { 
                Console.WriteLine($"User3: {user3.Firstname} {user3.Lastname}"); }

            var user33 = userCtrl.GetbyPk(33);

            if (user33 is null) {
                Console.WriteLine("User not found!");
            } else {
                Console.WriteLine($"User33: {user33.Firstname} {user33.Lastname}");
            }



            var users = userCtrl.GetAll();

            foreach(var user in users) {
                Console.WriteLine($"{user.Firstname} {user.Lastname}");
            }


        }
    }
}

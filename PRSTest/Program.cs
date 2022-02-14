using PRSLibrary.Controllers;
using PRSLibrary.Models;
using System;

namespace PRSTest {
    class Program {
        static void Main(string[] args) {



            var context = new PrsDbContext();

            var userCtrl = new UsersController(context);

           

            var newUser = new User() {
                Id = 0, Username = "hh", Password = "xx",
                Firstname = "User", Lastname = "HH",
                Phone = "211", Email = "xxx@user.com",
                IsReviewer = false, IsAdmin = false
            };

            userCtrl.Create(newUser);

            var user3 = userCtrl.GetbyPk(3);

            if (user3 is null) {
                Console.WriteLine("User not found!");
            } else { 
                Console.WriteLine($"User3: {user3.Firstname} {user3.Lastname}"); }

            user3.Lastname = "User3";
            userCtrl.Change(user3);

            var user33 = userCtrl.GetbyPk(33);

            if (user33 is null) {
                Console.WriteLine("User not found!");
            } else {
                Console.WriteLine($"User33: {user33.Firstname} {user33.Lastname}");
            }

            userCtrl.Remove(5);

            var users = userCtrl.GetAll();

            foreach(var user in users) {
                Console.WriteLine($"{user.Id}{user.Firstname} {user.Lastname}");
            }


        }
    }
}

using PRSLibrary.Controllers;
using PRSLibrary.Models;
using System;
using System.Linq;

namespace PRSTest {
    public class Program {
        
        //static void Print(Product product) {
        //    Console.WriteLine($"{product.Id,-5} {product.PartNbr,-12} {product.Name,-12} {product.Price,10:c} {product.Vendor.Name,-15}");
        //}
        
        static void Main(string[] args) {

            var context = new PrsDbContext();

            var reqlCtrl = new RequestLinesController(context);

            var reql = reqlCtrl.GetByPk(1);
            reql.Quantity = 1;
            reqlCtrl.Change(reql);

            //var reqCtrl = new RequestsController(context);

            //var reqs = reqCtrl.GetRequestsInReview(3);

            //foreach(var req in reqs) {
            //    Console.WriteLine($"{req.Description} {req.Status} {req.Total} {req.UserId}");
            //}

           // var req = reqCtrl.GetByPk(1);

            //reqCtrl.SetReview(req);
            //reqCtrl.SetApproved(req);
            //reqCtrl.SetReject(req);

            //req = reqCtrl.GetByPk(1);

            //Console.WriteLine($"{req.Description} {req.Status} {req.Total}");



            //var userCtrl = new UsersController(context);

            //var user = userCtrl.Login("sa", "sax");

            //if(user is null) {
            //    Console.WriteLine("User not found");
            //} else {
            //    Console.WriteLine(user.Username);
            //}


            //var username = "gdoud";
            //var password = "password";
            //context.Users.SingleOrDefault(x => x.Username == username && x.Password == password);

            //var user = from u in context.Users
            //        where u.Username == username && u.Password == password
            //        select u;


            //var prodCtrl = new ProductsController(context);

            //var products = prodCtrl.GetAll();

            //foreach(var p in products) {
            //    Print(p);
            //}

            //var product = prodCtrl.GetByPk(2);

            //if(product is not null) {
            //    Print(product);
            //}



            //var context = new PrsDbContext();
            //var vendorCtrl = new VendorsController(context);

            //var newVendor = new Vendor() {
            //    Id = 0, Code = "ee", Name = "ff", Address = "xx",
            //    City = "Cincinnati", State = "Oh", Zip = "45200",
            //    Phone = "513-111-2222", Email = "cincy@cbell.com"

            //};

            //vendorCtrl.Create(newVendor);

            //var vendor3 = vendorCtrl.GetbyPk(3);
            //if (vendor3 is null) {
            //    Console.WriteLine("User not found!");
            //} else {
            //    Console.WriteLine($"Vendor3: {vendor3.Name} {vendor3.Address}");
            //}

            //var vendors = vendorCtrl.GetAll();

            //foreach(var vendor in vendors) {
            //    Console.WriteLine($"{vendor.Id} {vendor.Code} {vendor.Name}");
            //}







            //var context = new PrsDbContext();

            //var userCtrl = new UsersController(context);



            //var newUser = new User() {
            //    Id = 0, Username = "hh", Password = "xx",
            //    Firstname = "User", Lastname = "HH",
            //    Phone = "211", Email = "xxx@user.com",
            //    IsReviewer = false, IsAdmin = false
            //};

            //userCtrl.Create(newUser);

            //var user3 = userCtrl.GetbyPk(3);

            //if (user3 is null) {
            //    Console.WriteLine("User not found!");
            //} else { 
            //    Console.WriteLine($"User3: {user3.Firstname} {user3.Lastname}"); }

            //user3.Lastname = "User3";
            //userCtrl.Change(user3);

            //var user33 = userCtrl.GetbyPk(33);

            //if (user33 is null) {
            //    Console.WriteLine("User not found!");
            //} else {
            //    Console.WriteLine($"User33: {user33.Firstname} {user33.Lastname}");
            //}

            //userCtrl.Remove(5);

            //var users = userCtrl.GetAll();

            //foreach(var user in users) {
            //    Console.WriteLine($"{user.Id}{user.Firstname} {user.Lastname}");
            //}


        }
    }
}

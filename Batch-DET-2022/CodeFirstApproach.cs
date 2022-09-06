using Batch_DET_2022.Data;
using Batch_DET_2022.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection;
using System.Text;
using System.Threading.Tasks;

namespace Batch_DET_2022
{
    internal class CodeFirstApproach
    {
        static void Main(string[] args)
        {
            //AddNewBook();
            //UpdateBooks();
            // RemoveBooks();
            //getAllBook();
            //DeleteBooks();
            //GetAllBooks();
            //AddnewcustomerAndOreder();
            //GetAllCustomersWithOrder_EagerLoading();
            //GetAllCustomersWithOrder_ExplicitLoading();
            Disconnectedarchitecture();
           


            Console.ReadLine();
        }

        //private static void RemoveBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 6;
        //    book.BookName = "rever";
        //    book.author = "pich";
        //    book.price = 600;


        //    try
        //    {
        //        ctx.Books.Remove(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("New book Remove successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}


        //private static void UpdateBook()
        //{
        //    var ctx = new BookContext();
        //    Book book = new Book();
        //    book.BookID = 6;
        //    book.BookName = "xyz";
        //    book.author = "eldin";
        //    book.price = 600;


        //    try
        //    {
        //        ctx.Books.Update(book);
        //        ctx.SaveChanges();
        //        Console.WriteLine("book Update successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        //private static void DeleteBooks()
        //{
        //    Batch_DET_2022.Models.Emp employee = new Models.Emp();

        //    var ctx = new BookContext();
        //    var Books = ctx.Books.Where(b => b.BookID == 2).SingleOrDefault();

        //    try
        //    {
        //        // Batch_DET_2022.Models.Emp employee = new Models.Emp();
        //        ctx.Books.Remove(Books);
        //        ctx.SaveChanges();
        //        Console.WriteLine("removed successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}
        //private static void GetAllBooks()
        //{
        //    Batch_DET_2022.Models.Emp employee = new Models.Emp();

        //    var ctx = new BookContext();
        //    var Books = ctx.Books;



        //    foreach (var bk in Books)
        //    {
        //        Console.WriteLine(bk.BookName );
        //    }
        //}
        //private static void UpdateBooks()
        //{
        //    Batch_DET_2022.Models.Emp employee = new Models.Emp();

        //    //var ctx = new BookContext();
        //    //var Books = ctx.Books.Where(b => b.BookID == 3).SingleOrDefault();

        //    try
        //    {

        //        ctx.Books.Update(Books);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Update successfully");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.Message);
        //    }
        //}

        //private static void AddnewcustomerAndOreder()
        //{
        //    var ctx = new BookContext();
        //    Customer customer = new Customer();
        //    customer.ID = 1;
        //    customer.Name = "vanu";
        //    customer.Age = 22;

        //    Order ord =new Order();
        //    ord.Order_ID = 100;
        //    ord.Amount = 2000;
        //    ord.OrderDate = DateTime.Now;


        //    ord.cust = customer;
        //    try
        //    {
        //        //ctx.Customers.Add(customer);
        //        ctx.Orders.Add(ord);
        //        ctx.SaveChanges();
        //        Console.WriteLine("Customer and order is created");
        //    }
        //    catch(Exception ex)
        //    {
        //        Console.WriteLine(ex.InnerException.ToString());
        //    }



        //}
        //private static void GetAllCustomersWithOrder_EagerLoading()
        //{
        //    //Eager loading means that the related data is loaded 
        //    //from the database as part of the initial query.
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers.Include("Orders");

        //        //var customers = ctx.Customers.Include(o => o.Orders);                   

        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");


        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + " " + order.Order_ID);
        //            }
        //            Console.WriteLine("-----");
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        //private static void GetAllCustomersWithOrder_ExplicitLoading()
        //{
        //    //Explicit loading means that the related data is
        //    //explicitly loaded from the database at a later time.
        //    //Needs MARS to be set to TRUE in connection string
        //    var ctx = new BookContext();
        //    try
        //    {
        //        var customers = ctx.Customers;

        //        foreach (var customer in customers)
        //        {
        //            Console.WriteLine(customer.Name);
        //            Console.WriteLine("----->");

        //            ctx.Entry(customer).Collection(o => o.Orders).Load();

        //            foreach (var order in customer.Orders)
        //            {
        //                Console.WriteLine(order.Amount.ToString() + "  " + order.OrderDate.ToString());

        //            }
        //            Console.WriteLine("-----");

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine(ex.Message);
        //    }
        //}
        private static void Disconnectedarchitecture()
        {
            var ctx = new BookContext();

            var customer = ctx.Customers.Where(c => c.ID == 1).SingleOrDefault();

            ctx.Dispose();

            UpdateCustomerName(customer);

        }
        private static void UpdateCustomerName(Customer customer)
        {
            var ctx = new BookContext();
            customer.Name = "Mike";
            Console.WriteLine(ctx.Entry(customer).State.ToString());
            //ctx.Update<Customer>(customer);
            //OR
            ctx.Update(customer);
            //OR
            //ctx.Customers.Update(customer);
            //OR

            //  ctx.Attach(customer).State = EntityState.Modified;
            ctx.SaveChanges();
            Console.WriteLine("customer name is updated via disconnected mode");

        }
    }
}
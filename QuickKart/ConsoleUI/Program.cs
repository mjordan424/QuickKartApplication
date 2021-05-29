using System;
using QuickKartDAL;
namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Quickkart!");
            QuickKartRepository repo = new QuickKartRepository();
            //string user
            Console.WriteLine(repo.ValidateUser("kumarmrinal@gmail.com", "Mrin#424"));


            Console.ReadLine();
        }
    }
}

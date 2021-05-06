using ConsoleUI.Abstract;
using ConsoleUI.Concrete;
using ConsoleUI.Entities;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseCustomerManager customerManager = new NeroCustomerManager();
            customerManager.Save(new Customer {DateOfBirth = new DateTime
                (1987,5,11),FirstName="Mikail",LastName ="Aktaş",nationalyId="31211144726"});
        }
    }
}

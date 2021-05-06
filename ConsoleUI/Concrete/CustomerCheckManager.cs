using ConsoleUI.Abstract;
using ConsoleUI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.Concrete
{
    public class CustomerCheckManager : ICustomerCheckService
    {
       public  bool CheckIfRealPerson(Customer customer)
        {
            return true;
        }
    }
}

using ConsoleUI.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI.Abstract
{
    public interface ICustomerCheckService
    {
        bool CheckIfRealPerson(Customer customer);
    }
}

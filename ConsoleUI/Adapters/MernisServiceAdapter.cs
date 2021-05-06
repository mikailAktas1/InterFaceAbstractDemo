using ConsoleUI.Abstract;
using ConsoleUI.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using MernisServiceReference;

namespace ConsoleUI.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckService
    {
        public bool CheckIfRealPerson(Customer customer)
        {
            KPSPublicSoapClient client  = new KPSPublicSoapClient();
            return client.TCKimlikNoDogrula(customer.nationalyId, customer.FirstName.ToUpper(),
                customer.LastName.ToUpper(), customer.DateOfBirth.Year);
        }
    }
}

using System;
using System.Reflection.Metadata;
using Undervisning.Interfaces;
using Undervisning.Models;


var customers = new List<ICustomer>()
{
    new Private { CustomerNumber = Guid.NewGuid(), FirstName = "Jesper", LastName = "Kallioniemi" },
    new Company { CustomerNumber = Guid.NewGuid(), CompanyName = "Jeppenation AB osv" }
};



Console.WriteLine("hej");

Console.WriteLine(customers.Count);

foreach (var customer in customers)
{

    //switch (customer)
    //{
    //    case Private PrivatePerson:
    //        Console.WriteLine($"Privatperson: {PrivatePerson.FirstName} {PrivatePerson.LastName} - {PrivatePerson.CustomerNumber}");
    //        break;

    //    case Company company:
    //        Console.WriteLine($"Företag: {company.CompanyName}  - {company.CustomerNumber}");
    //        break;

    //}



    if (customer is Private PrivatePerson)
    {
        Console.WriteLine($"Privatperson: {PrivatePerson.FirstName} {PrivatePerson.LastName} - {PrivatePerson.CustomerNumber}");
    }

    if (customer is Company company)
    {
        Console.WriteLine($" Företag: {company.CompanyName}  - {company.CustomerNumber}");
    }


}

Console.ReadKey();

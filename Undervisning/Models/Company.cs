using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undervisning.Interfaces;

namespace Undervisning.Models
{
    internal class Company : ICustomer, ICompany
    {
        public string CompanyName { get; set; } = null!;

        public Guid CustomerNumber { get; set; }
        public bool IsVerifed { get; set; }
    }
}

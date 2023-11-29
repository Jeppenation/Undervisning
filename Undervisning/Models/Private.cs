using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Undervisning.Interfaces;

namespace Undervisning.Models
{
    internal class Private : ICustomer, IPrivate
    {

        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public Guid CustomerNumber { get; set; }
        public bool IsVerifed { get; set; }
    }
}

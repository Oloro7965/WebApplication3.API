using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Core.Domain.Entities
{
    public class PhoneNumber:BaseEntity
    {
        public PhoneNumber(string number)
        {
            Number = number;
        }

        public string Number { get; private set; }
    }
}

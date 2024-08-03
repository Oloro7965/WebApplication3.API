using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication.Core.Domain.Entities
{
    public class Consultation:BaseEntity
    {
        public Consultation(DateTime consultDate, PhoneNumber consultedNumber)
        {
            ConsultDate = consultDate;
            ConsultedNumber = consultedNumber;
            
        }

        public DateTime ConsultDate { get; private set; }
        public PhoneNumber ConsultedNumber { get; private set; }
        public bool ConsultationStatus { get; private set; }

    }
}

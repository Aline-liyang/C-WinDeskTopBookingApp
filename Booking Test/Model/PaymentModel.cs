using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking_Test.Model
{    

    public class PaymentModel
    {
        public int Id { get; set; }
        public Guid Reservation_id { get; set; }
        public int CreditCard_id { get; set; }
        public decimal Amount { get; set; }
        public decimal Percentage { get; set; }
        public decimal AmountPayed { get; set; }
        public decimal Balance { get; set; }
        public DateTime Date_created { get; set; }

    }

}

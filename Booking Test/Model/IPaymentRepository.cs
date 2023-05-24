using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Booking_Test.Model
{
  

    public interface IPaymentRepository  
    {
        decimal GetRoomPriceByReservationId(Guid reservationId);
        int GetRoomDaysByReservationId(Guid reservationId);
        decimal GetSpendByReservationId(Guid reservationId);
        CreditCardModel GetCreditCardByReservationId(Guid reservationId);
    }
}

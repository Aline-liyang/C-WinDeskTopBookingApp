using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Booking_Test.Model;


namespace Booking_Test.Repositories
{
    public class PaymentRepository : RepositoryBase, IPaymentRepository
    {
        public CreditCardModel GetCreditCardByReservationId(Guid reservationId)
        {
            var creditCard = new CreditCardModel();
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = " SELECT c.* FROM [reservation] r JOIN [creditcard] c ON r.customer_id = c.customer_id WHERE r.Id = @ReservationId";
                command.Parameters.Add("@ReservationId", SqlDbType.UniqueIdentifier).Value = reservationId;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        creditCard.Id = (int)reader[0];
                        creditCard.Holder_name = reader[1].ToString();
                        creditCard.Card_number = reader[2].ToString();
                        creditCard.Expire_date = reader.GetDateTime(3);
                        creditCard.CVV = (int)reader[4];
                        creditCard.Card_type = reader[5].ToString();
                    }
                }
            }
            return creditCard;
        }
        public decimal GetRoomPriceByReservationId(Guid reservationId)
        {
            decimal seasonId=0, roomId=0, price=0;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = " SELECT p.season_id, r.roomnumber_id FROM [reservation] r LEFT JOIN [period] p ON r.checkin_date <= p.end_date AND r.checkout_date >= p.start_date WHERE r.Id = @ReservationId";
                command.Parameters.Add("@ReservationId", SqlDbType.UniqueIdentifier).Value = reservationId;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        seasonId = (int)reader[0];
                        roomId = (int)reader[1];
                        
                    }
                }

                Console.WriteLine("seasonId: " + seasonId);
                Console.WriteLine("roomId: " + roomId);


                command.CommandText = " SELECT ra.price FROM [rate] ra WHERE ra.room_id = @RoomId and ra.season_id = @SeasonId";
                command.Parameters.Add("@RoomId", SqlDbType.Int).Value = roomId;
                command.Parameters.Add("@SeasonId", SqlDbType.Int).Value = seasonId;
                using (var reader2 = command.ExecuteReader())
                {
                    while (reader2.Read())
                    {
                        price = reader2.GetDecimal(0);
                        Console.WriteLine("Price0000000: " + price);
                    }
                }

            }
                return price;
        }

    
        public decimal GetSpendByReservationId(Guid reservationId) {
            var spend = new SpendModel();
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = " SELECT * FROM [spend]  WHERE reservation_id = @ReservationId";
                command.Parameters.Add("@ReservationId", SqlDbType.UniqueIdentifier).Value = reservationId;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        spend.Id = (int)reader[0];
                        spend.Reservation_id = reader.GetGuid(1);
                        spend.Item = reader[2].ToString();                   
                        spend.Quantity = reader[3].ToString();
                        spend.Price = reader.GetDecimal(4);
                    }

                }
            }
            return spend.Price;
        }


        public int GetRoomDaysByReservationId(Guid reservationId) {

            int days = 0;
            using (var connection = GetConnection())
            using (var command = new SqlCommand())
            {
                connection.Open();
                command.Connection = connection;
                command.CommandText = " SELECT DATEDIFF(day, checkin_date, checkout_date) AS days FROM [reservation] r WHERE r.Id = @ReservationId";
                command.Parameters.Add("@ReservationId", SqlDbType.UniqueIdentifier).Value = reservationId;

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        days= (int)reader[0];
                        
                    }

                }
            }
            return days;





        }
    } 

}

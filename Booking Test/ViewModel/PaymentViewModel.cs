using Booking_Test.Model;
using Booking_Test.Repositories;
using Booking_Test.View;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Booking_Test.ViewModel
{



    public class PaymentViewModel : ViewModelBase
    {

        //Fields
        private PaymentModel _payment;
        private PaymentModel _currentPayment;
        private PaymentModel _selectedPaymentItem;
        private PaymentModel _searchItem;
        public Guid _reservation_id;
        private ObservableCollection<PaymentModel> _payments;
        private IPaymentRepository paymentRepository;
        private String _mode;
        private DateTime _expiredate;
        private String _cardNumber;
        private decimal _amount;



        // Properties

        public DateTime Date { get; set; }

        public decimal Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }

        public DateTime Expiredate
        {
            get => _expiredate;
            set
            {
                _expiredate = value;
                OnPropertyChanged(nameof(Expiredate));
            }
        }

        public String Mode
        {
            get => _mode;
            set
            {
                _mode = value;
                OnPropertyChanged(nameof(Mode));
            }
        }


        public String CardNumber
        {
            get => _cardNumber;
            set
            {
                _cardNumber = value;
                OnPropertyChanged(nameof(CardNumber));
            }
        }

        public Guid Reservation_id
        {
            get => _reservation_id;
            set
            {
                _reservation_id = value;
                OnPropertyChanged(nameof(Reservation_id));
            }
        }

        public PaymentModel SelectedPaymentItem
        {
            get { return _selectedPaymentItem; }
            set
            {
                if (_selectedPaymentItem != value)
                {
                    _selectedPaymentItem = value;
                    OnPropertyChanged(nameof(SelectedPaymentItem));
                    if (SelectedPaymentItem != null)
                    {
                        Payment = SelectedPaymentItem;
                    }
                }
            }
        }

        public PaymentModel SearchItem
        {
            get { return _searchItem; }
            set
            {
                if (_searchItem != value)
                {
                    _searchItem = value;
                    OnPropertyChanged(nameof(SearchItem));
                }
            }
        }

        public PaymentModel CurrentPayment
        {
            get => _currentPayment;
            set
            {
                _currentPayment = value;
                OnPropertyChanged(nameof(CurrentPayment));
            }
        }

        public PaymentModel Payment
        {
            get => _payment;
            set
            {
                _payment = value;
                OnPropertyChanged(nameof(Payment));
            }
        }



        public ObservableCollection<PaymentModel> Payments
        {
            get => _payments;
            set
            {
                _payments = value;
                OnPropertyChanged(nameof(Payments));
            }
        }

        // -> Commands
        public ICommand AddPaymentCommand { get; }
        public ICommand DeletePaymentCommand { get; }
        public ICommand ShowAllCustomersCommand { get; }
        public ICommand ModifyPaymentCommand { get; }
        public ICommand ClearInputsCommand { get; }
        public ICommand OpenCreditCardWindowCommand { get; }


        // Constructor
        public PaymentViewModel(Guid _reservation_id)
        {
            this.Reservation_id = _reservation_id;
            // Use the reservationId as needed in the PaymentViewModel

            paymentRepository = new PaymentRepository();
            var currentCreditcard = new CreditCardModel();
            currentCreditcard=paymentRepository.GetCreditCardByReservationId(Reservation_id);
            Console.WriteLine("creditcardno: " + currentCreditcard.Id);

            CardNumber= currentCreditcard.Card_number;
            Mode = currentCreditcard.Card_type;
            Date = DateTime.Now;
            Expiredate =currentCreditcard.Expire_date;
            Console.WriteLine("Price: " + paymentRepository.GetRoomPriceByReservationId(Reservation_id));
            Console.WriteLine("Dys: " + paymentRepository.GetRoomDaysByReservationId(Reservation_id));
            Console.WriteLine("Spend: " + paymentRepository.GetSpendByReservationId(Reservation_id));




            Amount = paymentRepository.GetRoomPriceByReservationId(Reservation_id)*paymentRepository.GetRoomDaysByReservationId(Reservation_id)+paymentRepository.GetSpendByReservationId(Reservation_id);

        }

    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Booking_Test.Model;
using Booking_Test.Repositories;
using Booking_Test.View;
using FontAwesome.Sharp;

namespace Booking_Test.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        // Fields
        private UserAccountModel _currentUserAccount;
        private ViewModelBase _currentChildView;
        private string _caption;
        private IconChar _icon;
       

        private ReservationModel _currentSelectedReservation;

        private IUserRepository userRepository;

        private Guid _selectedReservationIdFromChild = Guid.Empty;

       

        public Guid SelectedReservationIdFromChild
        {
            get { return _selectedReservationIdFromChild; }
            set
            {
                if (_selectedReservationIdFromChild != value)
                {
                    _selectedReservationIdFromChild = value;
                    OnPropertyChanged(nameof(SelectedReservationIdFromChild));
                }
            }
        }

        // Properties

        public ReservationModel CurrentSelectedReservation
        {
            get => _currentSelectedReservation;
            set
            {
                _currentSelectedReservation = value;
                OnPropertyChanged(nameof(CurrentSelectedReservation));
            }
        }




        public UserAccountModel CurrentUserAccount
        {
            get => _currentUserAccount;
            set
            {
                _currentUserAccount = value;
                OnPropertyChanged(nameof(CurrentUserAccount));
            }
        }

        public ViewModelBase CurrentChildView
        {
            get => _currentChildView;
            set
            {
                _currentChildView = value;
                OnPropertyChanged(nameof(CurrentChildView));
            }
        }
        public string Caption
        {
            get => _caption;
            set
            {
                _caption = value;
                OnPropertyChanged(nameof(Caption));
            }
        }
        public IconChar Icon
        {
            get => _icon;
            set
            {
                _icon = value;
                OnPropertyChanged(nameof(Icon));
            }
        }

        //--> Commands to open a view
        public ICommand ShowHomeViewCommand {get;}
        public ICommand ShowReservationViewCommand { get; }
        public ICommand ShowCustomersViewCommand { get; }
        public ICommand ShowUsersViewCommand { get; }
        public ICommand ShowAllReservationsListViewCommand { get; }
        public ICommand ShowChargeViewCommand { get; }
        public ICommand ShowPaymentViewCommand { get; }
        public ICommand ShowCalendarViewCommand { get; }
        public ICommand ShowReportViewCommand { get; }

        //-->Commands without view
        public ICommand CheckinCommand { get; }
        public ICommand CheckoutCommand { get; }
        public ICommand PrintCommand { get; }

        public MainViewModel()
        {
            userRepository = new UserRepository();
            CurrentUserAccount = new UserAccountModel();

            //Initialize commands
            ShowHomeViewCommand = new ViewModelCommand(ExecuteShowHomeViewCommand);
            ShowReservationViewCommand = new ViewModelCommand(ExecuteShowReservationViewCommand);
            ShowCustomersViewCommand = new ViewModelCommand(ExecuteShowCustomersViewCommand);
            ShowUsersViewCommand = new ViewModelCommand(ExecuteShowUsersViewCommand);
            ShowAllReservationsListViewCommand = new ViewModelCommand(ExecuteShowAllReservationsListViewCommand);
            ShowChargeViewCommand = new ViewModelCommand(ExecuteShowChargeViewCommand);
            ShowPaymentViewCommand = new ViewModelCommand(ExecuteShowPaymentViewCommand);
            ShowCalendarViewCommand = new ViewModelCommand(ExecuteShowCalendarViewCommand);
            ShowReportViewCommand = new ViewModelCommand(ExecuteShowReportViewCommand);

            CheckinCommand = new ViewModelCommand(ExecuteCheckinCommand);
            CheckoutCommand = new ViewModelCommand(ExecuteCheckoutCommand);
            PrintCommand = new ViewModelCommand(ExecutePrintCommand);

            //Default view
            ExecuteShowHomeViewCommand(null);

            LoadCurrentUserData();
        }

       private void ExecuteShowAllReservationsListViewCommand(object obj)
        {
            AllReservationsListViewModel allReservationsListViewModel = new AllReservationsListViewModel();
            CurrentChildView = allReservationsListViewModel;
           
            Caption = "Reservation";
            Icon = IconChar.PhoneVolume;
        }

        


        private void ExecuteShowPaymentViewCommand(object obj)
        {
            Console.WriteLine("currentchildview1:   " + CurrentChildView);           
           
            Console.WriteLine("2: Selected reservation id: " + SelectedReservationIdFromChild);
          
            PaymentViewModel paymentViewModel = new PaymentViewModel(SelectedReservationIdFromChild);

            Console.WriteLine("work fine");
            Window paymentWindow = new PaymentView(SelectedReservationIdFromChild);
            paymentWindow.Show();
        } 


        private void ExecuteShowReportViewCommand(object obj)
        {
            Window reportWindow = new ReportView();
            reportWindow.Show();
        }

        private void ExecuteShowChargeViewCommand(object obj)
        {
            Window chargeWindow = new ChargeView();
            chargeWindow.Show();
        }

        private void ExecuteShowCalendarViewCommand(object obj)
        {
            Window calendarWindow = new CalendarView();
            calendarWindow.Show();
        }

        private void ExecuteShowReservationViewCommand(object obj)
        {
            Window reservationWindow = new ReservationView();
            reservationWindow.Show();
            Caption = "Reservation";
            Icon = IconChar.PhoneVolume;
        }

        private void ExecuteShowUsersViewCommand(object obj)
        {
            CurrentChildView = new UsersViewModel();
            Caption = "Users";
            Icon = IconChar.User;
        }

        private void ExecuteShowCustomersViewCommand(object obj)
        {
            CurrentChildView = new CustomerViewModel();
            Caption = "Customers";
            Icon = IconChar.UserGroup;
        }

        private void ExecuteShowHomeViewCommand(object obj)
        {
            CurrentChildView = new HomeViewModel();
            Caption = "Dashboard";
            Icon = IconChar.Home;
        }

        private void LoadCurrentUserData()
        {
            var user = userRepository.GetByUsername(Thread.CurrentPrincipal.Identity.Name);
            if (user != null)
            {
                CurrentUserAccount.UserName = user.Username;
                CurrentUserAccount.Displayname = $"{user.Username}, {user.Roll}";
                CurrentUserAccount.ProfilePicture = null;
            }
            else
            {
                CurrentUserAccount.Displayname = "Invalid user, not logged in!";
                // Hide child views
            }
        }

        //Commands no view

        private void ExecuteCheckoutCommand(object obj)
        {

        }

        private void ExecuteCheckinCommand(object obj)
        {
            
        }

        private void ExecutePrintCommand(object obj)
        {
            throw new NotImplementedException();
        }
    }
}

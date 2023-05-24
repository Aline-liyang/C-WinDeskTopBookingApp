using Booking_Test.Model;
using Booking_Test.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Booking_Test.ViewModel;
using Booking_Test.View;


namespace Booking_Test.ViewModel
{
    public class AllReservationsListViewModel : ViewModelBase
    {
        private ReservationModel _currentReservation;
        private DateTime _checkinDate;
        private ReservationModel _selectedItem;
       
        private ObservableCollection<ReservationModel> _reservations;

        private IReservationRepository reservationRepository;
       
        //public event EventHandler<Guid> ReservationSelected;

        private Guid _selectedReservationId= Guid.Empty;
        public Guid SelectedReservationId
        {
            get { return _selectedReservationId; }
            set
            {
                _selectedReservationId = value;
                OnPropertyChanged(nameof(SelectedReservationId));
            }
        }

        public ReservationModel CurrentReservation
        {
            get => _currentReservation;
            set
            {
                _currentReservation = value;
                OnPropertyChanged(nameof(CurrentReservation));
            }
        }
        public ObservableCollection<ReservationModel> Reservations
        {
            get => _reservations;
            set
            {
                _reservations = value;
                OnPropertyChanged(nameof(Reservations));
            }
        }


        public ReservationModel SelectedItem
        {
            get { return _selectedItem; }
            set
            {
                if (_selectedItem != value)
                {
                    _selectedItem = value;
                    OnPropertyChanged(nameof(SelectedItem));
                    if (SelectedItem != null)
                    {
                        CurrentReservation = SelectedItem;
                        Console.WriteLine("3:selected reservation id: " + SelectedItem.Id);

                        SelectedReservationId = SelectedItem.Id;
                        Console.WriteLine("33:selected reservation id: " + SelectedReservationId);



                        var mainView = App.Current.Windows.OfType<MainView>().FirstOrDefault();
                        Console.WriteLine("main: " + mainView);

                        // Check if the MainView instance was found
                        if (mainView != null)
                        {
                            // Retrieve the MainViewModel from the MainView's DataContext
                            var mainViewModel = mainView.DataContext as MainViewModel;

                            // Check if the MainViewModel was successfully retrieved
                            if (mainViewModel != null)
                            {
                                // Update the SelectedReservationIdFromChild property
                                mainViewModel.SelectedReservationIdFromChild = SelectedItem.Id;
                            }
                            Console.WriteLine("333:selected reservation id: " + mainViewModel.SelectedReservationIdFromChild);
                        }
                    }
                }
            }
        }

        public DateTime CheckinDate
        {
            get => _checkinDate;
            set
            {
                _checkinDate = value;
                OnPropertyChanged(nameof(CheckinDate));
            }
        }

        //Commands
        public ICommand GetReservationsCommand { get; }
        public ICommand AddReservationCommand { get; }
        public ICommand DeleteReservationCommand { get; }
        public ICommand ModifyReservationCommand { get; }
        public ICommand ClearInputsCommand { get; }

        //Constructor
        public AllReservationsListViewModel()
        {
            reservationRepository = new ReservationRepository();
            CurrentReservation = new ReservationModel();


            GetReservationsCommand = new ViewModelCommand(ExecuteGetReservationsCommand);
            AddReservationCommand = new ViewModelCommand(ExecuteAddReservationCommand);
            ClearInputsCommand = new ViewModelCommand(ExecuteClearInputsCommand);
            ModifyReservationCommand = new ViewModelCommand(ExecuteModifyReservationCommand);
            DeleteReservationCommand = new ViewModelCommand(ExecuteDeleteReservationCommand);

            ExecuteGetReservationsCommand(null);
            Console.WriteLine("00:selected reservation id: " + SelectedReservationId);

        }


        private void ExecuteAddReservationCommand(object obj)
        {
            if (CurrentReservation != null)
            {
                reservationRepository.Add(CurrentReservation);
                ExecuteGetReservationsCommand(null);
            }
        }

        private void ExecuteClearInputsCommand(object obj)
        {
            if (CurrentReservation != null)
            {
                CurrentReservation = new ReservationModel();
            }
        }

        private void ExecuteModifyReservationCommand(object obj)
        {
            if (CurrentReservation != null)
            {
                reservationRepository.Edit(CurrentReservation);
                ExecuteGetReservationsCommand(null);
            }
        }

        private void ExecuteDeleteReservationCommand(object obj)
        {
            if (CurrentReservation != null)
            {
                reservationRepository.Remove(CurrentReservation.Id);
                ExecuteGetReservationsCommand(null);
            }
        }

        private void ExecuteGetReservationsCommand(object obj)
        {
            Reservations = new ObservableCollection<ReservationModel>();
            Reservations = reservationRepository.GetAll();
            //if (SelectedItem != null)
            //{
            //    CurrentReservation = SelectedItem;
            //    ReservationSelected?.Invoke(SelectedItem.Id);
            //}
        }

    }
}

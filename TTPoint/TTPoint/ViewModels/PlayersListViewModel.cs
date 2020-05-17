using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using TTPoint.Views;
using Xamarin.Forms;

namespace TTPoint.ViewModels
{
    public class PlayersListViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public ObservableCollection<PlayerViewModel> Players { get; set; }

        public ICommand CreatePlayerCommand { get; protected set; }
        public ICommand DeletePlayerCommand { get; protected set; }
        public ICommand SavePlayerCommand { get; protected set; }
        public ICommand BackCommand { get; protected set; }
        PlayerViewModel selectedFriend;

        public INavigation Navigation { get; set; }

        public PlayersListViewModel()
        {
            Players = new ObservableCollection<PlayerViewModel>();
            CreatePlayerCommand = new Command(CreatePlayer);
            DeletePlayerCommand = new Command(DeletePlayer);
            SavePlayerCommand = new Command(SavePlayer);
            BackCommand = new Command(Back);
        }

        private void CreatePlayer()
        {
            Navigation.PushAsync(new PlayerPage(new PlayerViewModel() { ListViewModel = this }));
        }

        private void Back()
        {
            Navigation.PopAsync();
        }

        private void SavePlayer(object playerObj)
        {
            PlayerViewModel player = playerObj as PlayerViewModel;
            if (player != null && player.IsValid)
            {
                Players.Add(player);
            }
            Back();
        }

        private void DeletePlayer(object playerObj)
        {
            PlayerViewModel player = playerObj as PlayerViewModel;
            if (player != null)
            {
                Players.Remove(player);
            }
            Back();
        }

        

        public PlayerViewModel SelectedFriend
        {
            get { return selectedFriend; }
            set 
            {
                if (selectedFriend != null)
                {
                    PlayerViewModel playerViewModel = value;
                    selectedFriend = null;
                    OnPropertyChanged("SelectedFriend");
                    Navigation.PushAsync(new PlayerPage(playerViewModel));
                }
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}

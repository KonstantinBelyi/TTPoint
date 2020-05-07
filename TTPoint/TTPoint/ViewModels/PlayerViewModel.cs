
using System.ComponentModel;
using TTPoint.Models.Player;

namespace TTPoint.ViewModels
{
    class PlayerViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        public TtPlayer Player { get; private set; }

        public PlayerViewModel()
        {
            Player = new TtPlayer();
        }

        public string Name
        {
            get { return Player.Name; }
            set
            {
                if (Player.Name != value)
                {
                    Player.Name = value;
                    OnPropertyChanged("Name");
                }
            }
        }        
       
        public bool IsValid
        {
            get
            {
                return !string.IsNullOrEmpty(Name.Trim());
            }
        }

        protected void OnPropertyChanged(string propName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
        }

        public void AddWin()
        {
            Player.WinCount++;
        }

        public void AddLoss()
        {
            Player.LossCount++;
        }

        public bool SavePlayerData()
        {
            // try to save player data to file
            return true;
        }
    }
}

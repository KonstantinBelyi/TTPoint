﻿
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

        public int WinCount
        {
            get { return Player.WinCount; }
            set
            {
                if (Player.WinCount != value)
                {
                    Player.WinCount = value;
                    OnPropertyChanged("WinCount");
                }
            }
        }

        public int LossCount
        {
            get { return Player.LossCount; }
            set
            {
                if (Player.LossCount != value)
                {
                    Player.LossCount = value;
                    OnPropertyChanged("LossCount");
                }
            }
        }

        public bool IsValid
        {
            get
            {
                return !string.IsNullOrEmpty(Name.Trim()) || WinCount >= 0 || LossCount >= 0 ;
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

        public void ReduceWin()
        {
            Player.WinCount--;
        }

        public void AddLoss()
        {
            Player.LossCount++;
        }

        public void ReduceLoss()
        {
            Player.LossCount--;
        }        

        public bool SavePlayerData()
        {
            // try to save player data to file
            return true;
        }
    }
}

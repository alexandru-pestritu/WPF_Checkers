using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Checkers.Models
{
    public class Stats : INotifyPropertyChanged
    {

        public string statPath = "C:\\Users\\pestr\\Source\\Repos\\WPF_Checkers\\Resources\\stats.txt";
        private string redWinsString;
        private string blackWinsString;
        private string buttonStats;

        private bool showStats;
        private int winsRed;
        private int winsBlack;

        public Stats()
        {
            TextReader statFile = File.OpenText(statPath);
            winsBlack = int.Parse(statFile.ReadLine());
            winsRed = int.Parse(statFile.ReadLine());
            redWinsString = winsRed.ToString();
            blackWinsString = winsBlack.ToString();
            buttonStats = "Show Stats";
            statFile.Close();
        }

        public string RedWinsString
        {
            get { return redWinsString; }
            set 
            { 
                redWinsString = value;
                OnPropertyChanged();
            }
        }

        public string BlackWinsString
        {
            get { return blackWinsString; }
            set 
            {
                blackWinsString = value; 
                OnPropertyChanged();
            }
        }

        public int WinsRed
        {
            get { return winsRed; }
            set
            {
                winsRed = value;
                OnPropertyChanged();
            }
        }

        public int WinsBlack
        {
            get { return winsBlack; }
            set
            {
                winsBlack = value;
                OnPropertyChanged();
            }
        }

        public string ButtonStats
        {
            get { return buttonStats; }
            set
            {
                buttonStats = value;
                OnPropertyChanged();
            }
        }

        public bool ShowStats
        {
            get { return showStats; }
            set
            {
                showStats = value;
                OnPropertyChanged();
            }
        }

        ~Stats()
        {
            using (StreamWriter write = new StreamWriter(statPath))
            {
                write.WriteLine(winsBlack);
                write.WriteLine(winsRed);
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

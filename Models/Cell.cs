using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Wpf_Checkers.Models
{
    public class Cell : INotifyPropertyChanged
    {
        private int x;
        private int y;
        private string piece;
        private bool highlight;

        public Cell()
        {

        }

        public Cell(int x, int y, string piece, bool highlight)
        {
            X = x;
            Y = y;
            Piece = piece;
            Highlight = highlight;
        }

        public int X
        {
            get { return x; }
            set
            {
                x = value;
                OnPropertyChanged();
            }
        }

        public int Y
        {
            get { return y; }
            set
            {
                y = value;
                OnPropertyChanged();
            }
        }

        public string Piece
        {
            get { return piece; }
            set
            {
                piece = value;
                OnPropertyChanged();
            }
        }

        public bool Highlight
        {
            get { return highlight; }
            set
            {
                highlight = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_Checkers.Models;
using Wpf_Checkers.MVVM;
using Wpf_Checkers.Utils;

namespace Wpf_Checkers.ViewModels
{
    public class CellViewModel : ViewModelBase
    {
        GameLogic boardLogic;
        private Cell simpleCell;

        private ICommand clickCommand;

        public CellViewModel(Cell cell, GameLogic boardLogic)
        {
            SimpleCell = cell;
            this.boardLogic = boardLogic;
        }

        public Cell SimpleCell
        {
            get { return simpleCell; }
            set
            {
                simpleCell = value;
                OnPropertyChanged();
            }
        }

        public ICommand ClickCommand
        {
            get
            {
                if (clickCommand == null)
                {
                    clickCommand = new RelayCommand<Cell>(boardLogic.ClickAction);
                }
                return clickCommand;
            }
        }
    }
}


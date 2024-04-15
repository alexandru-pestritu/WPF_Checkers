using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Wpf_Checkers.Models;
using Wpf_Checkers.MVVM;
using Wpf_Checkers.Utils;

namespace Wpf_Checkers.ViewModels
{
    public class GameViewModel : ViewModelBase
    {
        private ObservableCollection<ObservableCollection<CellViewModel>> gameBoard;
        private GameInfo gameInfo;
        private Stats stats;

        public GameViewModel()
        {
            ObservableCollection<ObservableCollection<Cell>> board = GameHelper.InitGameBoard();
            GameInfo = new GameInfo(board, false, false, false, false, false, true);
            Stats = new Stats();
            GameBoard = CellBoardToCellViewModelBoard(board);
        }

        public ObservableCollection<ObservableCollection<CellViewModel>> CellBoardToCellViewModelBoard(ObservableCollection<ObservableCollection<Cell>> board)
        {
            ObservableCollection<ObservableCollection<CellViewModel>> result = new ObservableCollection<ObservableCollection<CellViewModel>>();
            for (int i = 0; i < board.Count; i++)
            {
                ObservableCollection<CellViewModel> line = new ObservableCollection<CellViewModel>();
                for (int j = 0; j < board[i].Count; j++)
                {
                    Cell cell = board[i][j];
                    CellViewModel cellViewModel = new CellViewModel(cell, new GameLogic(GameInfo, Stats));
                    line.Add(cellViewModel);
                }
                result.Add(line);
            }
            return result;
        }

        public ObservableCollection<ObservableCollection<CellViewModel>> GameBoard
        {
            get { return gameBoard; }
            set
            {
                gameBoard = value;
                OnPropertyChanged();
            }
        }

        public GameInfo GameInfo
        {
            get { return gameInfo; }
            set
            {
                gameInfo = value;
                OnPropertyChanged();
            }
        }

        public Stats Stats
        {
            get { return stats; }
            set
            {
                stats = value;
                OnPropertyChanged();
            }
        }

    }
}

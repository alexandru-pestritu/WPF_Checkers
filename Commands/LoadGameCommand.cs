using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Xml.Serialization;
using Wpf_Checkers.Models;
using Wpf_Checkers.ViewModels;

namespace Wpf_Checkers.Commands
{
    class LoadGameCommand : ICommand
    {
        private GameViewModel gameVM;
        public LoadGameCommand(GameViewModel gameVM)
        {
            this.gameVM = gameVM;
        }

        public void LoadGame()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            if (openFileDialog.ShowDialog() == true)
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(GameInfo));
                FileStream file = new FileStream(openFileDialog.FileName, FileMode.Open);
                gameVM.GameInfo = xmlser.Deserialize(file) as GameInfo;
                gameVM.GameBoard = gameVM.CellBoardToCellViewModelBoard(gameVM.GameInfo.Board);
                file.Dispose();
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            LoadGame();
        }

        public event EventHandler CanExecuteChanged;
    }
}

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
    class SaveGameCommand : ICommand
    {
        private GameViewModel gameVM;
        public SaveGameCommand(GameViewModel gameVM)
        {
            this.gameVM = gameVM;
        }

        public void SaveGame()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == true)
            {
                XmlSerializer xmlser = new XmlSerializer(typeof(GameInfo));
                FileStream fileStr = new FileStream(saveFileDialog.FileName, FileMode.Create);
                xmlser.Serialize(fileStr, gameVM.GameInfo);
                fileStr.Close();
                fileStr.Dispose();
            }
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            SaveGame();
        }

        public event EventHandler CanExecuteChanged;
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Wpf_Checkers.ViewModels;

namespace Wpf_Checkers.Commands
{
    class ShowStatsCommand : ICommand
    {
        private GameViewModel gameVM;
        public ShowStatsCommand(GameViewModel gameVM)
        {
            this.gameVM = gameVM;
        }

        public void ShowStats()
        {
            gameVM.Stats.ShowStats = !gameVM.Stats.ShowStats;
            if (gameVM.Stats.ShowStats)
                gameVM.Stats.ButtonStats = "Hide Stats";
            else
                gameVM.Stats.ButtonStats = "Show Stats";
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            ShowStats();
        }

        public event EventHandler CanExecuteChanged;
    }
}

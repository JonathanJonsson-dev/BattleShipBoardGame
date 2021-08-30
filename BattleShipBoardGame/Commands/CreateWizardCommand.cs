using BattleShipBoardGame.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BattleShipBoardGame.Commands
{
    public class CreateWizardCommand : ICommand
    {
        private MainViewModel mainViewModel;

        public CreateWizardCommand(MainViewModel mainViewModel)
        {
            this.mainViewModel = mainViewModel;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            mainViewModel.WizardName = "Nytt namn";
            mainViewModel.BloodStatus(); 
            // kod
        }
    }
}

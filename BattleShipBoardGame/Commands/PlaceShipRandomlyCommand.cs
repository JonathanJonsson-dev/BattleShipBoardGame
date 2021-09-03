using BattleShipBoardGame.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace BattleShipBoardGame.Commands
{
    class PlaceShipRandomlyCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        private GameViewModel gameViewModel;

        public PlaceShipRandomlyCommand(GameViewModel gameViewModel)
        {
            this.gameViewModel = gameViewModel;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            gameViewModel.P1.PlaceShipsRandomly();
            gameViewModel.P1.ExposeAllShips();
        }
    }
}

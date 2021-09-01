using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace BattleShipBoardGame.ViewModels
{
    public class PlayerViewModel : BaseViewModel
    {
        public ObservableCollection<Ship> Ships { get; set; }

        private void FillFleet()
        {
            Ships = new ObservableCollection<Ship>()
            {
                new Battleship(),
                new Submarine(),
                new Cruiser()
            };
        }

        public PlayerViewModel()
        {
            FillFleet();
        }
    }
}
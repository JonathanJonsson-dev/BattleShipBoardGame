﻿using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace BattleShipBoardGame.ViewModels
{
    [AddINotifyPropertyChangedInterface] //Attribut

    public class BaseViewModel
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

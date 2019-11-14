using System;
using System.Collections.Generic;
using System.Text;

namespace Laboratorio_8_OOP_201920
{
    public class PlayerEventArgs:EventArgs
    {
        public Cards.Card Card { get; set; }
        public Player Player { get; set; }
    }
}

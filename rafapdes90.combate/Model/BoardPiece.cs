﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace rafapdes90.combate.Model
{
    public class BoardPiece : Button
    {
        public string PowerLevel { get; set; }
        public int MoveLevel { get; set; }
        public bool PowerLevelIsPublic { get; set; }
        public bool IsEnemy { get; set; }

        public BoardPiece(string powerLevel, int moveLevel = 1, bool powerLevelIsPublic = true, bool isEnemy = false)
        {
            this.PowerLevel = powerLevel;
            this.MoveLevel = moveLevel;
            this.PowerLevelIsPublic = powerLevelIsPublic;
            this.IsEnemy = isEnemy;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_RoShamBo
{
    public class RockPlayer : IPlayer
    {
        public int Score { get; set; }
        public string Name { get; }
        public RoShamBo Choice { get; set; }

        public RockPlayer(string name)
        {
            Name = name;
        }

        public RoShamBo GenerateRoShamBo()
        {
            Choice = RoShamBo.Rock;
            return Choice;
        }
    }
}

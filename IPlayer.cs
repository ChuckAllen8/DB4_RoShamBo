using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_RoShamBo
{
    public enum RoShamBo
    {
        Scissors,
        Rock,
        Paper
    }

    public interface IPlayer
    {
        public int Score { get; set; }
        public string Name { get; }
        public RoShamBo Choice { get; set; }
        public RoShamBo GenerateRoShamBo();
    }
}

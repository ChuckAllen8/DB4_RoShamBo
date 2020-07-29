using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_RoShamBo
{
    public class RandomPlayer : IPlayer
    {
        public string Name { get; }
        public int Score { get; set; }
        public RoShamBo Choice { get; set; }

        private Random maker;

        public RandomPlayer(string name)
        {
            Name = name;
            maker = new Random();
        }

        public RoShamBo GenerateRoShamBo()
        {
            Choice = (RoShamBo)maker.Next(Enum.GetValues(typeof(RoShamBo)).Length);
            return Choice;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_RoShamBo
{
    public class HumanPlayer : IPlayer
    {
        private Validator validator;
        public int Score { get; set; }
        public string Name { get; set; }
        public RoShamBo Choice { get; set; }

        public HumanPlayer(string name)
        {
            validator = new Validator();
            Name = name;
        }

        public RoShamBo GenerateRoShamBo()
        {
            Choice = validator.GetRoShamBo();
            return Choice;
        }
    }
}

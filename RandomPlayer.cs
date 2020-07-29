using System;
using System.Collections.Generic;
using System.Text;

namespace DB4_RoShamBo
{
    public class RandomPlayer : IPlayer
    {
        private RoShamBo[] priorChoices;
        private int choiceNum;

        public string Name { get; }
        public int Score { get; set; }
        public RoShamBo Choice { get; set; }

        private Random maker;

        public RandomPlayer(string name)
        {
            choiceNum = 0;
            priorChoices = new RoShamBo[6];
            Name = name;
            maker = new Random();
        }

        public RoShamBo GenerateRoShamBo()
        {
            if(choiceNum >= 6)
            {
                //the prior choices array is filled.
                //make sure the player hasn't picked this choice in the last 6 tries 3 or more times.
                do
                {
                    Choice = (RoShamBo)maker.Next(Enum.GetValues(typeof(RoShamBo)).Length);
                } while (CountOfChoice(Choice) >= 3);
            }
            else
            {
                //first six choices are not using any logic to ensure they are spread out
                Choice = (RoShamBo)maker.Next(Enum.GetValues(typeof(RoShamBo)).Length);
            }
            //overwite the array members to make the array a fixed size, only the prior six matter
            priorChoices[choiceNum % 6] = Choice;
            //iterate the choice number so it fills the next space in the array on the next call
            choiceNum++;
            return Choice;
        }

        private int CountOfChoice(RoShamBo ro)
        {
            //returns the number of times the passed in choice has been
            //used in the list of prior choices
            int count = 0;
            foreach(RoShamBo bo in priorChoices)
            {
                if(ro == bo)
                {
                    count++;
                }
            }
            return count;
        }
    }
}

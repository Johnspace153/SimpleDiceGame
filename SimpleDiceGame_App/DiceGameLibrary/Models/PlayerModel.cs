using DiceGameLibrary.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceGameLibrary.Models
{
    public class PlayerModel
    {
        public GameEnum GameState { get; set; } = GameEnum.None;
        private DiceModel Dice { get; set; }
        public int TotalScore { get; set; }
        public string UserName { get; set; }


        public PlayerModel()
        {
            TotalScore = 0;
            Dice = new DiceModel();
        }

        public List<int> RollMyDice(int numOfDice)
        {
            return Dice.RollDice(numOfDice);
        }

        public int myThrowCount()
        {
            return Dice.ThrowCounter;
        }

        private class DiceModel
        {
            public int NumOfDice { get; set; }
            public int ThrowCounter { get; set; }
            public List<int> RollDice(int numOfDice)
            {
                
                List<int> output = new List<int>();

                for (int i = 0; i < numOfDice; i++)
                {
                    Random rnd = new Random();
                    int roll = rnd.Next(1, 7);
                    output.Add(roll);
                    ThrowCounter++;

                }
                return output;
            }


            public DiceModel()
            {
                ThrowCounter = 0;
                
            }

        }
    }
}

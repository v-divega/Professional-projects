using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiceRollGame
{
    class RandomNumberGenerator
    {
        Random randomNumber = new Random();
        public int RandomNumberValue { 
            get
            { 
                return randomNumber.Next(1, 6);
            }
            private set
            {
            }
        
        }

    }

   
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesNumber
{
    class Player3:Player
    {
        public  void Player03()
        {

            lock (locker)
            {
                
                 
                Random rnd = new Random();
                int r = rnd.Next(1001);
               
                for (int i = 0; i < counteForPlayer1; i++)
                {
                    if (i == counteForPlayer1 - 1)
                    {
                        if (r != Program.number)
                        {
                            Program.meAnswers[counteForPlayer1] = r;
                            
                            
                        }
                    }
                    if (Program.meAnswers[i] != 0 && Program.meAnswers[i] != Program.number)
                    {                                              
                        break;
                    }
                }
                if (r == Program.number)
                {
                    Program.EndOfGame[2] = 1;

                }
                
            }

        }
    }
}

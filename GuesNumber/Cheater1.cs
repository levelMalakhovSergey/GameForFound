using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesNumber
{
    class Cheater1:Player
    {
        public void Cheater01()
        {

            lock (locker)
            {
               
               counteForCheater1++;
                while (true)
                {
                    if (counteForCheater1 == Program.number)
                    {

                        Program.EndOfGame[3] = 1;
                        break;
                    }
                    else
                    {

                        if (Program.stuck[counteForCheater1] != 1)
                        {
                            Program.stuck[counteForCheater1] = 1;
                            break;
                        }
                        else
                        {
                            counteForCheater1++;
                        }
                    }
                }


            }

        }
    }
}

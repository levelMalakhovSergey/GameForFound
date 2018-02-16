using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesNumber
{
    class Cheater2:Player
    {
        public void Cheater02()
        {
            lock (locker)
            {
             

                Random rnd = new Random();
                int r = rnd.Next(1001);
                while (true)
                {
                    if (r == Program.number)
                    {

                        Program.EndOfGame[4] = 1;
                        break;
                    }
                    else
                    {
                        if (Program.stuck[r] != 1)
                        {
                            Program.stuck[r] = 1;
                            break;
                        }
                        else
                        {
                            r = rnd.Next(1001);
                        }
                    }
                }

            }

        }
    }
}

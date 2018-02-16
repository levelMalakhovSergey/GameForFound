using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesNumber
{
    class Player1:Player
    {
        Player player = new Player();
        public void Player01()
        {

            lock (locker)
            {
                Player player = new Player();
                counteForPlayer1++;
                if (counteForPlayer1 == Program.number)
                {

                    Program.EndOfGame[0] = 1;

                }
                else
                {
                    Program.stuck[counteForPlayer1] = 1;
                }
            }
        }
    }
}

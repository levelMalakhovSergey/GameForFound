using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace GuesNumber
{
    class Program
    {
        public static int number = 0;
        public static int[] meAnswers = new int[1000];
        public static int[] EndOfGame = new int[5];
        public static int[] stuck = new int[1000];
        //public static object locker = new object();
        //public static int[] stuck = new int[10000];
        //public static int number = 0;
        //public static int counteForPlayer1 = 0;
        //public static int counteForCheater1 = 0;
        //public static bool end = false;
        //public static int[] meAnswers = new int[1000];
        //public static int[] EndOfGame = new int[5];                                
        public static void TryEnd(int[] EndOfGame)
        {
            for (int i = 0; i < 5; i++)
            {
                if (EndOfGame[i] == 1)
                {
                    Console.WriteLine("Player {0} won", i + 1);
                }
            }
            Console.ReadLine();
        }
        static void Main(string[] args)
        {
            Player player = new Player();
            Player1 player1 = new Player1();
            Player2 player2 = new Player2();
            Player3 player3 = new Player3();
            Cheater1 cheater1 = new Cheater1();
            Cheater2 cheater2 = new Cheater2();

            Console.WriteLine("Write number, please(<10000)");
           number = int.Parse(Console.ReadLine());
            Console.Clear();
            
            //FirstStep del1 = Player1;
            //SecondStep del2 = Player2;
            //ThirdStep del3 = Player3;
            //ForthStep del4 = Cheater1;
            //FivthStep del5 = Cheater2;
            
            while (player.end == false)
            {

                new Thread(player1.Player01).Start();                
                new Thread(player2.Player02).Start();                
                new Thread(player3.Player03).Start();               
                new Thread(cheater1.Cheater01).Start();               
                new Thread(cheater2.Cheater02).Start();
                if (Program.EndOfGame[0] == 1 || EndOfGame[1] == 1 || EndOfGame[2] == 1 || EndOfGame[3] == 1 ||EndOfGame[4] == 1)
                {

                    TryEnd(EndOfGame);
                    Console.ReadLine();
                    player.end = true;
                    return;                   
                }
            }
        }
    }
}

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
        public static int[] stuck = new int[1000];
        public static int number = 0;
        public static int counteForPlayer1 = 0;
        public static int counteForCheater1 = 0;
        public static bool end = false;
        public static int[] meAnswers = new int[1000];
        public static int[] EndOfGame = new int[5];
        delegate void FirstStep(int[] stuck);
        delegate void SecondStep(int[] stuck);
        delegate void ThirdStep(int[] stuck);
        delegate void ForthStep(int[] stuck);
        delegate void FivthStep(int[] stuck);
        public static void Player1()
        {
            counteForPlayer1++;
            if (counteForPlayer1 == number)
            {
                
                EndOfGame[0] = 1;
                
            }
            else
            {
                stuck[counteForPlayer1] = 1;
            }
            
            
        }
        public static void Player2()
        {
            Console.Clear();
            Console.WriteLine("Player2-can rewrite");
            Console.WriteLine("Write your number");
            int answer = int.Parse(Console.ReadLine());
            if (answer == number)
            {              
                EndOfGame[1] = 1;
            }
            else
            {
                stuck[answer] = 1;
                Console.WriteLine("No");
                Console.ReadLine();
            }
            Console.ReadLine();
            
            
        }
        public static void Player3()
        {
            Console.Clear();
            Console.WriteLine("Player3-can't rewrite");
            Console.WriteLine("Write your number");
            int answer = int.Parse(Console.ReadLine());
            for (int i = 0; i < counteForPlayer1; i++)
            {
                if (i == counteForPlayer1 - 1)
                {
                    if (answer != number)
                    {
                        meAnswers[counteForPlayer1] = answer;
                        Console.WriteLine("No");
                        Console.WriteLine("Wright again");
                    }
                }
                if (meAnswers[i] != 0&& meAnswers[i] != number)
                {
                    Console.WriteLine("You alredy used this number");
                    Console.ReadLine();
                    break;
                }
                


            }

            if (answer == number)
            {              
                EndOfGame[2] = 1;
                Console.ReadLine();
            }
            
            
            
        }
        public static void Cheater1()
        {
            
            counteForCheater1++;
            while (true)
            {
                if (counteForCheater1 == number)
                {
                    
                    EndOfGame[3] = 1;
                    break;
                }
                else
                {

                    if (stuck[counteForCheater1] != 1)
                    {
                        stuck[counteForCheater1] = 1;
                        break;
                    }
                    else
                    {
                        counteForCheater1++;
                    }
                }
            }
            

        }
        public static void Cheater2()
        {
            Console.Clear();
            Random rnd = new Random();
            int r = rnd.Next(1001);
            while (true)
            {
                
                
                if (r==number)
                {
                    
                    EndOfGame[4] = 1;
                    break;
                }
                else
                {
                    if (stuck[r] != 1)
                    {
                        stuck[r] = 1;
                        break;
                    }
                    else
                    {
                        r = rnd.Next(1001);
                    }
                }
            }
            

        }

        public static void TryEnd(int[] EndOfGame)
        {
            for (int i = 0; i < 5; i++)
            {
                if (EndOfGame[i]==1)
                {
                    Console.WriteLine("Player {0} won",i+1);
                }
            }
            Console.ReadLine();
        }

            static void Main(string[] args)
        {
            
            Console.WriteLine("Write number, please");
            number = int.Parse(Console.ReadLine());
            Console.Clear();
            
            //FirstStep del1 = Player1;
            //SecondStep del2 = Player2;
            //ThirdStep del3 = Player3;
            //ForthStep del4 = Cheater1;
            //FivthStep del5 = Cheater2;
            while (end == false)
            {

                new Thread(Player1).Start();
              
                new Thread(Player2).Start();
                Console.ReadLine();

                new Thread(Player3).Start();
                Console.ReadLine();
                new Thread(Cheater1).Start();
               
                new Thread(Cheater2).Start();
                



                if (EndOfGame[0]==1|| EndOfGame[1] == 1 ||EndOfGame[2] == 1||EndOfGame[3] == 1||EndOfGame[4] == 1)
                {
                    TryEnd(EndOfGame);
                    Console.ReadLine();
                    break;
                }
            }
        }
    }
}

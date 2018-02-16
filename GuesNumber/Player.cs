using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuesNumber
{
    
    public class Player
    {
        public  object locker = new object();
        
       
        public int counteForPlayer1 { get; set; }
        public int counteForCheater1 { get; set; }
        public bool end = false;
        
        
    }
}

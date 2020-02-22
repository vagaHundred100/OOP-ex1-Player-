using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player1
{
    class TestPlayer
    {
        static public void Main(String[] args)
        {

            Player Vasya = new Player(100, 0, 12);
            Vasya.ShowPlayer();
            Console.ReadKey();
        }
    }
}

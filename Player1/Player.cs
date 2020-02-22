using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Player1
{
    class Player
    {
        public int HP { get; }
        public int Gold { get; }
        public int Damage { get; }


        public Player(int hp,int gold,int damage)
        {
            HP = hp;
            Gold = gold;
            Damage = damage;
        }

        public void ShowPlayer()
        {
            Console.WriteLine("Player has  HP : " + HP);
            Console.WriteLine("Player has  Gold : " + Gold);
            Console.WriteLine("Player has  Damage : " + Damage);
        }
    }
}

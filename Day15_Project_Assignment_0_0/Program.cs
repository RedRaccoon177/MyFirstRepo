using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Project_Assignment_0_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hero hero;
            //Monster monster;

            //hero = new Hero();
            //monster = new Monster("몬스터", 40, 14, 4, 3);

            //hero.AttackMob(monster);
            //monster.AttackHero(hero);

            //hero.DisplayInfo();
            //monster.DisplayInfo();

            Game game = new Game();
            game.Play();
        }
    }
}

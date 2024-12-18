using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Project_Assignment_0_0
{
    internal class Game
    {
        Hero hero = new Hero("Archer", 100, 30, 5);
        Monster monster = new Monster("Skeleton", 50, 20, 5, 1);

        public void Play()
        {
            Console.WriteLine("게임을 시작하였습니다.");
            while (true)
            {
                if (hero.HP > 0 && monster.HP > 0)
                {
                    Console.Clear();
                    Console.WriteLine("다음 행동으로 무엇을 하시겠습니까? (1 혹은 2입력 후 엔터)");
                    Console.WriteLine("1. 영웅이 몬스터를 공격");
                    Console.WriteLine("2. 몬스터가 영웅 공격");
                    bool isCorrect = int.TryParse(Console.ReadLine(), out int input);

                    switch (input)
                    {
                        case 1:
                            hero.AttackMob(monster);
                            break;
                        case 2:
                            monster.AttackHero(hero); 
                            break;
                        default:
                            Console.WriteLine("1,2 만 입력하시오.");
                            break;
                    }
                }
                else if (hero.HP <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("영웅 사망으로 종료");
                    break;
                }
                else if(monster.HP <= 0)
                {
                    Console.Clear();
                    Console.WriteLine("몹 사망으로 종료");
                    break;
                }
            }
        }
    }
}

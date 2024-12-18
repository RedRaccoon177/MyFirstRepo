using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Project_Assignment
{
    class Monster
    {
        //▼ 필드 위치와 관련된 구조체를 하나 들고 있게 합니다.
        public struct Vector2
        {
            int x;
            int y;
        }
        public int damage;
        public int hp;

        public int What
        {
            get
            {
                return hp;
            }
            set
            {
                if (hp < 0 && damage < 0)
                {
                    Console.WriteLine("_hp, damage를 음수로 세팅 할 수 없다.");
                    hp = 0;
                }
            }
        }

        public void AttackCar()
        {
            Car car = new Car();
            car.CarHp = car.CarHp - damage;
            Console.WriteLine($"{damage} 만큼의 데미지를 {car._carName}에 주었습니다.");
        }

        public void HitPlayer(Player player)
        {
            player.HP = player.HP - damage;
            Console.WriteLine(player.HP);
        }
    }
}

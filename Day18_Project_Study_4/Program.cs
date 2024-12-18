using System;


namespace Day18_Project_Study_4
{

    interface IAttackable
    {
        void Attack();
    }

    class Sword : IAttackable
    {
        public void MeleeAttack()
        {
            Console.WriteLine("근접 공격을 수행합니다");
        }

        public void Attack()
        {
            Console.WriteLine("칼 공격");
        }
    }
    class Bow : IAttackable
    {
        public void Snipe()
        {
            Console.WriteLine("저격을 수행합니다");
        }

        public void Attack()
        {
            Console.WriteLine("활 공격");
        }
    }

    class Player
    {
        IAttackable _weapon;

        public void EquipWeapon(IAttackable weapon)
        {
            _weapon = weapon;
            Console.WriteLine("무기 장착 완료");
        }
    
        //다형성, 업캐스팅, 다운캐스팅, 형변환
        public void PerformAttack()
        {
            if (_weapon == null)
            {
                Console.WriteLine("무기가 없다. 주먹으로 싸워");
            }
            else if (_weapon is Bow) // 만약 웨펀이 보우라면
            {
                (_weapon as Bow).Snipe();   //웨펀을 보우형으로 바꾸고, 스나이프 실행

            }
            else if (_weapon is Sword)  //만약 웨폰이 들고 있는 애가 칼이라면
            { 
                (_weapon as Sword).MeleeAttack();
            }
            else
            {
                _weapon.Attack();
            }
        }
    }

    

    class Program
    {
        static void Main(string[] args)
        {
            Player readPlayer = new Player();
            readPlayer.EquipWeapon(new Sword());




        }
    }
}

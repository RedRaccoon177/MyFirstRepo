using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day15_Project_Assignment_0_0
{
    class Hero
    {
        //필드 혹은 프로퍼티 생성
        //이름, 체력, 공격력, 방어력
        string _name;
        int _hp;
        int _attack;
        int _defense;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
        public int Attack 
        {
            get { return _attack; }
            set { _attack = value; }
        }
        public int Defense 
        {
            get { return _defense; }
            set { _defense = value; }
        }

        //생성자 생성
        public Hero(string Name = "Unknown Hero", int HP = 100, int Attack = 20, int Defense = 10) 
        {
            this.Name = Name;
            this.HP = HP;
            this.Attack = Attack;
            this.Defense = Defense;
        }

        //메서드 생성
        public void TakeDamage(int damage)
        {
            damage = damage -_defense;
            _hp = _hp - damage;
        }

        public void AttackMob(Monster monster)
        {
            Console.WriteLine($"{monster.Name}을 공격!");
            monster.TakeDamage( _attack );
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"히어로의 이름: {_name}");
            Console.WriteLine($"{_hp}");
            Console.WriteLine($"{_attack}");
            Console.WriteLine($"{_defense}");
        }
    }
}

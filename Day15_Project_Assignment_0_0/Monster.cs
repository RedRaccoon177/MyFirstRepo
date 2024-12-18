using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Project_Assignment_0_0
{
    class Monster
    {
        //필드 혹은 프로퍼티
        string _name;
        int _hp;
        int _attack;
        int _defense;
        int _level;

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
        public int Level
        {
            get { return _level; }
            set { _level = value; }
        }

        //생성자
        public Monster(string Name = "Basic Monster", int HP = 50, int Attack = 15, int Defense = 5, int LVL = 1)
        {
            this.Name = Name;
            this.HP = HP;
            this.Attack = Attack;
            this.Defense = Defense;
            this.Level = LVL;
        }

        //메서드
        public void TakeDamage(int damage)
        {
            damage = damage - _defense;
            _hp = _hp - damage;
        }

        public void AttackHero(Hero hero)
        {
            Console.WriteLine($"{_name}이 {hero.Name}을 공격합니다.");
            hero.TakeDamage(_attack);
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"몬스터의 이름: {_name}");
            Console.WriteLine($"{_hp}");
            Console.WriteLine($"{_attack}");
            Console.WriteLine($"{_defense}");
            Console.WriteLine($"{_level}");
        }


    }
}

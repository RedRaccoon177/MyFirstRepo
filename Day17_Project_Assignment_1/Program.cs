using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace Day17_Project_Assignment_1
{
    enum MobTybe
    {
        Normal, Fire, Water, Grass, electric
    }

    //심화 과제1
    abstract class Monster
    {
        protected int _level;
        protected MobTybe _type;
        protected string _name;
        abstract public void BaseAttack();

        protected Monster(int level, int tybe, string name)
        {
            this._level = level;
            _type = (MobTybe)tybe;
            _name = name;
        }
    }

    class Trainer
    {
        int _badge;
        string _name;
        string _startingMob;
        Monster[] _monster;
        int _monsterCount = 1;

        //심화 과제 3번
        public Trainer()
        {
            _name = "주인공";
            Pikachu pikachu = new Pikachu();
            _monster = new Monster[6];
            _monster[0] = pikachu;
        }

        //이름과 스타팅 몬스터의 이름을 문자열로 입력받아 객체를 만드는 생성자 하나
        public Trainer(string name, string startingMob)
        {
            _name = name;
            _startingMob = startingMob;
            _monster = new Monster[6];
        }

        public Trainer(Monster monster)
        {
            _monster = new Monster[6];
            _monster[0] = monster;
        }

        //스타팅 몬스터를 바꿀 수 있는 메소드
        public void ChangeMob(string chage)
        {
            _startingMob = chage;
        }

        public void ShowFirstMob()
        {
            Console.WriteLine(_monster[0]);
        }
        
        //심화 과제 4: 이게 맞는지 궁금
        public void AddMonster(Monster monster)
        {
            for (int i = 0; i < _monster.Length; i++)
            {
                if (_monster[i] == null)
                {
                    //몬스터 넣어라
                    _monster[i] = monster;
                    _monsterCount++;
                    return;
                }
                else if (_monsterCount >= 6)
                {
                    Console.WriteLine("몬스터가 6마리 이상 못 넣는다.");
                }
            }
        }

        //심화 과제 5: 이게 맞는지 확인하기(인자 값을 받아버림.)
        public void AllAttack()
        {
            for (int i = 0; i < _monster.Length; i++)
            {
                //▼ ?를 이용하여 null일 경우 실행을 방지하였다.
                _monster[i]?.BaseAttack();
            }
        }
    }

    //심화 과제2번
    class Pikachu : Monster
    {
        public override void BaseAttack()
        {
            Console.WriteLine("전광석화");
        }

        public Pikachu() : base(1,4,"전기공학쥐")
        {

        }
    }
    class Squirtle: Monster
    {
        public override void BaseAttack()
        {
            Console.WriteLine("물총발사");
        }
        public Squirtle() : base(1, 2, "꼬부기?")
        {
        }

    }
    class Bulbasaur: Monster
    {
        public override void BaseAttack()
        {
            Console.WriteLine("덩굴채찍");
        }
        public Bulbasaur() : base(1, 3, "딤섬같은놈")
        {
        }
    }
    class Charmander: Monster
    {
        public override void BaseAttack()
        {
            Console.WriteLine("화염방사");
        }
        public Charmander() : base(1, 1, "용가리")
        {
        }
        public Charmander(int level, int tybe, string mobname) : base(level, tybe, mobname)
        {

        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //심화 과제 6
            Trainer trainer = new Trainer();
            trainer.AddMonster(new Charmander(5 , 1, "파이리"));
            trainer.AllAttack();
        }
    }
}

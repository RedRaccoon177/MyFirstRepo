using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day14_Project_Assignment
{
    struct Position
    {
        public short X;
        public short Y;
    }
    internal class Player
    {
        string _name;
        Position _position;
        Inventory _inventory;
        int _hp;
        int _attack;

        public void MakeInven()
        {
            _inventory = new Inventory();
        }

        public Inventory ShowInven
        {
            get { return _inventory; }
        }

        //위에서 만든 Player 클래스 속의 hp와 데미지를 프로퍼티로 바꾸자.
        public int HP
        {
            get
            {
                return _hp;
            }
            set
            {
                _hp = value;
            }
        }

        public int Attack
        {
            get
            {
                return _attack;
            }
            set
            {
                _attack = value;
            }
        }

        public void HitMonster(Monster monster)
        {
            monster.hp = monster.hp - Attack;
            Console.WriteLine(monster.hp);
        }
    }
}

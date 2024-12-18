using System;

namespace Day17_Project_Assignment_0
{
    //열거형으로 몬스터 타입을 만들었다.
    enum MobTybe
    {
        Normal, Fire, Water, Grass
    }

    //몬스터 클래스를 만들어라.
    class Monster
    {
        int _level;
        MobTybe _type;
        string _name;

        //생성자를 만들어라.
        public Monster()
        {
            _type = MobTybe.Normal;
            _name = "";
            _level = 1;
        }

        //오버로딩 생성자를 만들어라.
        public Monster(MobTybe type,int level ,string name)
        {
            _type = type;
            _level = level;
            _name = name;
        }
    }

    class Trainer
    {
        int _badge;
        string _name;
        string _startingMob;
        Monster[] _monster;

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
    }


    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

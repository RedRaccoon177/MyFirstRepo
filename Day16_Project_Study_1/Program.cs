using System;


namespace Day16_Project_Study_1
{
    class Reward
    {
        int _gold;
        public int Gold
        {
            get { return _gold; }
            set { _gold = value; }
        }
    }

    class Enemy
    {
        public static Reward rwd;   //정적필드 참조형
        public static int _createCount; //정적필드 값타입

        public int _id;
        public int UniqueID      //프로퍼티
        {
            get { return _id; }
            set { _id = value; }
        }

        public Enemy()
        {
            if (rwd == null)
            { 
                rwd = new Reward();
            }

            //_createCount++;
            //UniqueID = _createCount;
            //rwd = new Reward();

        }


        public void IncreaseCreateCount()
        {
            _createCount++;
        }
        public void ShowCreateCount()
        {
            Console.WriteLine(_createCount);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 동적 및 정적 정의
            //// 클래스, 배열 = 동적할당 (동적: 움직이는 바뀌는
            //Random rand = new Random();     //스택과 힙의 위치 인지하기.
            //int[] myInts = new int[10];     //동적 할당

            ////정적: 항시 상주하고, 변하지 않는 공간을 사용하는
            ////지원지지 않는 곳에 위치하는 것
            #endregion

            //Enemy enemy1 = new Enemy();
            //Enemy enemy2 = new Enemy();
            //Enemy enemy3 = new Enemy();
            
            //enemy1.ShowCreateCount();
            //enemy2.ShowCreateCount();
            //enemy3.ShowCreateCount();

            //Console.WriteLine(enemy1._id);
            //Console.WriteLine(Enemy._createCount);
            //static은 힙과 스택이 아닌 static들만의 공간이 따로 있음
            //Data 영역, (힙 영역, 스택 영역, 데이터 영역, 코드 영역)

            Enemy behemoth = new Enemy();
            Enemy.rwd.Gold = 200;
            Console.WriteLine(Enemy.rwd.Gold);

            Enemy behemoth2 = new Enemy();
            Console.WriteLine(Enemy.rwd.Gold);

        }
    }
}

using System;

namespace Day16_Project_Study_2
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
        static Reward rwd;  //정적 필드
        
        // ▼  스태틱 퍼플릭도 괜찮고, 퍼플릭 스태틱도 괜찮다.
        static public Reward Rwd  //정적 프로퍼티
        {
            get 
            {
                if (rwd == null)
                {
                    rwd = new Reward();
                }
                return rwd;
            }
            set
            {
                rwd = value;
            }
        }

        static int _createCount;
        int _health;

        public static int CreateCount
        {
            get { return _createCount; }
            set { _createCount = value; }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Enemy.Rwd.Gold = 100;
            Console.WriteLine(Enemy.Rwd.Gold);
        }
    }
}

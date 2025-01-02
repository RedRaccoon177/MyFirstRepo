using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day30_Project_Study1
{
    //위치 x,y값 기억할 자료형
    struct Vector2 
    {
        public int x;
        public int y;
    }

    class Program
    {   
        static Vector2 playerPos = new Vector2();

        static void Main(string[] args)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            //================================================================

            playerPos.x += 2;
            Console.WriteLine(playerPos.x);

            Start();




            while (true)
            {
                if (watch.ElapsedMilliseconds >= 160)
                {
                    watch.Restart();

                    Update();


                }
            }
        }

        //시작 시, 한번만 호출될 메서드
        private static void Start()
        {
            playerPos.x += 10;
            Console.WriteLine("시작할 때 한번 딸깍");
        }

        //반복적으로 호출 될 메서드

        private static void Update()
        {
            playerPos.x += 3;
            Console.WriteLine("반복적으로" + playerPos.x);
        }
    }
}

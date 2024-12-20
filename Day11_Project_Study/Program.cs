using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day11_Project_Study
{
    internal class Program
    {
        struct Vector2
        {
            public int x;
            public int y;
        }


        static void Main(string[] args)
        {
            #region f12를 누르면 그 함수 정의로 간다.
            #endregion

            #region Random 랜덤에 대하여.
            /*
             *Random rnd = new Random();
             *Console.WriteLine(rnd.Next());  //범위 지정 안하면 음수가 아닌 큰 수가 나온다.
             */

            /*
            Random rnd = new Random();  //while문 밖에 있을 경우
            while (true)
            {
                Console.WriteLine(rnd.Next());  //범위 지정 안하면 음수가 아닌 큰 수가 나온다.
            }
            */

            /*
            Random random = new Random();
            int userInput = int.Parse(Console.ReadLine());
            bool isWon;
            isWon = LottoNumChecker(userInput, random);
            */
            #endregion

            #region 공간 띄우기 할 때
            //Console.WriteLine(" ");
            //Console.WriteLine("　"); //ㄱ 특수문자 1번은 2칸차지
            #endregion

            #region Stopwatch 시간에 대하여
            Stopwatch watch = new Stopwatch();  //이 한줄 적으면 스탑워치가 만들어짐.
            watch.Start();      //스탑워치 시작함
            long reverseCounter = 0;

            Vector2 plateyPos;
            plateyPos.x = 0;
            plateyPos.y = 0;

            bool isFired = false;

            ConsoleKeyInfo temp;        //키입력 기억할 변수
            //temp = Console.ReadKey();   //키입력 넣기
            //if (temp.Key == ConsoleKey.Spacebar)    //스페이스바 눌리면 true 바꾸기
            //{
            //    isFired = true;
            //}

            //5초 이하 다시 시작
            /*while (true)
            { 
                reverseCounter = (6000- watch.ElapsedMilliseconds) / 1000;
                
                if (reverseCounter > 0)
                {
                    Console.WriteLine(reverseCounter);
                }
                else
                {
                    watch.Restart();
                }
            }*/

            //초당 
            while (true) 
            {
                if (watch.ElapsedMilliseconds >= 1000)
                {
                    watch.Restart();

                    temp = Console.ReadKey();   //키입력 넣기
                    if (temp.Key == ConsoleKey.Spacebar)    //스페이스바 눌리면 true 바꾸기
                    {
                        isFired = true;
                    }

                    if (isFired == true)
                    {
                        plateyPos.x += 2;

                        Console.WriteLine(plateyPos.x);
                    }
                }
            }

            /*
            while (true)
            {
                Console.WriteLine(watch.ElapsedMilliseconds);

                if (Console.KeyAvailable)   //키가 눌렀을 때만 참
                {
                    var key = Console.ReadKey(true);
                    if (key.Key == ConsoleKey.Spacebar)
                    {
                        Console.WriteLine("스페이스 선택 시 게임 진행되면서 입력 한번 됨.");
                    }
                }
            }*/
            watch.Stop();

            #endregion
        }
        #region 랜덤에 관하여
        /*
        //유저 인풋과, 랜덤으로 뽑힌 수가 맞는지 체크하는 함수. 범위는 0~30(미만)
        static bool LottoNumChecker(int Num, Random temp)
        {
            int lottoNum = temp.Next(0, 30);
            return lottoNum == Num;
        }
        */
        #endregion
    }
}

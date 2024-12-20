using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Day10_Project_GameDevleop.Program;

namespace Day10_Project_GameDevleop
{
    internal class Program
    {
        public struct Coin              //코인 구조체
        {
            public string Name;             //코인의 이름
            public float changePrice;       //변동되는 값
            public float afterPrice;        //후의 코인 가격
            public float beforePrice;       //전의 코인 가격    
            public float trunChangPrice;    //소수점 컷 수들
        }

        static void Main(string[] args)
        {
            #region 게임 시작 화면
            while (true)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("|                                                              |");
                Console.WriteLine("|                        *************                         |");
                Console.WriteLine("|                    ****             ****                     |");
                Console.WriteLine("|                  ***      ██████       ***                   |");
                Console.WriteLine("|                ***        ██    ██       ***                 |");
                Console.WriteLine("|              ***          ██     ██        ***               |");
                Console.WriteLine("|              ***          ████████         ***               |");
                Console.WriteLine("|              ***          ██     ██        ***               |");
                Console.WriteLine("|                ***        ██    ██       ***                 |");
                Console.WriteLine("|                  ***      ██████       ***                   |");
                Console.WriteLine("|                    ****             ****                     |");
                Console.WriteLine("|                        *************                         |");
                Console.WriteLine("|                                                              |");
                Console.WriteLine("----------------------------------------------------------------");
                Console.WriteLine("1번을 눌러 게임을 시작하시오.");
                Console.WriteLine("1. 게임 시작");

                bool isStirng = false;
                int pressStart = 0;
                isStirng = int.TryParse(Console.ReadLine(), out pressStart);
                if (pressStart == 1 && isStirng == true)
                {
                    Console.Clear();
                    break;
                }
            }
            #endregion
            Random randomD = new Random();
            

            float myMoney = 0f;                                         //나의 현재 보유 금액
            float myCoinMoney = 0f;                                     //나의 코인 보유 금액

            Coin[] coin = new Coin[6];                    // Coin 구조체 선언

            coin[0].Name = "비트코인";                     // 코인 이름 예시 3개
            coin[1].Name = "이더리움";
            coin[2].Name = "리플코인";
            coin[3].Name = "경일코인";
            coin[4].Name = "도지코인";
            coin[5].Name = "불장코인";

            coin[0].afterPrice = 10000;
            coin[1].afterPrice = 10000;
            coin[2].afterPrice = 10000;
            coin[3].afterPrice = 10000;
            coin[4].afterPrice = 10000;
            coin[5].afterPrice = 10000;

            //for (int i = 0; i < coin.Length; i++)
            //{
            //    coin[i].changePrice = 100;
            //    PlusChangeCoin(ref coin);                       
            //    coin[i].trunChangPrice = (coin[i].changePrice * 10) / 10;                // 소수점 둘째 자리까지만 남기는 작업
            //    coin[i].afterPrice = coin[i].beforePrice + coin[i].trunChangPrice;       // 코인 afterPrice만 있게 하기
            //}

            //for (int i = 0; i < coin.Length; i++)
            //{
            //    Console.WriteLine($"현재 {coin[i].Name}의 가격은: {coin[i].afterPrice}");
            //}   


            #region Console.WriteLine 인게임 화면 출력창
            //Console.Clear();
            //Console.WriteLine($"현재 보유 금액:$ {myMoney}");
            //Console.WriteLine($"코인 보유 금액:$ {myCoinMoney}");
            //Console.WriteLine("----------------------------------------------------------------");
            //Console.WriteLine("|                                                              |");
            //Console.WriteLine("|                                                              |");
            //Console.WriteLine("|                                                              |");
            //Console.WriteLine("|                                                              |");
            //Console.WriteLine("|                                                              |");
            //Console.WriteLine("|                                                              |");
            //Console.WriteLine("|                                                              |");
            //Console.WriteLine("|                                                              |");
            //Console.WriteLine("|                                                              |");
            //Console.WriteLine("|                                                              |");
            //Console.WriteLine("----------------------------------------------------------------");

            //Console.WriteLine("@@@1~4번의 선택지를 선택하시오.@@@");

            //Console.WriteLine("1. 주식 매수");
            //Console.WriteLine("2. 주식 매도");
            //Console.WriteLine("3. 돈 벌기!!");
            //Console.WriteLine("4. 뉴스 보기");
            #endregion

            #region 게임 시작 시 차트 출력 처음 값
            for (int i = 0; i < coin.Length; i++)
            {
                Console.WriteLine($"현재 {coin[i].Name}의 가격은: {coin[i].afterPrice}");
            }
            Console.WriteLine();
            Console.WriteLine($"0일이 지났습니다...");
            #endregion

            #region 게임이 계속 진행 되도록 하는 while문!
            Stopwatch stopwatch = new Stopwatch();              //시간을 선언
            stopwatch.Start();                                  //시간이 흐르기 시작한다. 멈추고 싶으면 Stop해주면 됨
            int lastExecutionTime = 0;                          // 마지막 실행 시간을 저장할 변수
            int theTime = 0;
            while (true)
            {
                //stopwatch.ElapsedMilliseconds 실제 시간 흐르는 것 1000 = 1초
                int second = (int)stopwatch.ElapsedMilliseconds / 1000;     //1초의 흐름 시간 선언

                if (second - lastExecutionTime >= 3)     // 3초가 흐를 때 마다
                {
                    Console.Clear();
                    for (int i = 0; i < coin.Length; i++)
                    {
                        coin[i].changePrice = 100;
                        PlusChangeCoin(ref coin);
                        coin[i].trunChangPrice = (coin[i].changePrice * 10) / 10;                // 소수점 둘째 자리까지만 남기는 작업

                        bool isCorrect = MinusOrPlus(randomD);

                        if (isCorrect == true)
                        {
                            coin[i].afterPrice = coin[i].afterPrice + coin[i].trunChangPrice;       // 코인 afterPrice만 있게 하기
                        }
                        else if (isCorrect == false)
                        {
                            coin[i].afterPrice = coin[i].afterPrice - coin[i].trunChangPrice;       // 코인 afterPrice만 있게 하기
                        }
                    }

                    for (int i = 0; i < coin.Length; i++)
                    {
                        Console.WriteLine($"현재 {coin[i].Name}의 가격은: {coin[i].afterPrice}");
                    }

                    theTime = +second;
                    Console.WriteLine();
                    Console.WriteLine($"{theTime / 3}일이 지났습니다...");

                    //▼ 마지막 실행 시간을 현재 시간으로 갱신
                    lastExecutionTime = second;
                }
            }
            #endregion
        }

        static Coin[] PlusChangeCoin(ref Coin[] coins)       // 입력된 코인의 값을 바꿔줌
        {
            int coinChangePercent;                                           // 코인 퍼센트의 확률 0 ~ 100%
            float[] coinPercentResult = new float[6];                        // 코인의 퍼센트 값 ex) $ 7.2
            float[] coinChangePrice = new float[6];                          // 얼마나 변할 건지 퍼센트 값 ex) 7.2 %

            Random[] coinPriceRandom = new Random[6];                 // 코인의 가격이 랜덤으로 상승하는 Random 생성
            for (int i = 0; i < coinPriceRandom.Length; i++)
            {
                coinPriceRandom[i] = new Random();
            }

            #region 차트 변동 값
            //  0~5% 변동 => 50%    
            // 5~10% 변동 => 25%   
            //10~20% 변동 => 10%  
            //20~30% 변동 => 5%
            //30~40% 변동 => 4%
            //40~99% 변동 => 1%
            #endregion
            
            int coinLenth = 6;                                    //코인 종목 횟수
            for (int i = 0; i < coinLenth; i++)
            {
                Random coinPercent = new Random();
                coinChangePercent = coinPercent.Next(0, 100);

                coinChangePrice[0] = coinPriceRandom[0].Next(0, 50);
                coinChangePrice[1] = coinPriceRandom[1].Next(51, 100);
                coinChangePrice[2] = coinPriceRandom[2].Next(101, 200);
                coinChangePrice[3] = coinPriceRandom[3].Next(201, 300);
                coinChangePrice[4] = coinPriceRandom[4].Next(301, 400);
                coinChangePrice[5] = coinPriceRandom[5].Next(401, 999);

                coinPercentResult[i] = coins[i].changePrice;

            if (coinChangePercent <= 50)  //50 확률로 
                {
                    coinChangePrice[0] = coinChangePrice[0] * 0.1f;         //변할 확률% ex) 0~5%
                    
                    coinPercentResult[i] = coinPercentResult[i] * coinChangePrice[0] * 0.01f;
                }
                else if (50 < coinChangePercent && coinChangePercent <= 75)
                {
                    coinChangePrice[1] = coinChangePrice[1] * 0.1f;           //변할 확률% ex) 5~10%

                    coinPercentResult[i] = coinPercentResult[i] * coinChangePrice[1] * 0.01f;
                }
                else if (75 < coinChangePercent && coinChangePercent <= 90)
                {
                    coinChangePrice[2] = coinChangePrice[2] * 0.1f;          //변할 확률% ex) 10~20%

                    coinPercentResult[i] = coinPercentResult[i] * coinChangePrice[2] * 0.01f;
                }
                else if (90 <= coinChangePercent && coinChangePercent < 95)
                {
                    coinChangePrice[3] = coinChangePrice[3] * 0.1f;            //변할 확률% ex) 20~30%

                    coinPercentResult[i] = coinPercentResult[i] * coinChangePrice[3] * 0.01f;
                }
                else if (95 < coinChangePercent && coinChangePercent <= 99)
                {
                    coinChangePrice[4] = coinChangePrice[4] * 0.1f;             //변할 확률% ex) 30~40%

                    coinPercentResult[i] = coinPercentResult[i] * coinChangePrice[4] * 0.01f;
                }
                else if (coinChangePercent == 100)
                {
                    coinChangePrice[5] = coinChangePrice[5] * 0.1f;            //변할 확률% ex) 40~99%

                    coinPercentResult[i] = coinPercentResult[i] * coinChangePrice[5] * 0.01f;
                }
                else
                {
                    //상장 폐지 만들까?
                }
            }
            coins[0].changePrice = coinPercentResult[0];
            coins[1].changePrice = coinPercentResult[1];
            coins[2].changePrice = coinPercentResult[2];
            coins[3].changePrice = coinPercentResult[3];
            coins[4].changePrice = coinPercentResult[4];
            coins[5].changePrice = coinPercentResult[5];
            return coins;
        }

        #region 55:45 확률 만들기
        static bool MinusOrPlus(Random randomD)
        {
            bool input = true;

            int temp0 = randomD.Next(0, 100);

            if (temp0 < 55)
            {
                input = true;
            }
            else if (temp0 >= 45)
            {
                input= false;
            }
            return input;
        }
        #endregion
    }
}

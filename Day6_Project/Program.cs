using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region switch문 간단한 활용 및 if문하고 비슷하게 활용 가능
            //ConsoleKeyInfo inputKey;        //inputKey안에 내가 컴퓨터 키를 삽입 가능
            //inputKey = Console.ReadKey(true);

            //if (inputKey.Key == ConsoleKey.A)
            //{
            //    Console.WriteLine("왼쪽으로 이동합니다.");
            //}
            //else if(inputKey.Key == ConsoleKey.D)
            //{
            //    Console.WriteLine("우측으로 이동합니다.");
            //}

            //switch(inputKey.Key)
            //{
            //    case ConsoleKey.D:
            //        Console.WriteLine("우측으로 이동합니다.");
            //        break;
            //    case ConsoleKey.A:
            //        Console.WriteLine("좌측으로 이동합니다.");
            //        break;
            //}
            #endregion

            #region ★ 좌우로 이동시키기
            //ConsoleKeyInfo myInput;
            //int posX = 0;   //x좌표 기억할 변수
            //int posY = 0;   //y좌표  기억할 변수

            //Console.WriteLine("★");                 
            //while (true)
            //{
            //    myInput = Console.ReadKey(true);
            //    if (myInput.Key == ConsoleKey.A)
            //    {
            //        posX -= 2;
            //        if(posX < 0)
            //        {
            //            posX = 0;
            //        }
            //    }
            //    else if (myInput.Key == ConsoleKey.D)
            //    {
            //        posX += 2;

            //    }
            //    else if (myInput.Key == ConsoleKey.W)
            //    {
            //        posY -= 2;
            //        if (posY < 0)
            //        {
            //            posY = 0;
            //        }
            //    }
            //    else if (myInput.Key == ConsoleKey.S)
            //    {
            //        posY += 2;
            //    }
            //    else if(myInput.Key == ConsoleKey.Z)
            //    {
            //        break;
            //    }
            //    Console.Clear();
            //    Console.SetCursorPosition(posX, posY);
            //    Console.Write("★");
            //}
            #endregion

            #region F11을 눌러서 디버깅 확인하는 법 (논리 오류 찾기)
            //int increasingNum = 1;      
            //int endPoint = 100000;      //int.MaxValue 사용 시 컴퓨터의 논리 오류 발생

            //while (true)
            //{
            //    increasingNum *= 2;
            //    Console.WriteLine(increasingNum);

            //    if(increasingNum > endPoint)    
            //    {
            //        //왼쪽 바에 중단점을 클릭 후 F5만 누르면 중단점 디버깅 활용 가능
            //        Console.WriteLine("이거만 보고 싶음");
            //        Console.WriteLine($"{endPoint} 초과로 종료");
            //        break;
            //    }
            //}
            #endregion

            #region 컴퓨터 상의 계산 F5를 눌러서 디버깅 확인
            //float temp = 2.1f;
            //float temp2 = 6.2f;

            //float result = temp * temp2;    // 출력값 13.02 하지만 컴퓨터 상으로는?

            //Console.WriteLine(result);

            //if (result == 13.02f)           // 출력값 13.01999986이다. 그러므로 작동 하지 않는다.
            //{
            //    Console.WriteLine("정답을 맞췄냐?");
            //}
            #endregion

            #region Random 활용
            //int a;                  //정수만
            //char b;                 
            //float c;                
            //ConsoleKey d;           

            //Random randomNum;       
            //randomNum = new Random();
            //// ▲ new를 쓰면 뭔가가 옆에 담겼다 라고만 일단 생각

            //int computerNum;

            //Console.WriteLine("시작 수를 입력해주세요.");
            //int startNum = int.Parse(Console.ReadLine());
            //Console.WriteLine("끝 수를 입력해주세요.");
            //int endNum = int.Parse(Console.ReadLine());

            ////while (true)
            ////{
            //    // ▼ 시작 숫자는 앞에꺼, 끝 범위는 두번째꺼 -1
            //    computerNum = randomNum.Next(startNum, endNum);
            //    Console.WriteLine(computerNum);
            ////}
            #endregion

            #region 과제1. 야구게임

            int ball = 0;                        //볼
            int strike = 0;                      //스트라이크
            int gameCount = 0;                   //게임 수
            bool gameCountB = true;

            int computerNum0;   //컴퓨터값 일의 자리
            int computerNum10;   //컴퓨터값 십의 자리
            int computerNum100;   //컴퓨터값 백의 자리

            int startNum = 0;   //컴퓨터가 시작할 랜덤 수  0
            int endNum = 9;     //컴퓨터가 끝날 램덤수     9

            Random randomNum = new Random();
            computerNum0 = randomNum.Next(startNum, endNum);
            computerNum10 = randomNum.Next(startNum, endNum);
            computerNum100 = randomNum.Next(startNum, endNum);

            while (true)            //컴퓨터의 랜덤 값이 중복되는 값이 있을 경우를 방지
            {
                if (computerNum0 == computerNum10 || computerNum0 == computerNum100 || computerNum10 == computerNum100)
                {
                    computerNum0 = randomNum.Next(startNum, endNum);
                    computerNum10 = randomNum.Next(startNum, endNum);
                    computerNum100 = randomNum.Next(startNum, endNum);
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine($"{computerNum100},{computerNum10},{computerNum0}");

            while (gameCountB == true)
            {
                Console.WriteLine("야구게임입니다. 중복되지 않는 3자리 수를 입력하시오.");

                int myNum;                       //나의 입력값 3자리수
                bool isCorrect;                  //입력값 진실

                isCorrect = int.TryParse(Console.ReadLine(), out myNum); // 값을 입력

                int outputA0 = myNum % 10;              //1의 자리수
                int outputA10 = (myNum / 10) % 10;       //10의 자리수 (100~999)
                int outputA100 = myNum / 100;             //100의 자리수

                if (isCorrect == false) 
                {
                    Console.WriteLine("문자열을 입력하였습니다. 다시 입력하시오.");
                }
                else if (outputA0 == outputA10 || outputA10 == outputA100 || outputA0 == outputA100)
                {
                    Console.WriteLine("중복 숫자를 입력하였습니다. 다시 입력하시오.");
                }
                else if (myNum < 999 && myNum > 000 && isCorrect == true)
                {
                    if (outputA0 == computerNum0)           //1의 자리 스트라이크
                    {
                        strike++;
                    }
                    if (outputA10 == computerNum10)        //10의 자리 스트라이크
                    {
                        strike++;
                    }
                    if (outputA100 == computerNum100)      //100의 자리 스트라이크
                    {
                        strike++;
                    }
                    Console.WriteLine($"스트라이크의 값은: {strike}");

                    if (outputA0 == computerNum10)
                    {
                        ball++;
                    }
                    if (outputA0 == computerNum100)
                    {
                        ball++;
                    }
                    if (outputA10 == computerNum0)
                    {
                        ball++;
                    }
                    if (outputA10 == computerNum100)
                    {
                        ball++;
                    }
                    if (outputA100 == computerNum0)
                    {
                        ball++;
                    }
                    if (outputA100 == computerNum10)
                    {
                        ball++;
                    }
                    Console.WriteLine($"볼의 값은: {ball}");

                    if (strike == 0 && ball == 0)              // 0 스트라이크, 0볼 시 아웃 출력
                    {
                        Console.WriteLine("아웃");
                    }
                    else if (strike == 3)
                    {
                        Console.WriteLine("게임 승리");
                        break;
                    }

                    strike = 0;
                    ball = 0;
                    gameCount++;

                    if (gameCount == 12)                 //게임 횟수 제한
                    {
                        gameCountB = false;
                        Console.WriteLine("시합이 종료 되었습니다!!");
                    }
                }
                else  //범위 값 밖
                {
                    Console.WriteLine("범위 밖의 값 입력하셨습니다. 다시 입력하시오.");
                }
            } 
            
            #endregion
        }
    }
}

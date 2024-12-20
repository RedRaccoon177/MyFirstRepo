using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day7_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 어제 배웠던 Random
            //Random myRandom;
            //myRandom = new Random();

            //int myNumber;
            //myNumber = myRandom.Next(0, 4); //0 이상 4미만
            #endregion

            #region  배열

            //string skill1 = "결정타";
            //string skill2 = "용기";
            //string skill3 = "심판";
            //string skill4 = "데마시아";

            //string[] skills;            // 문자열 여러개를 담을 공간이 필요해
            //skills = new string[4];     // 문자열 4개를 담을 공간을 만들어줘.
            //// ▲위의 줄이 지나면 컴퓨터 어딘가에 string이 4개 만들 공간이 만들어 져 있음.


            //int[] tenInts = new int[10];

            //skills[0] = "결정타";
            //skills[1] = "용기";
            //skills[2] = "심판";
            //skills[3] = "데마시아";

            //int number = int.Parse(Console.ReadLine());

            //Console.WriteLine($"배열의 {number} 번 속 내용은 {skills[number]} 입니다.");

            //for (int i = 0; i < skills.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}번째 요소는 {skills[i]} 입니다.");
            //}

            //foreach (string element in skills)
            //{
            //    Console.WriteLine("이건 포이치로 나온 반복문 " + element);
            //}

            //Console.WriteLine("사용할 스킬");

            //switch (int.Parse(Console.ReadLine()))
            //{
            //    case 1:
            //        Console.WriteLine($"{skill1} 사용");
            //        break;      
            //    case 2:
            //        Console.WriteLine($"{skill2} 사용");
            //        break;    
            //    case 3:
            //        Console.WriteLine($"{skill3} 사용");
            //        break;   
            //    case 4:
            //        Console.WriteLine($"{skill4} 사용");
            //        break;
            //}
            #endregion

            //string[] shortCuts;         //이거 n개를 담을 수 있는 바구니
            //shortCuts = new string[4];  //new를 통해 진짜 공간 만듦

            //shortCuts[0] = "회복약";
            //shortCuts[1] = "부적";
            //shortCuts[2] = "만능물약";
            //shortCuts[3] = "수류탄";


            //for (int i = 0; i < shortCuts.Length ; i++)
            //{
            //    shortCuts[i] = $"{i}번째 요소 기입중";
            //    //Console.WriteLine(shortCuts[i]);
            //}

            //foreach(string ele in shortCuts)
            //{
            //    Console.WriteLine(ele);
            //}


            #region 다차원 배열

            //2차원 배열 만드는 법

            //이건 1차원
            //string[] shortCuts = new string[4];

            //2차원 배열
            //string[,] shortCuts = new string[3, 4];

            //shortCuts[0, 0] = "고급회복약";
            //shortCuts[0, 1] = "부적";
            //shortCuts[0, 2] = "물약";
            //shortCuts[0, 3] = "수류탄";

            //shortCuts[1, 0] = "고급";
            //shortCuts[1, 1] = "진군";
            //shortCuts[1, 2] = "아드로핀";
            //shortCuts[1, 3] = "파폭";

            //shortCuts[2, 0] = "정가";
            //shortCuts[2, 1] = "성부";
            //shortCuts[2, 2] = "시정";
            //shortCuts[2, 3] = "암수";

            //string[,] shortCuts = new string[3, 4]
            //{
            //     { "고급회복약", "성스러운부적", "만능물약", "회오리수류탄" },
            //     { "고급회복약", "진군의깃발", "아드로핀물약", "파괴폭탄" },
            //     { "정령의가호", "성스러운부적", "시간정지물약", "암흑수류탄" }
            //};


            //foreach (string s in shortCuts) 
            //{
            //    Console.WriteLine(s);
            //}

            //for (int i = 0; i < shortCuts.GetLength(0); i++)
            //{
            //    for (int j = 0; j < shortCuts.GetLength(1); j++)
            //    {
            //        Console.Write(shortCuts[i, j] + "\t");
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine(shortCuts.Length); //

            //var myVar = "2.126";

            //foreach (var element in shortCuts)
            //{
            //    Console.WriteLine(element);
            //}


            //string name = "Ingrid";

            //name[0] = 'a';    // string형은 개인배열 찾기가 안됨.

            //foreach (char character in name) 
            //{
            //    Console.Write(character + " ");
            //}

            //string name = "Ingrid";     //스트링은 char 형의 배열이다.

            //char[] charArr = name.ToCharArray();

            //foreach (var ele in charArr)
            //{
            //    Console.Write(ele + " ");
            //}

            //charArr[2] = 'a';

            //string changedStr;
            //changedStr = new string(charArr);

            //Console.WriteLine(changedStr);


            //값 타입 참조타입
            //struct 구조는 값타입들이라고 생각해도 됨. ex)int, float
            //class 구조는 참조타입이라고 생각해도 됨. ex)string

            #endregion

            // null에 대해서도 학습함


            #region 과제0

            //int[] input = new int[4];       //4개의 정수를 담을 수 있는 배열
            //                                //사용자에게 순서대로 값 입력 받기

            //for (int i = 0; i < input.Length; i++)
            //{
            //    Console.WriteLine($"{i + 1}번 요소를 입력하여주십시오.");
            //    input[i] = int.Parse(Console.ReadLine());
            //}

            //foreach(int i in input) 
            //{
            //    Console.WriteLine($"입력된 요소는 다음과 같습니다.\n {i}");
            //}
            //#endregion

            #endregion

            #region 과제1

            //int[] skillCooldowns = new int[] { 5, 3, 10, 7 };

            //while (true)
            //{
            //    Console.WriteLine("Q를 입력하여 한 턴을 지나가게 하시오.");
            //    string keyDowns = Console.ReadLine();
            //    if (keyDowns == "q" || keyDowns == "Q")
            //    {
            //        for (int i = 0; i < skillCooldowns.Length; i++)
            //        {
            //            skillCooldowns[i] -= 1;

            //            if (skillCooldowns[i] == -1)
            //            {
            //                skillCooldowns[i] = 0;
            //            }
            //        }
            //        foreach (int k in skillCooldowns)
            //        {
            //            Console.WriteLine($"{k}초 남음");
            //        }

            //        for (int i = 0; i < skillCooldowns.Length; i++)
            //        {
            //            if (skillCooldowns[i] == 0)
            //            {
            //                Console.WriteLine($"스킬 {i + 1} 사용 가능!");
            //            }
            //        }
            //    }
            //    else
            //    {
            //        Console.Clear();
            //        Console.WriteLine("Q가 아닙니다. 다시 입력하시오.");
            //    }
            //}

            #endregion

            #region 과제2
            //int [,] inputA = new int[4,4];
            //int plus = 0;
            //int temp = 0;

            //for (int i = 0; i < inputA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < inputA.GetLength(1); j++)
            //    {
            //        plus++;
            //        inputA[i, j] = 3 * plus;
            //    }
            //}

            //temp = inputA[2, 1];
            //inputA[2, 1] = inputA[1, 2];
            //inputA[1, 2] =temp;

            //for (int i = 0; i < inputA.GetLength(0); i++)
            //{
            //    for (int j = 0; j < inputA.GetLength(1); j++)
            //    {
            //        Console.Write($"({inputA[i, j]})");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 심화 과제1


            #endregion

            #region 심화 과제2

            string[] skills = { "Q", "W", "E", "R" };
            int[] skillCT = { 5, 3, 10, 7 };
            bool isCorrect = false;
            int action;

            while (true)
            {
                Console.WriteLine("사용 가능한 스킬은 다음과 같습니다");
                for (int i = 0; i < skills.Length; i++)
                {
                    Console.WriteLine($"{skills[i]} : {skillCT[i]}");
                }
                Console.WriteLine("--------------------\n액션을 선택해주세요\n--------------------");
                Console.WriteLine("1. 턴넘김");
                Console.WriteLine("2. 스킬 사용");

                isCorrect = int.TryParse(Console.ReadLine(), out action);

                if (action == 1)                                // 1번 선택 : 턴넘김
                {
                    for (int i = 0; i < skillCT.Length; i++)
                    {
                        skillCT[i] -= 1;

                        if (skillCT[i] == -1)
                        {
                            skillCT[i] = 0;
                        }
                    }
                    foreach (int k in skillCT)
                    {
                        Console.WriteLine($"{k}초 남음");
                    }

                    for (int i = 0; i < skillCT.Length; i++)
                    {
                        if (skillCT[i] == 0)
                        {
                            Console.WriteLine($"스킬 {i + 1} 사용 가능!");
                        }
                    }
                }
                else if (action == 2)
                {
                    Console.WriteLine("Q,W,E,R 중 무슨 스킬을 사용 할 것인가?");
                    if (skills[0])
                    {

                    }else if ()
                    {

                    }
                }
                else if (action == 0 && isCorrect == true)
                {
                    Console.WriteLine("스킬창이 종료됩니다.");
                    break;     
                }
                else
                {
                    Console.WriteLine("선택지 안에 값을 입력하시오.");
                }
            }

            #endregion
        }
    }
}
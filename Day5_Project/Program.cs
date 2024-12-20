using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Day5_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 어제 수업 복습
            //bool isCorrect = true;     //참거짓 저장 변수
            //int intBox = 11;
            //string myString = "17865";
            //isCorrect = int.TryParse(myString, out intBox); //TryParse
            #endregion

            #region 면접 문제로 예전에 나왔던 문제이다.
            //int x = 1;
            //x = x++;
            //Console.WriteLine(x);
            #endregion

            #region 어제 과제 선생님 설명
            //과제1 => 딱히

            //과제2 => 코드 줄을 더욱 단축할 수 있는 것들이 있었다.

            //과제3 => 변수를 늘려서라도 가독성을 좀 확실하게 해라.

            //과제4 => ???
            #endregion

            #region 오늘 수업 시작
            //bool isCorrect = true; //참거짓 저장 변수

            //if (false) //false만 들어가있으면 작동 안됨. 이건 처음알았네.
            //{
            //    Console.WriteLine("거짓");
            //}
            //else if(isCorrect)
            //{
            //    Console.WriteLine("진실");
            //    isCorrect = false;
            //    if (isCorrect)
            //    {
            //        Console.WriteLine("거짓");
            //    }
            //}
            #endregion

            #region if문 체력을 이용한 학습
            //int playerHp = 100;        //선언과 동시에 초기화 
            //int damageTaken = 0;       //일단은 0으로 초기화
            //bool isPlayerDead = true; //일단 생존했음

            //Console.WriteLine($"플레이어 현재 체력은 {playerHp}입니다.");
            //Console.Write("받은 데미지: ");

            ////▼문자열 입력 받아서 바로 숫자로 전환
            //damageTaken = int.Parse(Console.ReadLine());

            //playerHp = playerHp - damageTaken;
            //isPlayerDead = playerHp <= 0;

            ////ctrl + R을 두번 누르면 동시에 한번에 다 바뀐다.
            //if (isPlayerDead)
            //{
            //    Console.WriteLine($"플레이어가 사망하셨습니다.");
            //}

            //if(playerHp <0)
            //{
            //    playerHp = 0;
            //}
            //Console.WriteLine($"플레이어 현재 체력은 {playerHp}입니다.");
            #endregion

            #region else if, else문
            //Console.Write("체력을 기입하세요: ");
            //int playerHp = int.Parse(Console.ReadLine());

            //if (playerHp > 70)
            //{
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.WriteLine("건강합니다");
            //    Console.ReadLine();
            //}
            //else if (playerHp > 40)
            //{
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("중간 체력입니다.");
            //    Console.ResetColor();
            //}
            //else if (playerHp > 0)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("죽어갑니다.");
            //    Console.ResetColor();
            //}
            //else //if도 else if도 아니라면
            //{
            //    playerHp = 0;
            //    Console.ForegroundColor= ConsoleColor.DarkGray;
            //    Console.WriteLine("죽었습니다.");
            //    Console.ResetColor();
            //}
            #endregion

            #region TryParse를 이용한 else문 사용
            //int myNum = 0;          //일단 초기화
            //bool isParsed = false;  //일단 초기화

            //Console.WriteLine("판단할 수 입력");
            //isParsed = int.TryParse(Console.ReadLine(), out myNum);

            //if (isParsed)
            //{
            //    Console.WriteLine("정상 입력 되었습니다.");
            //    Console.WriteLine($"입력된 숫자는 {myNum}입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("정수가 아닌 것을 입력하였습니다.");
            //}


            #endregion

            #region 선생님의 깜짝 실습
            //int input;
            //string myString;

            //myString = Console.ReadLine();
            //input = int.Parse(myString);

            //if (input % 2 == 0)  //2의 배수라면 
            //{
            //    Console.WriteLine("2의 배수입니다.");
            //}
            //else if (input % 3 == 0) //3의 배수라면
            //{
            //    Console.WriteLine("3의 배수입니다.");
            //}
            //else // 그외라면
            //{
            //    Console.WriteLine("2의 배수도 3의 배수도 아닙니다.");
            //}

            //int myNum = 0;
            //Console.WriteLine("판단할 수를 입력");
            //int.TryParse(Console.ReadLine(), out myNum);

            //if (myNum == 0)
            //{
            //    Console.WriteLine("0을 입력 하였다.");
            //}
            //else if ((myNum % 2) == 0)
            //{
            //    Console.WriteLine("2의 배수 입니다.");
            //}
            //else if ((myNum % 3 ) == 0)
            //{
            //    Console.WriteLine("3의 배수입니다.");
            //}
            //else
            //{
            //    Console.WriteLine("이도 저도 아닙니다.");
            //}
            #endregion

            #region if문 안의 if문
            //Console.WriteLine("판단할 수를 입력");
            //int myNum = 0;

            //int.TryParse(Console.ReadLine(), out myNum);

            ////▼일단 2의 배수인지 판다
            //if ((myNum % 2) == 0)
            //{
            //    if ((myNum % 3) == 0)
            //    {
            //        Console.WriteLine("2의 배수이면서 3의 배수입니다.");
            //    }
            //}
            #endregion

            #region || 와 &&
            //bool A = true;
            //bool B = false;
            ////여기서 A와 B는 참 혹은 거짓이라고 가정

            ////A와 B가 둘 다 참일때만 참: &&
            ////A나 B 둘 중 하나만 참이어도 참이길 원한다면: || 

            //if (A && B) //A와 B가 둘 다 참일때만 실행
            //{
            //    Console.WriteLine("보이거나");
            //}

            //Console.WriteLine("판단할 수를 입력");
            //int myNum = 0;
            //int.TryParse(Console.ReadLine(), out myNum);

            //if ((myNum % 2 == 0) || (myNum % 3 == 0))
            //{
            //    Console.WriteLine("2 혹은 3의 배수입니다.");
            //}

            //if ((myNum % 2 == 0) && (myNum % 3 == 0))
            //{
            //    Console.WriteLine("2의 배수이면서 3의 배수입니다.");
            //}
            #endregion

            #region switch문
            //Console.WriteLine("이동할 장소를 선택");
            //Console.WriteLine("1.마을");
            //Console.WriteLine("2.사냥터");
            //Console.WriteLine("3.상점");

            //int myInput = int.Parse(Console.ReadLine());    //그냥 숫자를 적었다고 가정

            //Console.Clear();    //화면을 지웁니다.

            //switch (myInput)
            //{
            //    case 1:
            //        Console.WriteLine("마을로 이동");
            //        break;
            //    case 2:
            //        Console.WriteLine("사냥터로 이동");
            //        break;
            //    case 3:
            //        Console.WriteLine("상점으로 이동");
            //        break;
            //    default:
            //        Console.WriteLine("1,2,3 어느것도 아닙니다.");
            //        break;
            //}
            #endregion

            #region for문(반복문)
            //for (초기식; 조건식; 증감식)
            //{
            //    반복할 내용;
            //}

            //int i는 for문 안에서 만들어진 변수이므로 밖에서는 사용 불가
            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine(i);
            //}
            #endregion

            #region for문 속의 if문
            //for(int i =0; i < 10; i++)
            //{
            //    if(i % 2 == 0)   //2의 배수(2의 나머지가 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //    else
            //    {
            //        Console.WriteLine("홀수 넘김");
            //    }
            //}

            #endregion

            #region 반복문 속의 반복문 (중첩반복문)
            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 9; j > 0; j--)   //2의 배수(2의 나머지가 0)
            //    {
            //        Console.WriteLine($"i는 현재 {i}, j는 현재{j} \t {i * j}");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region while문 안에 if문
            //int count = 0;
            //while (true)
            //{
            //    Console.WriteLine(count);
            //    count++;

            //    if (count > 100)
            //    {
            //        Console.WriteLine("100보다 커졌습니다");
            //        continue;           // 뒤의 내용을 무시하고 다시 올라감
            //    }
            //    Console.WriteLine("이거봐라");
            //}
            #endregion

            #region if문안에 while문과 TryParse
            //int myInput = 0;    //생성과 동시에 초기화
            //bool isCorrectInput = false;    //올바른 입력인지 참거짓

            //Console.WriteLine("숫자를 입력해주시기 바랍니다");

            //isCorrectInput = int.TryParse(Console.ReadLine(), out myInput);

            //if (isCorrectInput == false)
            //{
            //    while (isCorrectInput == false) 
            //    {
            //        Console.WriteLine("제대로 입력해주세요");
            //        isCorrectInput = int.TryParse(Console.ReadLine(), out myInput);   
            //    }
            //}
            #endregion


            #region 과제1. 입력받은 횟수만큼 반복하는 기능 제작

            //int input;

            //Console.WriteLine("몇회 반복하시겠습니까?");

            //input = int.Parse(Console.ReadLine());

            //for (int i = 0; i < input; i++)
            //{
            //    Console.WriteLine($"{input}회 반복중입니다.");
            //}
            #endregion

            #region 과제2. 다수의 입력을 받아 횟수만큼 반복하는 기능 제작
            //int inputA;
            //int inputB;

            //Console.WriteLine("두 수 사이의 합을 구합니다. 시작할 작은 수를 입력하세요.");
            //inputA = int.Parse(Console.ReadLine());
            //Console.WriteLine("끝 수를 입력해주세요.");
            //inputB = int.Parse(Console.ReadLine());

            //int sum = 0;

            //for (; inputA <= inputB; inputA++)
            //{
            //    sum = inputA + sum;
            //    if (inputA == inputB)
            //    {
            //        Console.WriteLine($"{inputA}과 {inputB} 사이 숫자의 합은 {sum}입니다.");
            //    }
            //}
            #endregion

            #region 과제3. 구구단 기능 제작

            //Console.WriteLine("출력하고자 하는 구구단을 입력해주시길 바랍니다");

            //int inputA;
            //int inputB;

            //while (true)
            //{
            //    bool isCorrect = int.TryParse(Console.ReadLine(), out inputA);

            //    if (inputA <= 9 && inputA > 0)      // 입력한 변수값이 1~9 사이의 정수일 경우
            //    {
            //        for (int i = 1; i < 10; i++)
            //        {
            //            inputB = inputA * i;
            //            Console.WriteLine($"{inputA} X {i} = {inputB}");
            //        }
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("1~9가 아닌 입력값입니다. 다시 입력하시오.");
            //    }
            //}

            #endregion

            #region 과제4. 별찍기 기능 구현

            //// 1번 별찍기
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = -1; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// 2번 별찍기
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int k = 5; k > i; k--)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = -1; j < i; j++)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// 3번 별찍기
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 5; j > i; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}

            //// 4번 별찍기
            //for (int i = 0; i < 5; i++)
            //{
            //    for (int k = 0; k < i - 1; k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j = 0; j > i + 5; j--)
            //    {
            //        Console.Write("*");
            //    }
            //    Console.WriteLine();
            //}
            #endregion

            #region 심화 과제1. 조건에 따른 무한 반복 기능

            //Console.WriteLine("이동할 장소를 선택");
            //Console.WriteLine("1.마을");
            //Console.WriteLine("2.사냥터");
            //Console.WriteLine("3.상점");

            //int inputA;
            //bool isCorrect;

            //while (true)
            //{
            //    isCorrect = int.TryParse(Console.ReadLine(), out inputA);

            //    if (inputA == 1 || inputA == 2 || inputA == 3)
            //    {
            //        switch (inputA)
            //        {
            //            case 1:
            //                Console.WriteLine("마을로 이동");
            //                break;
            //            case 2:
            //                Console.WriteLine("사냥터로 이동");
            //                break;
            //            case 3:
            //                Console.WriteLine("상점으로 이동");
            //                break;
            //        }
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("1,2,3을 제외한 입력입니다. 재입력하시오.");
            //    }
            //}

            #endregion

            #region 심화 과제2. 입력을 통한 다이아몬드 출력 기능 구현
            int inputA;
            int inputHalfA;
            bool isCorrect;

            Console.WriteLine("출력할 다이아몬드를 홀수로 입력하세요.");

            while (true)
            {
                isCorrect = int.TryParse(Console.ReadLine(), out inputA);
                inputHalfA = inputA / 2;            //입력값의 절반

                if (inputA == 1)                // 입력값이 1일 경우
                {
                    Console.WriteLine("1이 아닌값을 입력하시오");
                }
                else if ((inputA % 2) == 1)     // 입력값이 홀수 일 경우(2로 나눴을 때 나머지1)
                {
                    #region
                    for (int i = 0; i <= inputHalfA; i++)
                    {
                        for (int j = 0; j < inputHalfA - i; j++)
                        {
                            Console.Write(" ");
                        }
                        for (int l = 0; l < 2 * i + 1; l++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                    #endregion
                    for (int k = 0; k < inputHalfA; k++)        // 3번
                    {
                        for (int w = -1; w < k; w++)
                        {
                            Console.Write(" ");
                        }
                        for (int u = 0; u > 2 * (k - inputHalfA) + 1; u--)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.WriteLine("홀수를 입력하시오");
                }
            }
            #endregion
        }
    }






}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Project_Study
{
    internal class Program
    {
        /*enum BurgerKingMenu
        {
            불고기와퍼, 몬스터와퍼, 치즈와퍼, 치킨버거, 통새우와퍼
        }

        enum McdonardMenu
        {
            치즈버거, 빅맥, 상하이버거, 맥크리스피, 치킨버거
        }*/

        enum SelectMap
        {
            디폴트, 마을 = 1, 사냥터, 상점, 센터, 광장
        }

        static void Main(string[] args)
        {
            #region 전날 배웠던 함수 복습
            //▼ 반환 받을게 없다면 void 쓰면 된다.
            //[반환 자료형] [함수 이름] [매개변수]
            //{
            // 
            //}

            //응용 1
            //과제 2번
            // 선생님이 풀었던 방법 추후 다시 보기
            // 배열에서 가장 큰 수 찾아서 반환하는 함수 제작
            //int[] inputArr = new int[4] { 1, 2, 4, 3 };
            //FindMax(inputArr[]);

            //응용 2
            //CheckNumber(0);

            //응용 3 버블정렬
            //int[] arr = { 5, 8, 7, 4, 21, 16, 5, 14, 9, 4 };
            //BubbleSort(arr);
            #endregion

            #region 열거형(enum) 나열하다
            // 변수 선언
            /*BurgerKingMenu SongpaBK;    //열거형에는 enum에 선언 한것만 사용 가능
            SongpaBK = BurgerKingMenu.통새우와퍼;

            McdonardMenu SongpaMc;
            SongpaMc = McdonardMenu.빅맥;*/

            /*▼ 형변환 ()안에 변환 시킬 것을 입력
            int myNum = (int)2.5;

            //숫자도 열거형식으로 바꿀 수 있음
            selectedMap = (SelectMap)9;

            Console.WriteLine(selectedMap);
            Console.WriteLine((int)selectedMap);
            */

            //Enum.IsDefined
            Console.WriteLine(Enum.IsDefined(typeof(SelectMap), 3));
            

            /*Console.WriteLine("이동 할 장소를 설정해주세요");
            Console.WriteLine("1. 마을");
            Console.WriteLine("2. 사냥터");
            Console.WriteLine("3. 상점");
            SelectMap selectedMap = SelectMap.디폴트;

            Enum.TryParse(Console.ReadLine(), out selectedMap);
            Console.Clear();
            switch (selectedMap)
            {
                case SelectMap.마을:
                    Console.WriteLine("마을로 이동합니다");
                    break;
                case SelectMap.사냥터:
                    Console.WriteLine("사냥터로 이동합니다");
                    break;
                case SelectMap.상점:
                    Console.WriteLine("상점으로 이동합니다");
                    break;
                default:
                    Console.WriteLine("1,2,3 어느것도 아니에요");
                    break;
            }*/
            #endregion

            //응용 1
            /*int FindMax(int[] arr)
            {
                int max = arr[0];   //최대를 기억할 변수 하나 제작, 0번 인덱스 값 저장

                foreach (int num in arr)    //배열 요소 하나씩 집어 넣을 거임
                {
                    if (num > max)
                    {
                        max = num;
                    }
                }
                return max;
            }*/

            //응용2
            //인자값이 양수면 양수 반환, 음수면 음수 반환, 아니면 "0" 출력 반환 값은 string형
            /*static string CheckNumber(int num)
            {
                if (num > 0)
                {
                    return "양수";    //하위 중가로 안에 있을 경우 실행이 안될 수도 있어서 return인식 불가
                }
                if (num < 0) 
                {
                    return "음수";
                }
                return "0";
            }*/

            //응용3 반환은 딱히 없고, 배열이 주어지면 이를 정렬하는 기능
            /*static void BubbleSort(int[] arr)
            {
                int n = arr.Length; //배열의 길이

                Console.WriteLine("아래꺼 실행 전");
                PrintArray(arr);

                for (int i = 0; i < n - 1; i++)
                {
                    for (int j = 0; j < n - 1; j++)
                    {
                        if (arr[j] > arr[j + 1])
                        {
                            int temp = arr[j];
                            arr[j] = arr[j + 1];
                            arr[j + 1] = temp;
                        }
                    }
                }

                Console.WriteLine("아래꺼 실행 후");
                PrintArray(arr);
            }
            //출력만 하는 함수 새로 만들었다.
            static void PrintArray(int[] toPrint)
            {
                foreach (var elements in toPrint)
                {
                    Console.Write(elements + " ");
                }
            }*/

            /* 응용4
            ChangeColorPrintAndReset("붉은색", ConsoleColor.Red);
            ChangeColorPrintAndReset("푸른색", ConsoleColor.Blue);
            Console.WriteLine("그 사이 3초 그 짧은 시간");*/
        }

        /*응용 4. 인자값으로 출력하고자 하는 문자열과, 색을 주면 그걸로 바꿔서 출력하는 기능
        static void ChangeColorPrintAndReset(string inputString, ConsoleColor inputColor)
        {
            Console.BackgroundColor = inputColor;       //뒷배경 컬러
            Console.ForegroundColor = inputColor;       //글자색
            Console.WriteLine(inputString);
            Console.ResetColor();
        } */

        
    }
}

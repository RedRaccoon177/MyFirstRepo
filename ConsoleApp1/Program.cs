using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 입력된 숫자를 누적 저장할 변수
            string temp = "";

             int son= GetNumericInput(temp);

            Console.WriteLine($"숫자 인트: {son}");

        }

        // 숫자 입력 처리 함수
        public static int GetNumericInput(string temp)
        {
            while (true)
            {
                // 키 입력 받기
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                //0~9의 값을 받을 경우 tenp
                if (keyInfo.Key == ConsoleKey.D0) { temp += +0; }
                else if (keyInfo.Key == ConsoleKey.D1) { temp += +1; }
                else if (keyInfo.Key == ConsoleKey.D2) { temp += +2; }
                else if (keyInfo.Key == ConsoleKey.D3) { temp += +3; }
                else if (keyInfo.Key == ConsoleKey.D4) { temp += +4; }
                else if (keyInfo.Key == ConsoleKey.D5) { temp += +5; }
                else if (keyInfo.Key == ConsoleKey.D6) { temp += +6; }
                else if (keyInfo.Key == ConsoleKey.D7) { temp += +7; }
                else if (keyInfo.Key == ConsoleKey.D8) { temp += +8; }
                else if (keyInfo.Key == ConsoleKey.D9) { temp += +9; }
                else if (keyInfo.Key == ConsoleKey.Enter) { break; }
                else if (keyInfo.Key == ConsoleKey.Backspace)
                {
                    if (temp.Length > 0)
                    {
                        temp = temp.Substring(0, temp.Length - 1); // 마지막 문자 제거
                        Console.Write("\b \b"); // 콘솔에서 문자 삭제
                    }
                }

                // 숫자 키인지 확인
                if (char.IsDigit(keyInfo.KeyChar))
                {
                    Console.Write(keyInfo.KeyChar); // 화면에 표시
                }
            }

            if (int.TryParse(temp, out int result))
            {
                return result; // 변환된 정수 반환
            }
            else
            {
                Console.WriteLine("\n유효한 숫자가 입력되지 않았습니다. 0으로 반환합니다.");
                return 0; // 유효하지 않으면 0 반환
            }
        }
    }
}

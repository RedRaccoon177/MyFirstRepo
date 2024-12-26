using System;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            int sd = 0;
            GetInput(ref sd);

            Console.WriteLine(sd);
        }

        public static void GetInput(ref int getNum0)
        {
            //문자열 일경우 제외
            //숫자인데 0일경우 제외
            bool isNum = false;
            int getNum1 = 0;

            while (isNum == false && getNum1 == 0)
            {
                isNum = int.TryParse(Console.ReadLine(), out getNum0);
                getNum1 = getNum0;
            }

            getNum0 = getNum1;

        }
    }
}

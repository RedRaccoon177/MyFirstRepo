using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_Project_Study_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Queue <> 큐: 줄
            //First in First out, FIFO, 선입선출

            Queue<char> keyInputs = new Queue<char>();

            while (true)
            {
                var keyInput00 = Console.ReadKey();

                if (keyInput00.KeyChar == '0')
                {
                    break;
                }
                keyInputs.Enqueue(keyInput00.KeyChar);  //Queue는 줄을 세우다 에서 Enqueue 사용
            }

            while (keyInputs.Any())
            {
                Console.WriteLine(keyInputs.Dequeue()); //맨 위에꺼 하나 볼때
            }
        }
    }
}

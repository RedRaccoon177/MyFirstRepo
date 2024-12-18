using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_Project_Study_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Stack
            // First in Last Out, Last in First Out
            // FILO, LIFO
            // 선입후출, 후입선출

            // 스택이 유용하게 쓰일법한 상황
            // 웹브라우저에서 뒤로가기 (몬스터길들이기)
            // UI창에서 새로운 창이 뜰 때
            // 체스같은 게임에서 턴무르기

            Stack<char> keyInputs = new Stack<char>();

            while (true)
            {
                var keyInput00 = Console.ReadKey();
                keyInputs.Push(keyInput00.KeyChar); //stack은 밀어넣다의 Push로 집어넣음

                //집어넣기 위한 푸쉬
                //가자 위 요소를 반환하는 동시에 터뜨려 없애는 Pop
                //요소를 보기만 하고 없애진 않는 Peek

                if (keyInput00.KeyChar == '0')
                {
                    break;
                }
                keyInputs.Push(keyInput00.KeyChar);
            }

            //Pop
            //for (int i = 0; i < keyInputs.Count; i++)
            //{
            //    char poped = keyInputs.Pop();
            //    Console.Write(poped);
            //}


            //Any()
            //하나라도 남았으면 참
            while (keyInputs.Any())
            {
                Console.WriteLine(keyInputs.Peek());
            }

        }
    }
}

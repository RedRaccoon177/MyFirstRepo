using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;


namespace Day20_Project_Study_0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List
            ////어제 복습 자료구조
            ////List
            ////어디에 쓰면 좋을까? => 배열의 수가 일정하지 않을 때
            ////
            ////장점: 순서가 중요하거나, 크기가 가변적인 데이터를 관리할 때 유리
            ////인덱스로 원하는 자료를 한번에 가져올 때 좋음. (반복문 중 i 라던지)

            ////단점: 중간에 삭제가 일어나면 뒤에있는 자료들을 끌고 와야해서 연산에 부하를 줄 수 있다
            ////중간 삽입삭제에는 좀 부족하다.

            //List<string> inven = new List<string>(); //뉴 할당은 리스트를 위한 뉴할당

            ////추가를 위해 .add
            //inven.Add("마나포션");
            //inven.Add("하오골");
            //inven.Add("데어파");

            //Console.WriteLine("인벤 속 요소들 출력할때");

            //foreach (var item in inven)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(inven[0]);
            #endregion

            #region Dictionary : 사전
            ////Dictionary : 사전
            ////키와 값이 쌍으로 기억됨, Key값, 벨류값
            ////어떤 키워드로 검색하면 뾱 가져와줄 때 유리

            //Dictionary<string, int> monsters = new Dictionary<string, int>();
            //var asd = new Dictionary<string, int>();  //길면 이렇게 줄일 수도 있다.

            //monsters.Add("고블린", 50);
            //monsters.Add("드래곤", 600);
            //monsters.Add("슬라임", 10);

            //monsters["고블린"] = 100;

            //foreach (var mons in monsters)
            //{
            //    Console.WriteLine($"{mons.Key}: 체력은 {mons.Value}");
            //    Console.WriteLine(mons);
            //}
            #endregion

            #region Stack
            ////Stack
            ////어디에?? 카드덱
            ////연사스킬
            ////무르기, 되돌리기, UI

            //Stack<string > gameStack = new Stack<string>();  //자료구조 

            ////Push
            //gameStack.Push("시작턴");
            //gameStack.Push("1번째 턴");
            //gameStack.Push("2번째 턴");

            ////Peek는 보기만 함, Pop은 터트리면서 확인함.
            ////▼ 시작턴 부터 들어가서 가장 위에 있는 건 2번째 턴 이라서 그게보이는 거임
            //Console.WriteLine(gameStack.Pop());

            //Console.WriteLine("한턴을 무릅니다.");

            //Console.WriteLine(gameStack.Peek());
            #endregion

            #region Queue
            //Queue
            //어떤 상황?
            //배럭에서 마린, 메딕 등을 생산할 때 순차적으로 생산 되도록 하는 것

            Queue<string> barrackQueue = new Queue<string>();

            //대기열 등록시키고 싶을 때
            barrackQueue.Enqueue("마린");
            barrackQueue.Enqueue("마린");
            barrackQueue.Enqueue("마린");
            barrackQueue.Enqueue("메딕");

            while (barrackQueue.Count > 0)
            {
                string spawnUnit = barrackQueue.Dequeue();
                Console.WriteLine(spawnUnit);
            }
            #endregion

            #region 어제 질문 중 하나
            //List<int> numbers = new List<int> {1, 2, 3, 4, 5};
            ////List<int> temp = new List<int>(numbers); //numbers 복사본으로 temp 만들어냄

            //foreach (var num in new List<int>(numbers)) //임시로 numbers 복사본 만들어서 포이치 돌림
            //{
            //    Console.WriteLine($"숫자 : {num}");

            //    if (num == 3)
            //    {
            //        numbers.Remove(num); //수정은 원본에서
            //    }
            //}
            #endregion
        }
    }
}

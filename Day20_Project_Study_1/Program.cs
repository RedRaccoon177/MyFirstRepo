using System;
using System.Collections.Generic;


namespace Day20_Project_Study_1
{
    class Node<T>
    {
        public T Value { get; set; }
        public Node<T> Next { get; set; }
        public Node(T value) 
        { 
            Value = value;
            Next = null;
        }
    }

    //노드를 추가하거나 삭제하는 걸 도와주는 관리 클래스
    //마치 아이템 클래스가 있고, 이를 관리하는 Inventory 클래스가 있는 것과 같음
    //시작과 끝이 있어야 함. 시작은 Head, 끝은 Tail, Count 노드 갯수
    class LinkedList2<T>
    {
        public Node<T> Head { get; private set; } //시작점 노드 하나 기억시킬 헤드
        public int Count { get; private set; }  //노드 갯수 보관할 Count

        public LinkedList2()
        {
            Head = null;
            Count = 0;
        }

        //지정된 값을 가진 노드 제거
        //삭제 성공 실패 여부를 bool로 반환
        public bool Remove(T value)
        {
            if (Head == null)  //하나도 없으면 그냥 false반환
            { 
                return false;
            }

            if (Head.Value.Equals(value))
            {
                Head = Head.Next;   //머리가 가리키고 있던 다음 대상이 이제 머리임.
                Count--;    //원래 카운트 1이었다면 이걸 0으로

                return true; //삭제 성공
            }

            Node<T> current = Head;

            //넥스트가 비지 않았다면 계속 다음 노드 이동,
            //넥스트의 값이 내가 찾는 값과 같다 하면 반복 멈춤
            while (current.Next != null && !current.Next.Value.Equals(value))
            {
                current = current.Next;
            }

            if (current.Next == null)
            { 
                return false ;  //while문 다 돌아도 값이 없으면 false
            }

            current.Next = current.Next.Next; //그냥 연결 끊어주고 다음꺼로 주소 연결
            Count--;
            
            return true;
        }

        public Node<T> Find(T value)
        {
            Node<T> current = Head;

            while (current != null)
            {
                if (current.Value.Equals(value))
                {
                    return current;
                }
                current = current.Next;
            }

            return null;
        }

        public void AddLast(T value)
        {
            Node<T> newNode = new Node<T>(value);

            if (Head == null) //최초 실행 시, Head가 null임
            {
                Head = newNode; //처음 추가한 노드는 머리가 됨
            }
            else
            { 
                Node<T> current = Head; //일단 '현재' 노드에 머리 담음

                while (current.Next != null) //현재 노드 다음 노드가 비지 않았다면?
                { 
                    current = current.Next; //현재 노드는 다음 노드
                }

                current.Next = newNode; //nul 자리 대신에 신규 노드 이제 담음
            }
            Count++;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region LinkedList 설명
            //LinkedList 링크/ 연결리스트

            //List
            //길이가 자유롭다
            //데이터가 연속적으로 보관되어 있기에 인덱스로 접근이 가능하고
            //필요할 경우 앞에서부터 빠르게 뒤까지 검색 가능

            //단점:
            //중간 삽입삭제가 느림

            //LinkedList
            //데이터와 데이터가 연속으로 연결되어 있지 않고, 데이터는 각 다음 혹은
            //이전 데이터가 어디있는지 주소를 들고 있는 방식
            //중간 삽입 삭제가 빠름
            //특정 요소를 검색할 때 느림
            //애니팡처럼 중간에 겁나 삭제 되는 그런 것들에 유리
            //NPC 이동 경로와 같이 수시로 담을 내용이 바뀔 수 있는 그런거
            #endregion

            Node<int> myNode0 = new Node<int>(12);
            Node<int> myNode1 = new Node<int>(1);

            myNode0.Next = myNode1;

            LinkedList<int> linkedListExp = new LinkedList<int>();
            
            LinkedList2<int> list = new LinkedList2<int>();
            list.AddLast(123);
            list.AddLast(456);
            list.AddLast(789);
            list.AddLast(423);

            //모든 노드 출력 방법
            Node<int> current = list.Head;

            while (current != null) 
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

            Console.WriteLine("-------------------------");

            list.Remove(456);

            current = list.Head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

            Console.WriteLine("------------------");

            var foundNode = list.Find(123);
            Console.WriteLine(foundNode.Value);
        }
    }
}

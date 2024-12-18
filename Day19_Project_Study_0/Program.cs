using System;

namespace Day19_Project_Study_0
{
    class Program
    {
        struct Item
        {
            //▼ 자동구형 프로퍼티(필드 자동 생성)
            public string Name { get; set; }
            public string Description { get; set; }
        }

        class Inventory
        {
            Item[] items; //아이템 텅 빈 배열

            //[접근지정자] [반환형태] this [int i]
            //{
            //      get { return 반환할것;}
            //      set {세팅할값 = value;}
            //}
            public Item this[int i]     //외부에서 인자로 인덱스를 넘겨줄 것
            {
                get { return items[i]; } //그거 활용해서 반환해줄 내용 적어주기
                set { items[i] = value; } //외부에서 세팅해준 값을 i번째에 어떻게 활용 잘 하기
            }

            public Inventory(int invenSize) //배열 크기 지정
            {
                items = new Item[invenSize]; //그 크기대로 생성
            }

            //인덱스를 인자값으로 주면, 배열 속 해당 아이템 반환해주는 메서드
            public Item GetItemByIndex(int index)
            {
                return items[index];
            }

            //프로퍼티로 인벤 그 자체를 외부에 돌려주는 기능
            public Item[] Inven
            {
                get { return items; }
            }
        }


        static void Main(string[] args)
        {
            //자료구조 배열
            //크기가 늘었다 줄었다 하는 상황 대처능력이 떨어짐
            //배열에서 특정 내용물를 검색하는 기능도 없음
            //자료를 효율적으로, 그리고 관리하고 싶은 방법에 따라 다르게
            //활용 하는 것을 보고 자료구조를 활용한다 이렇게 표현함
            //영어로 컬렉션


            //인덱서
            //▼ 시작과 동시에 10개 아이템 배열 생성
            Inventory myInven = new Inventory(10);
            //▼ 인덱스 2번째 가져오는 메서드 사용
            Console.WriteLine(myInven.GetItemByIndex(2).Name);
            //▼ 프로퍼티로 인벤 받아서 사용
            Console.WriteLine(myInven.Inven[2].Name);
            //위의 방법들이 가독성이 떨어진다고 판단함.
            //이럴 때 인덱서를 사용함.
            //▼ 클래스 속에 자료구조가 있다면 유용한 인덱서
            Console.WriteLine(myInven[2].Name);

        }
    }
}

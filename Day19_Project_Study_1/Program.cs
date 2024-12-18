using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_Project_Study_1
{
    class Program
    {
        class Enemy
        {
            public string Name { get; set; }
        }

        class Ally
        {
            public string Name { get; set; }
        }

        //중복적인 클래스를 만들어야 할 상황에 직면했음. 이럴때 제네릭 생각
        class Troop<T>
        {
            int _count = 0; //현재 생성 유닛 갯수 기억
            T[] army;

            //총 부대원 반환 가능
            public int Count 
            { 
                get { return _count; }
                //▼ 클래스 내부에서만 사용 가능
                private set { _count = value; }
            }

            //특정 인덱스를 주면, 거기 있는 요소를 지우는 기능
            //지워지긴 하되, 중간에 null이 생기지 않고 유의미한 값들이 연속되게 감기게 하고 싶음
            public void RemoveAt(int index)
            {
                for (int i = index; i < _count - 1; i++)
                {
                    army[i] = army[i + 1];
                }
                Count--;
            }


            public void Add(T unit) //인자값 T가 주어지면 그걸 내가 가진 배열에 넣는 기능 제작
            {
                //Resize는 배열의 길이를 다시 바꿔주는 거임
                //저희가 가진 army.Length가 카운트보다 같거나 작으면 길이 일단 2배로
                if (army.Length <= _count)
                {
                    Array.Resize(ref army, army.Length * 2);

                    army[_count] = unit;
                }
                army[_count] = unit;
                _count++;

                //혹은
                //army[_count++] = unit;
            }

            //인덱서 활용
            public T this[int i] //접근지정자, 반환형태, this[int i]
            {
                get { return army[i]; } 
                set {  army[i] = value; }
            }

            public Troop(int troopSize) //외부에서 인자값 주면 해당 크기로 배열 생성
            {
                army = new T[troopSize];
            }

            public Troop()
            {
                army = new T[10];
                _count = 0;
            }
        }

        static void Main(string[] args)
        {
            Troop<Ally> myTeam = new Troop<Ally>(10);
            
            //맴버 이니셜라이저
            myTeam[2] = new Ally() {Name = "Lucina"};
            //↕ 위아래 같다.
            myTeam[2] = new Ally();
            myTeam[2].Name = "Lucina";

            Troop<Enemy> enemyTeam = new Troop<Enemy>(10); //10개짜리 공간'만'



            Troop<Enemy> myEnemy = new Troop<Enemy>();
            
            Enemy tempEnemy = new Enemy();
            tempEnemy.Name = "가렌";
            myEnemy.Add(tempEnemy);

            myEnemy.Add(new Enemy { Name = "데마시아" });

            //카운트까지만 반복문 돌게함. 배열은 10개, 실 요소는 count
            for (int i = 0; i < myEnemy.Count; i++)
            {
                Console.WriteLine(myEnemy[i].Name);
            }

            myEnemy.RemoveAt(1);

            Console.WriteLine("------------------------------");
            for (int i = 0; i < myEnemy.Count; i++)
            {
                Console.WriteLine(myEnemy[i].Name);
            }
        }
    }
}

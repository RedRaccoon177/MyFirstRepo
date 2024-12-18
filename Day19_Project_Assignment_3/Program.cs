using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_Project_Assignment_3
{
    class Milk
    {
        //유통기한
        int _expirationDate;

        public int Date
        {
            get {return _expirationDate;}
            set { _expirationDate = value; }
        }
    }

    class VendingMachine
    {
        Queue<Milk> _queue = new Queue<Milk>();

        //우유를 집어넣는 코드
        public void MakeMilk(Milk milk)
        {
            _queue.Enqueue(milk);
        }

        //우유를 꺼내는 기능
        public void PickMilk()
        {
            //꺼낸 우유의 유통기한
            Console.WriteLine($"꺼낸 우유의 유통기한은 {_queue.Dequeue().Date}일");

            //큐에 남아있는 우유 갯수
            Console.WriteLine($"{_queue.Count()}개 우유 남음");

            //갯수가 0일때 우유를 꺼내는 기능을 호출하게 되면 꺼내는 대신 다른 멘트
            if (_queue.Count() == 0)
            {
                Console.WriteLine("우유가 0개이다. 더이상 못꺼냄.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.MakeMilk(new Milk {Date = 15 });
            vendingMachine.MakeMilk(new Milk {Date = 12 });
            vendingMachine.MakeMilk(new Milk {Date = 1 });
            vendingMachine.MakeMilk(new Milk {Date = 9 });

            vendingMachine.PickMilk();
            vendingMachine.PickMilk();
            vendingMachine.PickMilk();
            vendingMachine.PickMilk();
        }
    }
}

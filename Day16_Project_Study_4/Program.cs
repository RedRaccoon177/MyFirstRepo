using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Project_Study_4
{
    //상속: 물려받기
    //클래스를 만드는데, 중복된 내용이 많을 경우,
    //공통된 기능이나 필드를 뽑아내서 상속을 고려할 수 있음

    //필기구, 몬스터, 건축물, 자동차 등등 타 클래스 근간이 되는 클래스를 보고
    //'Base 클래스' 혹은 '부모클래스'

    //저 부모에서 파생된 클래스를 보고 Derived 클래스, 파생클래스
    // 자식클래스

    class Car
    {
        //접근지정자: public, private, protected
        protected float _maxSpeed;
        protected string _brand;
        string _carPlate = "12너1234";

        public void PrintCarPlate()
        {
            Console.WriteLine(_carPlate);
        }

        public Car(string setPlate)
        {
            _carPlate = setPlate;
            Console.WriteLine($"부모{_carPlate} 생성자 호출");
        }

        public Car() { }

        public void Drive()
        {
            Console.WriteLine("주행");
        }
    }

    //상속관계에서 생성자
    class Sedan : Car
    {
        int _passengers;

        public Sedan(int paasengers, string carPlate) : base(carPlate)
        {
            _passengers = paasengers;
            Console.WriteLine("자식 생성자 호출");
        }

        public void SedanAction()
        {
            Console.WriteLine($"최고속도는 {_maxSpeed} 입니다.");
        }
    }

    class PickupTruck : Truck
    {
        bool _isAdditional;

        public PickupTruck(bool additional, string brand, string carPlate, bool TM) : base(carPlate)
        {
            _brand = brand;
            _isAdditional = additional;
            _isTruckModeOn = TM;
        }
    }

    class Truck : Car
    {
        protected bool _isTruckModeOn;

        public Truck(string carPlate) : base(carPlate)
        {
            Console.WriteLine("트럭 만들어짐");
        }

        public void TruckAction()
        {
            Console.WriteLine("짐싣기");
        }
    }

    class Bulldozer : Car
    {
        public void BulldozerAction()
        {
            Console.WriteLine("평탄화");
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            //Sedan sedan = new Sedan(4, "13너 2929");
            PickupTruck pickup = new PickupTruck(true, "기아", "12나", true);

        }
    }
}

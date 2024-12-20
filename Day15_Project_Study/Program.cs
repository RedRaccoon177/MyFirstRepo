using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Project_Study
{
    //struct Vector2
    //{
    //    int x;
    //    int y;

    //    public void PrintXandY()    //구조체가 사실 메서드도 가질 수 있음!
    //    {
    //        Console.WriteLine($"x는 {x} y는 {y} 입니다.");
    //    }

    //    public Vector2(int posX, int posY)
    //    {
    //        x = posX;
    //        y = posY;
    //    }
    //}

    //class Player
    //{
    //    Vector2 _playerPos;     //플레이어 포지션

    //    public Player(Vector2 pos)  //초기화, 생성자
    //    {
    //        _playerPos = pos;
    //    }
    //}

    class Item
    {
        string _name;
        int _price;

        //▼ 인자값 2개 들고 있는 생성자
        public Item(string name, int price)
        {
            _name = name;
            _price = price;
        }
    }

    class Player
    {

        //▼ 필드
        Item[] _inven;

        //▼ 생성자
        public Player()
        {
            _inven = new Item[10];
        }

        //▼ 메소드
        public void SetItemByIndex(int index, Item itemToInput)
        {
            _inven[index] = itemToInput;
        }
    }

    internal class Program
    {
        #region 어제 배웠던 것들 복습
        //class Person
        //{
        //    //정보 은닉
        //    private string _name;   //맴버 변수, 필드
        //    private int _age;

        //    //프로퍼티 
        //    public string Name   // 맴버변수와의 상호작용을 위한 인터페이스
        //    {
        //        get
        //        {
        //            return _name;       //내가 가진 맴버 변수를 (get)가져올 때
        //        }
        //        set
        //        {
        //            _name = value;      //내가 가진 맴버 변수를 세팅(setting) 해줄 때
        //        }
        //    }

        //    public int Age
        //    {
        //        get { return _age; }
        //        set 
        //        {
        //            if (value >= 0)
        //            { 
        //                _age = value;
        //            }
        //        }
        //    }

        //    public void Introduce() //메서드 (기능에 초점)
        //    {
        //        Console.WriteLine($"안녕 난 {_name} 이고, 나이는 {_age} 야");
        //    }
        //}
        #endregion

        static void Main(string[] args)
        {
            #region 어제 배웠던 것들 복습
            ////추상화

            ////클래스 (자료형)
            ////=> 요소, 기능을 묶은 설계도라고 생각하면 좋다.

            //Person human; //텅 빈거나 마찬가지
            //human = new Person(); //new를 통해 메모리에 실체를 가짐. 인스턴스화 한거임.
            //human.Introduce();
            //human.Name = "프로퍼티를 통해 private된 이름에 입력할수도 출력할 수도 있는거!";
            //human.Age = 100;
            #endregion

            /*
            //Pet pet = new Pet();
            //Pet pet2 = new Pet(12);
            //Pet pet3 = new Pet("가붕이!", 12, "데마시아!");


            //유저에게 이릅을 입력 받아보고, 아무것도 안적으면 이를 판독 후
            //조건문에 따라 각기 다른 방식으로 생성자 호출 가능
            //Trainer trainer = new Trainer();
            //Console.WriteLine(trainer.Level);
            //Console.WriteLine(trainer.Name); */

            /*
            //int a = new int();     //a=0
            //float b = new float(); //b=0.00f
            //bool c = new bool();   //c=false
            //Vector2 d = new Vector2();  //임시로 x=0, y=0을 가진 임시 구조체 하나 생김
            ////그리고 d로 복사된다.
            ///*/

            /*
            // 임시로 x에 2, y는 3을 가진 구조체를 생성
            //▼ 그걸로 playerPos에 그대로 복사
            Vector2 playerPos = new Vector2(2, 3);
            
            //배열에 new를 쓰면 힙 영역 어딘가에 공간을 빌린 후 주소값이 반환됨
            //클래스에 new를 쓰면 해당하는 생성자도 부르고, 힙 어딘가에 공간을 빌린 후, 주소값이 반환됨
            //구조체에 new를 쓰면 해당하는 생성자를 불러서 임시 구조체를 생성 후, 그 구조체 반환
            */

            //Player newPlayer = new Player(new Vector2 (4, 4));

            Player player = new Player();
            player.SetItemByIndex(0, new Item("롱소드", 12));
        
            Trainer newTrainer = new Trainer(1,"닉네임");
            newTrainer.PrintMyName();
        }
    }
}

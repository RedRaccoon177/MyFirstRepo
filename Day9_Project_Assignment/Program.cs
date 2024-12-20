using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using static Day9_Project_Assignment.Program;

namespace Day9_Project_Assignment
{
    internal class Program
    {
        #region 과제1. 열거형 리팩토링
        //enum ToDetermine
        //{
        //    디폴트, 마을, 사냥터, 상점
        //}
        #endregion

        #region 과제2. 상태를 열거형으로 구현
        //public enum State
        //{
        //    idle = 1, run, walk, die = 9
        //}
        #endregion

        #region 과제3. 구조체 활용하기
        //public struct XYCoord       //XYCoord 구조체 선언
        //{
        //    public short x;
        //    public short y;
        //}
        //public struct Weapon        //정수형 Dmg, 실수형 Critical, 문자열형 Name을 가진 구조체
        //{
        //    public int Dmg;
        //    public float Critical;
        //    public string Name;
        //}
        //public enum Maker                  //Car라는 구조체 안에 사용 되는 maker
        //{
        //    Honda, Audi, BMW, Kia
        //}
        //public struct Car           //Car라는 구조체를 만든후, 
        //{
        //    public float MaxSpeed;
        //    public int CarNum;
        //    public Maker maker;
        //}
        //public enum ItemType         //Item구조체에 사용될 타입 열거형
        //{
        //    방어구, 무기, 소모품
        //}
        //public struct Item           //Item이라는 구조체
        //{
        //    public string Name;
        //    public int Price;
        //    public ItemType Type;
        //}
        #endregion

        #region 심화 과제
        public struct Weapon
        {
            public string name;
        }

        public struct Soilder
        {
            //Weapon구조체를 담을수 있는 배열
            public Weapon[] weapons;

            //현재 손에 들고 있는 Weapon이 무엇인지 저장할 배열의 인덱스로 사용할 정수형 변수
            public int whatWeapon;
        }

        #endregion

        static void Main(string[] args)
        {
            #region 과제1. 열거형 리팩토링
            //Console.WriteLine("이동할 장소를 설정해주세요.");
            //Console.WriteLine("1. 마을");
            //Console.WriteLine("2. 사냥터");
            //Console.WriteLine("3. 상점");
            //ToDetermine selectmap = ToDetermine.디폴트;

            //Enum.TryParse(Console.ReadLine(), out selectmap);
            //Console.Clear();    //화면을 지워줍니다
            //switch (selectmap)
            //{
            //    case ToDetermine.마을:
            //        Console.WriteLine($"{ToDetermine.마을}로 이동합니다.");
            //        break;
            //    case ToDetermine.사냥터:
            //        Console.WriteLine($"{ToDetermine.사냥터}로 이동합니다.");
            //        break;
            //    case ToDetermine.상점:
            //        Console.WriteLine($"{ToDetermine.상점}로 이동합니다.");
            //        break;
            //    default:
            //        Console.WriteLine("1,2,3 어느것도 아니에요");
            //        break;
            //}
            #endregion

            #region 과제2. 상태를 열거형으로 구현
            //int stateint0 = (int)State.idle;        //현재 상태
            //int stateint1 = (int)State.idle;       //전의 상태
            //bool isCorrect = true;

            //while (true)        //무한 반복
            //{
            //    Console.WriteLine("idle = 1, run = 2, walk = 3, die = 9만을 입력하시오.");
            //    isCorrect = int.TryParse(Console.ReadLine(), out stateint0);    //값 입력

            //    if (isCorrect == true)      //일단 숫자일 경우
            //    {
            //        if (stateint0 == stateint1)
            //        {
            //            State state0 = (State)stateint0;
            //            Console.WriteLine($"이미{state0}상태 입니다.");
            //        }
            //        else if (stateint0 == 1)                 //1일 경우
            //        {
            //            State state0 = (State)stateint0;
            //            State state1 = (State)stateint1;
            //            Console.WriteLine($"{state1} 에서 {state0}상태로 전환 되었다.");
            //            stateint1 = stateint0;
            //        }
            //        else if (stateint0 == 2)            //2일 경우
            //        {
            //            State state0 = (State)stateint0;
            //            State state1 = (State)stateint1;
            //            Console.WriteLine($"{state1} 에서 {state0}상태로 전환 되었다.");
            //            stateint1 = stateint0;
            //        }
            //        else if (stateint0 == 3)            //3일 경우
            //        {
            //            State state0 = (State)stateint0;
            //            State state1 = (State)stateint1;
            //            Console.WriteLine($"{state1} 에서 {state0}상태로 전환 되었다.");
            //            stateint1 = stateint0;
            //        }
            //        else if (stateint0 == 9)             //9일 경우
            //        {
            //            State state = (State)stateint0;
            //            Console.WriteLine($"{state}하셨습니다.");
            //            break;
            //        }
            //    }
            //}
            #endregion

            #region 과제3. 구조체 활용하기
            //Weapon Sword = new Weapon();
            //Sword.Name = "소드";
            //Sword.Dmg = 100;
            //Sword.Critical = 7;
            //Weapon Katana = new Weapon();
            //Katana.Name = "카타나";
            //Katana.Dmg = 50;
            //Katana.Critical = 9;

            //Item[] inventory = new Item[3];   //아이템이 3개 들어가는 인벤토리
            //inventory[2].Name = "악몽의 꽃 견갑";
            //inventory[2].Price = 500;
            //inventory[2].Type = ItemType.방어구;
            //Inventory(inventory[2].Name, inventory[2].Price, inventory[2].Type);
            #endregion

            #region 심화 과제
            //솔져 구조체 창조
            Soilder soilder;
            // = new Soilder(); 이거 필요 없나봄

            //솔져의 무기 목록 배열에 Weapon구조체를 3개 담을 수 있게 초기화
            soilder.weapons = new Weapon[3];

            //솔져가 가진 무기의 배열에 본인이 희망하는 이름 3가지 기입
            Console.WriteLine("본인이 희망하는 무기 이름 3가지를 입력하시오.");
            soilder.weapons[0].name = Console.ReadLine();
            soilder.weapons[1].name = Console.ReadLine();
            soilder.weapons[2].name = Console.ReadLine();

            //처음에 1번을 들고 있음
            ChangeWeapon(soilder.weapons[0].name, soilder.weapons[1].name, soilder.weapons[2].name);

            #endregion
        }

        #region 과제3. 구조체 활용하기
        //static void Inventory(string name, int price, ItemType itemType)
        //{
        //    Console.WriteLine($"{name}, {price}, {itemType}");
        //    return;
        //}
        #endregion

        #region 심화 과제
        static void ChangeWeapon(string name0, string name1, string name2)
        {
            int changeNum = 1;
            int changeNum2 = 1;

            Console.WriteLine($"현재{name0}을 사용중이다. 어떤 무기로 바꿀 것이냐");

            while (true)
            {
                changeNum = int.Parse(Console.ReadLine());

                if (1 <= changeNum && changeNum <= 3)
                {
                    if (changeNum == 1)
                    {
                        if (changeNum == changeNum2)
                        {
                            Console.WriteLine($"이미 {name0} 무기를 사용 입니다.");
                        }
                        else
                        {
                            Console.WriteLine($"무기를 {name0}로 전환합니다.");
                            changeNum2 = 1;
                        }
                    }
                    else if (changeNum == 2)
                    {
                        if (changeNum == changeNum2)
                        {
                            Console.WriteLine($"이미 {name1} 무기를 사용 입니다.");
                        }
                        else
                        {
                            Console.WriteLine($"무기를 {name1}로 전환합니다.");
                            changeNum2 = 2;
                        }
                    }
                    else if (changeNum == 3)
                    {
                        if (changeNum == changeNum2)
                        {
                            Console.WriteLine($"이미 {name2} 무기를 사용 입니다.");
                        }
                        else
                        {
                            Console.WriteLine($"무기를 {name2}로 전환합니다.");
                            changeNum2 = 3;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("1~3사이의 정수만 입력하시오.");
                }
            }
        }
        #endregion
    }
}

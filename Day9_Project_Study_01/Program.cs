using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Day9_Project_Study_01
{
    internal class Program
    {
        //구조체 //structure //구조물 //인위적으로 만들어진 물체
        //struct[원하는 구조체명]
        //{
        //    [자료형][변수명];
        //    [자료형][변수명];
        //    [자료형][변수명];
        //}

        #region 수업 1. 구조체에 대해서 학습함
        //struct Car  //자동차라는 자료형 하나 만들었고, 이름은 Car
        //{
        //    //접근 지정자: public, private (미래에 protected)
        //    public float maxSpeed;      //멤버변수, 혹은 필드, 구성요소 라는 이름으로 호칭 할 예정
        //    public string makerCar;
        //    private int carNumber;      //협업때 건드리지 않았으면 하는 변수들 숨김
        //}
        #endregion

        public enum ItemType        //설계도
        {
            weapon, armour, usable
        }
        public struct Item          //아이템 설계도 끝
        {
            public string name;
            public int price;
            public ItemType itemtype;
            public int[] useRate;
            float dropRate;
            
        }

        static void Main(string[] args)
        
        {
            #region 수업 1. 구조체에 대해서 학습함
            //[자료형] [변수이름]
            /*Car firstCar;
            firstCar.maxSpeed = 15.2f;

            Car secondCar;
            secondCar.makerCar = "KIA";

            Console.WriteLine(firstCar.maxSpeed);*/
            #endregion

            Item[] inventory = new Item[4]; //아이템 4개를 담을 배열

            //inventory[0].name = "황갑충";
            //Console.WriteLine(inventory[0].name);

            inventory[0].name = "공허의 지팡이";
            inventory[0].price = 123;
            inventory[0].useRate = new int[4];
            inventory[0].useRate[0] = 1;

            Console.WriteLine(inventory[0].useRate[0]);

        }
    }
}

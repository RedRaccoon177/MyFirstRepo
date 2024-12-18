using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Day19_Project_Assignment_0
{
    class UsableItem
    {
        private string _name;
        private int _prince;
        private int _quantity;

        //외부와 소통 가능한 프로퍼티들
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Prince
        {
            get { return _prince; }
            set { _prince = value; }
        }
        public int Quantity
        {
            get { return _quantity; }
            set { _quantity = value; }
        }

        //UsableItem에서만 사용 할 수 있는 메소드
        public void Special(int i)
        {

        }
    }

    class Player
    {
        int _invenCount;
        //inventory 필드 추가
        List<UsableItem> inventory = new List<UsableItem>();


        //유료결제 여부를 저장할 수 있는 필드,
        bool useRealMoney = new bool();

        //해당 참거짓을 전환 가능한 프로퍼티 혹은 메서드
        public void ChangeBool()
        {
            if (useRealMoney == true)
            {
                useRealMoney = false;
            }
            else
            {
                useRealMoney = true;
            }
        }

        public void AddItem(UsableItem usableItem)
        {
            //유료결제 여부가 참일 경우 
            if (useRealMoney == true)
            {
                //인벤토리에 아이템을 Add를 자유롭게 할 수 있고
                inventory.Add(usableItem);
                _invenCount++;
            }
            else if (useRealMoney == false) //거짓일 경우
            {
                //아이템을 최대 30개까지 저장 가능하고
                if (_invenCount <= 30)
                {
                    inventory.Add(usableItem);
                    _invenCount++;
                }
                else
                {
                    Console.WriteLine("유료결제 하십시오.");
                }

                //초과로 저장하려고 시도하면 콘솔 출력을 통해 추가하지 않고 거부하는 기능
                if (inventory.Count >= 31)
                {
                    Console.WriteLine("유료결제 하십시오.");
                }
            }
        }

        //ShowInven 이라는 메서드
        public void ShowInven()
        {
            foreach (var item in inventory)
            {
                Console.WriteLine($"{item} \t");
            }
        }
    }

    class Weapon
    {
        //이름과 공격력 필드를 프라이빗으로 가지고 있게 합니다.
        private string _name;
        private int _attack;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Attack
        {
            get { return _attack; }
            set { _attack = value; }
        }

        private void Special()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

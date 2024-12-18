using System;

namespace Day18_Project_Assignment_1
{
    //플레이어어와 상호작용 할 특정 NPC들이 사용할 인터페이스
    interface IInteractable
    {
        void Interact();
    }

    //NPC 뼈대 추상 클래스
    abstract class AllNPC
    {
        public float _X;
        public string _name;
    }

    //강화 NPC
    class StrengthenNPC : AllNPC, IInteractable
    {
        public StrengthenNPC(float x, string name) 
        {
            _X = x;
            _name = name;
        }
        public void Interact()
        {
            Console.WriteLine("강화를 수행합니다. 깡! 깡!");
        }
    }
    
    //창고 NPC
    class WarehouseNPC : AllNPC, IInteractable
    {
        public WarehouseNPC(float x, string name)
        {
            _X = x;
            _name = name;
        }
        public void Interact()
        {
            Console.WriteLine("창고를 수행합니다. 철컥~?");
        }
    }

    //잡 NPC
    class JobNPC : AllNPC
    {
        public JobNPC(float x, string name)
        {
            _X = x;
            _name = name;
        }
    }

    class Player
    {
        float _X;
        string _name;

        public Player()
        {

        }
        public Player (float  x,string name )
        {
            _X = x;
            _name = name;
        }

        public void InteractWithNPC(IInteractable npc)
        {
            npc.Interact();
        }

        public void ShowInteractable(AllNPC[] allNPCs)
        {
            for (int i = 0; i < allNPCs.Length; i++)
            {
                //?를 사용하여서 할 수 있는 방법이 있을 것 같다.
                if (allNPCs[i] != null)
                {
                    if (Math.Abs(_X - allNPCs[i]._X) < 5)
                    {
                        Console.WriteLine(allNPCs[i]._name);
                    }
                }
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player(5, "플레이어");

            AllNPC[] allNPC = new AllNPC[3];

            allNPC[0] = new StrengthenNPC(3, "강화NPC");
            allNPC[1] = new WarehouseNPC(7, "창고NPC");
            allNPC[2] = new JobNPC(12, "잡NPC");

            player.ShowInteractable(allNPC);

            //▼ 뭐지? 왜 배열은 가능이지?
            //AllNPC jobNPC0 = new AllNPC();
            //AllNPC[] jobNPC1 = new AllNPC[1];
        }
    }
}

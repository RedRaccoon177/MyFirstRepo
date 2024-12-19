using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_Project_Assignment_1
{
    public abstract class Terran
    {
        string _name;
        int _hp;
        bool _isAttack;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int HP
        {
            get { return _hp; }
            set { _hp = value; }
        }
        public bool IsAttack
        {
            get { return _isAttack; }
            set { _isAttack = value; }
        }
    }

    class Marine : Terran
    {
        public Marine()
        {
            Name = "마린";
            HP = 55;    
            IsAttack = true;
        }

        public void SteamPack()
        {
            HP = HP - 10;
            Console.WriteLine("공속, 뎀지 일시 상승");
        }
    }

    class Medic : Terran
    {
        public Medic()
        {
            Name = "메딕";
            HP = 70;
            IsAttack = false;
            
        }

        public void OpticalFlare()
        {
            Console.WriteLine("옵티컬 플레어 사용");
        }
    }

    class Barracks
    {
        //선입선출 배력 Queue
        Queue<Terran> _queue = new Queue<Terran>();

        public void EnqueueUnit(Terran terranUnit)
        {
            _queue.Enqueue(terranUnit);
        }

        public void DequeueUnit()
        {
            Terran terranUnit = _queue.Dequeue();
            Console.WriteLine($"{terranUnit.Name}이 생성되었음");
        }

        public void ShowQueueLine()
        {
            foreach(Terran terran in _queue)
            {
                Console.WriteLine($"이름: {terran.Name} \t hp: {terran.HP}");
            }    
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Barracks barracks = new Barracks();
            
            barracks.EnqueueUnit(new Medic { HP = 100, Name ="영웅 메딕"});
            barracks.EnqueueUnit(new Marine());
            barracks.EnqueueUnit(new Marine());
            barracks.EnqueueUnit(new Marine { Name = "짐 레이너", HP = 1000});
            barracks.EnqueueUnit(new Medic());
            barracks.DequeueUnit();

            barracks.ShowQueueLine();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day21_Project_Assignment_0
{

    class Buff
    {
        string _name;
        int _duration;
        public Buff()
        {
            _name = "";
            _duration = 0;
        }
        public Buff(string name, int duration)
        {
            _name = name;
            _duration = duration;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Duration
        {
            get { return _duration; }
            set { _duration = value; }
        }
    }

    class BuffManager
    {
        LinkedList<Buff> _buffs = new LinkedList<Buff>();
        public void AddBuff(Buff buff)
        {
            _buffs.AddLast(buff);
        }
        public void UpdateBuffs()
        {
            foreach (Buff buff in _buffs)
            {
                if (buff.Duration > 0)
                {
                    buff.Duration = buff.Duration - 1;
                }
                else if (buff.Duration <= 0)
                {
                    Console.WriteLine($"{buff.Name}");
                    _buffs.Remove(buff);
                }
            }
        }
        public void ShowActiveBuffs()
        {
            Console.WriteLine("현재 활성화된 버프:");
            foreach (Buff buff in _buffs)
            {
                Console.WriteLine($"이름: {buff.Name}, 남은 시간: {buff.Duration}");
            }
        }
    }



    internal class Program
    {
        static void Main(string[] args)
        {
            BuffManager buffManager = new BuffManager();

            buffManager.AddBuff(new Buff("광폭화", 7));
            buffManager.AddBuff(new Buff("평정", 10));
            buffManager.AddBuff(new Buff("단단하게", 2));

            buffManager.ShowActiveBuffs();

            Console.WriteLine("--------------------");
            buffManager.UpdateBuffs();
            buffManager.UpdateBuffs();
            buffManager.UpdateBuffs();

            buffManager.ShowActiveBuffs();

        }
    }
}

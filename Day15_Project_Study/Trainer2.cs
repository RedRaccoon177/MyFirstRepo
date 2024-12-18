using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Project_Study
{
    partial class Trainer
    {
        //partial 부분화
        public void PrintMyName()
        {
            Console.WriteLine("내 이름 출력" + _nickname);
        }
    }
}

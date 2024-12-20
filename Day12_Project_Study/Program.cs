using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day12_Project_Study
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();      //랜덤 쓰려고 만듦

            while (true) 
            {
                //Console.WriteLine(rnd.Next());      //범위 양의 정수
                //Console.WriteLine(rnd.Next(0, 10));      //범위 양의 정수
                //Console.WriteLine(rnd.NextDouble());        //소수점 랜덤값
                
                float myNum = (float)rnd.Next(0,100) / 100;
                Console.WriteLine(myNum);


            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Parent
    {
        public string Name = "부모";
    }

    class Child : Parent
    {
        public new string Name = "자식";
    }

    class Program
    {
        static void Main(string[] args)
        {
            Parent parent = new Parent();
            Child child = new Child();
            Parent parentAsChild = new Child(); // 부모 타입으로 참조

            Console.WriteLine(parent.Name);        // 출력: 부모
            Console.WriteLine(child.Name);         // 출력: 자식
            Console.WriteLine(parentAsChild.Name); // 출력: 부모
        }
    }

}


using System;
using System.Collections.Generic;

namespace Day18_Project_Study_1
{//추상클래스

    //추상 클래스, 뼈대 클래스 혹은 불완전 클래스, 자식에게 완성도하게 함.
    abstract class Animal
    {
        protected int _health;
        //▼ 자식클래스에서 abstract를 꼭 받아야 하므로 일종의 필수 적인 것
        public abstract void Speak();   //추상메서드: 본인은 구현 못하고 자식에게 구현을 강요
        public virtual void Move()      //버츄얼: abstract랑 다르게 필수적으로 받는 것이 아님.
        {
            Console.WriteLine("기본 움직임"); //동물이 기본적으로 가지는 움직임
        }
    }

    class Horse : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("난 말이오");
        }
    }

    class Dog : Animal
    {
        public override void Move()
        {
            Console.WriteLine("산책");
        }

        public override void Speak()
        {
            Console.WriteLine("왈왈");
        }
    }

    class Cat : Animal
    {
        public override void Speak()
        {
            Console.WriteLine("냐옹");
        }
    }

    class Trainer
    {
        Animal[] myDogs;        //다형성을 이용하여 엄청 줄일 수 있다.
        public void AddAnimalToTeach(Animal toTeach)    //아니면 다 적어야 했을 것이다
        {
            myDogs[0] = toTeach;
        }
    }

    internal class Program
    {
        //오버라이드
        static void Main(string[] args)
        {//다형성, 버츄얼, abstract 오버라이드, 추상클래스, 키워드 (is, as)
            Random rnd = new Random();
            Animal[] animals = new Animal[10]; //개를 담을 수 있는 10개 공간 (그냥 공간 확보용)

            for (int i = 0; i < animals.Length; i++)
            {
                if (rnd.Next(2) == 0)       //만약 뽑아낸 게 0이라면?
                {
                    animals[i] = new Dog();
                }
                else
                {
                    animals[i] = new Cat();
                }
            }

            foreach (var ele in animals)
            {
                ele.Move();
            }

        }
    }
}

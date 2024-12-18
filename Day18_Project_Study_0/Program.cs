using System;
using System.Collections.Generic;

namespace Day18_Project_Study_0
{
    //오버라이드 덮어씌우다, 재정의하다,
    class Animal
    {
        protected int _health;
        public virtual void Speak()  //버츄얼을 사용하였으므로 가상함수(재정의 가능한 함수, 가상함수)
        {
            Console.WriteLine("동물 소리내기");
        }
    }

    class Dog : Animal 
    {
        public override void Speak()
        {
            Console.WriteLine("왈왈");
        }
    }

    class Cat : Animal
    { 
        public void Grooming()
        {
            Console.WriteLine("그릉그릉");
        }

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
            //Random rnd = new Random();
            //Animal[] animals = new Animal[10]; //개를 담을 수 있는 10개 공간 (그냥 공간 확보용)

            //for (int i = 0; i < animals.Length; i++)
            //{
            //    if (rnd.Next(2) == 0)       //만약 뽑아낸 게 0이라면?
            //    {
            //        animals[i] = new Dog();
            //    }
            //    else
            //    {
            //        animals[i] = new Cat();
            //    }
            //}

            //foreach (var ele in animals)
            //{
            //    ele.Speak();
            //}

            //@@@@@@@@
            Animal animal = new Cat();

            //형변환 관련 키워드 2개
            // is
            //if (animal is Cat)  //is 좌측 변수가 우측 자료형이 맞다면 참, 아니면 거짓
            //{
            //}

            //((Cat)animal).Grooming();
            //as
            //좌측 변수를 우측 자료형으로 바꾸어보고 성공했으면 변환, 실패시 null
            if (animal as Cat != null)
            {
                (animal as Cat).Grooming();
            }

            (animal as Cat)?.Grooming();


            /*
            Animal animal = new Animal();
            Dog[] dogs = new Dog[15];
            Cat[] cats = new Cat[15];
            foreach (var ele in dogs)
            {
                ele.Speak();
            }
            foreach (var ele in cats)
            {
                ele.Speak();
            } */
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Xml.Linq;

namespace Day17_Project_Study_3
{
    //컵은 액체를 담는다. 클립

    class Milk
    {
        public string _ExpireDate;

        public Milk() { }

        public Milk(string ExpireDate) 
        {
            _ExpireDate = ExpireDate;
        }
    }
    class Coffee
    {
        public string CoffeeType;
    }
    class Water
    {
        public string WaterName;
    }
    class PaperClip
    {
        public string Material;
    }

    // ▼ T에 Milk 치환 (T는 타입의 준말인 약자를 넣은거임.)
    class Cup<T, U> 
        where T : Milk, new() //인자값을 요구하지 않는 생성자가 있는 클래스만 들어올 수 있게끔 제약
        where U : struct  
    {
        T _contents = new T();
        U _fillAmount;
        float _input;

        public T GetContents()
        {
            return _contents;
        }
    
        public void SetFillAmount(U amount)
        {
            _fillAmount = amount;
        }
    
    }

    //제네릭: 하나의 클래스가 다양한 형태의 자료형을 처리할 수 있게 됨
    //Where 제약문 : 제약 걸때 씀

    internal class Program
    {
        static void Main(string[] args)
        {
            //Cup<int> waterCup = new Cup<int>();
            //Console.WriteLine(waterCup.GetContents());

            //Cup<Water, Milk> waterCup = new Cup<Water, Milk>();
            //waterCup.GetContents().WaterName = "hh";
        }
    }
}

using System;
using System.Collections.Generic;

namespace Day18_Project_Study_2
{
    //제너릭
    class ArrayHelper <T> where T: struct
    {
        T[] myArr;
        public void SetArrayByLength(int arrLength)
        {
            myArr = new T[arrLength];
        }
        public int GetArrLength()
        {
            return myArr.Length;
        }
        public T GetArrFirstElement()
        {
            return myArr[0];
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var array = new ArrayHelper<int>();
            array.SetArrayByLength(5);
            Console.WriteLine(array.GetArrFirstElement());
        }
    }
}

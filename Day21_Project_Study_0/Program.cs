using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;

namespace Day21_Project_Study_0
{
    //sealed 상속 막기
    sealed class DontTouch
    {
        public string messageToOther = "위태로운 클래스니 건들지 말것";
    }

    //▼ 편법으로 클래스 건드리기
    /*
    class NowICanChange : DontTouch
    {
        public void PrintAddedFunc()
        {
            Console.WriteLine("추가함");
        }
    }
    */


    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Random rnd = new Random();
            
            int tempNum0 = rnd.Next(1, 7); // 1이상 7미만 항상 불편하다.
            Console.WriteLine($"주사위 굴려서 {tempNum0} 이 나왔습니다.");

            rnd.NextInclueEndNum(1, 6);
            int tempNum1 = rnd.NextInclueEndNum(1, 6); // 1이상 6이하
            Console.WriteLine($"주사위 굴려서 {tempNum1} 이 나왔습니다.");
            */

            //DontTouch myObj = new DontTouch();
            //myObj.AddedFunc();

            //▼ 빈 리스트 생성
            List<int> intList = new List<int>();

            //▼ add를 총 5회 수행
            for (int i = 0; i < 5; i++)
            { 
                intList.Add(i);   
            }

            intList.PrintAllMembers();

            //Console, Math, 애초에 정적으로 만들어진 클래스는 확장메서드 오히려 못씀
        }
    }
}

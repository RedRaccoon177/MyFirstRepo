using Microsoft.Win32;
using System;


namespace Day16_Project_Study_3
{
    /*
    struct intAlike
    {
        public static void ParseAlike()
        {
            Console.WriteLine("int.Parse랑 비슷하게 적었음");
        }
    }

    class StaticFunc
    {
        int nonStaticNum = 5;   //비정적, 일반적인 필드
        static int staticNum = 10;  //정적 필드
    
        public static void PrintNum()   //정적 메서드 만들었음
        {
            Console.WriteLine("정적 인트값은: " + staticNum);
        }

        public void PrintNormalNum()   //정적 메서드 만들었음
        {
            Console.WriteLine("정적 인트값은: " + nonStaticNum);
        }

        public static void IncreaseAndPrintStaticNum()  //정적 메서드는 정적 메서드만 부를 수 있음.
        {
            //정적 메서드 내에서 지역변수들은 static일 필욘 없다.
            Random rnd = new Random(); //랜덤도 가능하다. 어차피 이거 사용 끝나면 사라지니깐
            int a = 10;      //지역 변수는 가능하다.
            staticNum += a;
            PrintNum();
            //▼ 오류 날거임. Static이 아니라서 그럼.
            // PrintNormalNum();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            StaticFunc temp = new StaticFunc();
            StaticFunc.PrintNum();

            intAlike.ParseAlike();
            int.Parse("");
        }
    }
    */

    //정적 필드
    //정적 프로퍼티
    //정적 메소드
    //정적 클래스

    static class MyMath
    {
        static int usageCount;
        public const float PI = 3.14f;  //const는 불변이라서 static이 아니여도 사용 가능.
        static readonly int dontKnowYet;
        
        static public int DoubleTheNumber(int _toDouble)
        {
            return _toDouble;
        }

        //정적 생성자
        static MyMath()
        {
            Console.WriteLine("나 생성");
        }

        //정적 메서드
        public static void DoSome()
        {
            Console.WriteLine("뭐라도 해");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //int myNum = 4;
            //int doubleNum = MyMath.DoubleTheNumber(myNum);
            //Console.WriteLine(MyMath.PI);

            MyMath.DoSome();
        }
    }
}

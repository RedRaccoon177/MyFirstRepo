using System;

namespace Day16_Project_Assignment
{
    class Normal4
    {
        private static int _temp1;
        private int _tmep2;

        public static void SomeTing0()
        {
            _temp1++;
            Console.WriteLine(_temp1);
        }

        public void SomeTing1()
        {
           // _temp1++;
            Console.WriteLine(_temp1);
        }

        public static void NoTemp()
        {
            int temp = 0;
        }

    }

    class Normal
    {
        private static int temp;
        int temp2;

        public void UPInt1()
        {
            temp++;
            Console.WriteLine(temp);
        }

        public static int RealTemp1
        {
            get
            {
                return temp;
            }
            set
            { 
                temp = value;
            }
        }
    }

    internal class Program
    {
        
        static void Main(string[] args)
        {
            Normal normal1 = new Normal();
            Normal normal2 = new Normal();
            Normal normal3 = new Normal();

            Normal4 normal4 = new Normal4();
        }
    }
}



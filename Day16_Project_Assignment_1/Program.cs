using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Project_Assignment_1
{
    class myHelper
    {
        #region 심화 과제1
        public static void FindMinimum(int[] ints, ref int minNum)
        {
            minNum = ints[0];
            for (int i = 1; i < ints.Length; i++)
            {
                if(ints[i] < minNum)
                {
                    minNum = ints[i];
                }
            }
        }
        #endregion

        #region 심화 과제2
        public static void CountUppercaseLetters(string isString, ref int isCount)
        {
            char[] chars = isString.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                if (char.IsUpper(chars[i]))
                {
                    Console.WriteLine(chars[i]);
                    isCount++;
                }
            }
        }
        #endregion
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            #region 심화 과제1
            int[] _tempNum = new int[5] { 3, 2, 1, 4, 5};
            int minNum = 0;
            myHelper.FindMinimum(_tempNum, ref minNum);
            #endregion

            #region 심화 과제2
            string isString = "Hello World";
            int isCount = 0;

            myHelper.CountUppercaseLetters(isString, ref isCount);
            Console.WriteLine(isCount);
            #endregion
        }
    }
}

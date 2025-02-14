using System;
using System.Collections.Generic;

namespace Day2025_01_31_0
{
    internal class Program
    {
        // 쉘 소트: 삽입 정렬 개선한 알고리즘
        // 멀리 떨어진 요소를 비교하고, 점점 간격을 줄여가며 정렬하는 방식
        static void ShellSort(List<int> arr)
        {
            int n = arr.Count;

            for (int gap = n/2; gap > 0; gap /= 2)
            {
                for (int i = gap; i < n; i++)
                { 
                    int key = arr[i];
                    int j = i;
                
                    while(j >= gap && arr[j-gap] > key) //현재 key보다 큰 값이 있으면 뒤로 밀어줌
                    {
                        arr[j] = arr[j-gap];
                        j -= gap;   //이걸 계속 하면서 이전 간격(gap)만큼 이동하며 비교
                    }
                    arr[j] = key;   //적절한 위치 찾았으면 이걸로 삽입
                }
            }
        }
        static void Main(string[] args)
        {
            List<int> arr = new List<int> { 2, 1, 3, 5, 4, 7, 6 };
            
            ShellSort(arr);

            for (int i = 0; i < arr.Count; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day16_Project_Assignment_2
{
    class Achievement
    {
        string _Name;    //업적 이름
        string _Description; //업적 설명
        int _Goal;   //목표 수치
        int _Progress;   //현재 진행 수치(기본값0)
        bool _IsCompleted;    //업적 달성 여부(기본값 false)

        static int TotalAchievements;   //생성된 업적의 총 개수를 저장하는 static필드
        static int CompletedAchievements;   //달성된 업적의 총 개수를 저정하는 static필드

        public Achievement(string name, string description, int goal)
        {
            _Name = name;
            _Description = description;
            _Goal = goal;
            TotalAchievements++;
        }
    
        public void AddProgress(int value)
        {
            if (_Progress + value >= _Goal)
            { 
                _IsCompleted = true;
                CompletedAchievements++;
                Console.WriteLine($"업적 {_Name} 달성!");
            }
        }

        public void DisplayInfo()
        {
            Console.WriteLine(_Name);
            Console.WriteLine(_Description);
            Console.WriteLine(_Goal);
            Console.WriteLine(_Progress);
            Console.WriteLine(_IsCompleted);
        }
        public static void DisplaySummary()
        {
            Console.WriteLine(TotalAchievements);
            Console.WriteLine(CompletedAchievements);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            //▼Achievement[]을 생성
            Achievement[] achievements = new Achievement[3];

            //▼Achievement 객체를 생성
            achievements[0] = new Achievement("초급 도전자", "점수 100점 달성", 100);
            achievements[1] = new Achievement("중급 도전자", "점수 500점 달성", 500);
            achievements[2] = new Achievement("고급 도전자", "점수 1000점 달성", 1000);

            achievements[0].AddProgress(100);
            achievements[1].AddProgress(600);
            achievements[2].AddProgress(800);

            achievements[0].DisplayInfo();
            achievements[1].DisplayInfo();
            achievements[2].DisplayInfo();

            Achievement.DisplaySummary();


        }
    }
}

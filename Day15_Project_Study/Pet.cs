using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Project_Study
{
    internal class Pet
    {
        //▼ 맵버 변수
        string _name;
        int _level;
        string _skill;

        public string Name
        {
            get 
            {
                return _name; 
            }
            set
            {
                _name = value;
            }
        }

        public int Level 
        {
            get
            {
                return _level;
            }
            set
            {
                _level = value;
            }
        }
        public string Skill 
        {
            get 
            {
                return _skill;
            }
            set
            { 
                _skill = value;
            }
        }    

        public void UseSkill()
        {
            Console.WriteLine($"{_skill}을 사용하였습니다.");
        }

        // ▼ 인자값 없는 생성자
        public Pet()
        {
            //생성가 동시에 실행
            Console.WriteLine("이몸 강림");
        }

        // ▼ 매개변수가 있는 생성자
        public Pet(int lvl)
        {
            Level = lvl;
            Console.WriteLine($"펫 레벨을 {_level}로 출고");
        }

        public Pet(string name, int level, string skill)
        {
            Name = name;
            Level = level;
            Skill = skill;

            Console.WriteLine($"이름:{_name} 레벨:{_level} 스킬:{_skill}");
        }

        #region 오버로드 및 오버로딩
        //같은 함수명인데, 메서드 명인데 매개변수가 달라지면 문제 없이 실행되는 걸 보고
        //"오버로드" 혹은 오버로딩. 같은 함수명을 "초과하여 여러 번 사용한다" 이런 뜻
        /*public void PrintPetPrice()
        {

        }
        public void PrintPetPrice(int inputInt)
        {

        }
        public void PrintPetPrice(string dsf)
        {

        }*/
        #endregion


    }
}

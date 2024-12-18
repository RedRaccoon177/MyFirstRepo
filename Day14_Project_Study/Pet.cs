using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Project_Study
{
    enum Tier 
    { 
        Rare, Epic, Legendary
    }

    class Pet
    {
        public enum PetType 
        { 
            Speed, Critical, Specialize
        }
        enum PetSkill 
        {
            ManaRestore, HealthRestore, AttSpeedUp, None
        }

        string _name = "디폴트 이름";
        Tier _petTier;
        int _lvl;
        PetType _petType;
        PetSkill _petSkill;
        Random rd = new Random();


        //펫 이름은 열람도, 수정도 가능
        public string PetName
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

        //펫 등급을 보여주고 기능 보유, 색 변환
        public void PrintTierWithColor()
        {
            switch (_petTier)
            {
                case Tier.Rare:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case Tier.Epic:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case Tier.Legendary:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
            }
            Console.WriteLine(_petTier);
            Console.ResetColor();
        }


        //레벨은 열람만 가능
        public int PetLvl
        {
            get
            {
               return _lvl;
            }
        }

        public void IncreasePetLvl() 
        {
            if (_lvl < 30)
            {
                _lvl++;
            }
        }

        public PetType MyPetType
        {
            get; set;
        }

        public void AddSkill() 
        {
            int randomNum = rd.Next(0, 3);

            if (_petTier != Tier.Legendary)
            {
                _petSkill = PetSkill.None;
            }
            else
            {
                _petSkill = (PetSkill)randomNum;
            }
        }



        //속성을 열람 및 설정 가능함. 단 속성에 부여 가능한 세가지중 하나로만 가능
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_Project_Assignment_2
{
    class Gun
    {
        //Bullet들을 담을 수 있는 List, Grenade들을 담을 수 있는 List
        List<Projectile> bullets;
        List<Projectile> grenades;
        Dictionary<string, List<Projectile>> keyValues;

        //Gun의 생성자를 만들어서 해당 두 자료구조들을 뉴할당 시켜줍니다. 
        public Gun()
        {
            bullets = new List<Projectile>();
            grenades = new List<Projectile>();
            keyValues = new Dictionary<string, List<Projectile>>();

            keyValues.Add("Bullet", bullets);
            keyValues.Add("Grenade",grenades);
        }
        

        public List<Projectile> ShowList(string keys)
        {
            if (keyValues.ContainsKey(keys))
            {
                return keyValues[keys];
            }

            return null;
        }

    }

    class Projectile
    {

    }

    class Bullet : Projectile
    {
        int _damage;
    }

    class Grenade : Projectile
    {
        int _damage;
    }

    class Program
    {
        static void Main(string[] args)
        {
            
        }
    }
}

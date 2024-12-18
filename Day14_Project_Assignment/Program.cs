using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Day14_Project_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 실습 과제3
            //Car car= new Car();
            //Monster monster= new Monster();

            //monster.damage = 20;
            //monster.AttackCar();
            #endregion

            #region 심화 과제
            ////플레이어 객체를 하나 만든 후
            //Player player = new Player();

            ////플레이어의 함수를 통해 인벤토리를 활성화 하자
            //player.MakeInven();

            ////다음엔 플레이어 속의 프로퍼티 인벤을 통해 인벤토리 클래스 속의 CreateInvenBySize 함수를
            ////통해 원하는 만큼의 아이템 배열을 만든 후,
            //player.ShowInven.CreateInvenBySize(10);

            ////본인이 원하는 특정 위치에 아이템을 하나 만들어 넣도록 하자.
            //Item item = new Item();
            //player.ShowInven.SetItemByIndex(item, 0);

            ////플레이어 속 혹은 인벤토리 속 다양한 함수를 직접 확인해 볼 수 있는 코드들을
            ////메인에 적도록 하자
            //player.ShowInven.isInvenCreated();
            //player.ShowInven.GetItemByIndex(1);
            #endregion

            /*심화의 마지막*/
            //메인을 싹 비우고, 플레이어 객체 하나와 몬스터 객체를 하나 만든 후
            Player player = new Player();
            Monster monster = new Monster();

            //몬스터에는 체력 100, 공격력 10을 넣어주자
            monster.hp = 100;
            monster.damage = 10;

            //플레이어에는 체력 200, 공격력 20을 주어진 후
            player.HP = 200;
            player.Attack = 20;

            //객체를 만든 후 모든 공격과 체력이 닳는 과정은 메인서 콘솔로 출력해도 좋다.
            player.HitMonster(monster);
            monster.HitPlayer(player);
        }
    }
}

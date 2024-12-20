using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day23_Project_Study_3
{
    //▼ 반환X, 인자는 인트 하나 쓰는 함수들만 담을 수 있는 델리게이트 설계도 작성
    delegate void StatChange(int level);

    class Player
    {
        int _hp = 100;
        int _att = 10;
        int _def = 30;
        StatChange statChangeAction;    //스텟 변하면 실행될 메서드를 담는 델리게이트 객체
        
        public Player()
        {
            //유니티때, 버튼 눌리면 수행할 다양한 작업들을 이렇게 붙일거임
            statChangeAction += ChangePlayerHp; //플레이어 속에서는
            statChangeAction += ChangePlayerAtt; //플레이어 속에서는
            statChangeAction += ChangePlayerDef; //플레이어 속에서는
        }

        public void LevelUp(int level)
        {
            //이건 위험함: 왜?
            //statChangeAction(level);

            //인보크는 그냥 델리게이트에 연결된 모든 기능들 수행시켜 주는 역활을 함
            //델리게이트를 사용할 때 ? 많이 사용할 것임. 레벨업 안하는 애들도 걸리게 되면 터질 수 있으므로
            statChangeAction?.Invoke(level);
            statChangeAction(level);

        }

        //레벨에 따른 스텟 변화
        public void ChangePlayerHp(int level)
        {
            _hp += level * 10;
            Console.WriteLine("플레이어 체력" + _hp);
        }
        public void ChangePlayerAtt(int Changedlevel)
        {
            _att += Changedlevel * 2;
            Console.WriteLine("플레이어 체력" + _att);
        }
        public void ChangePlayerDef(int level)
        {
            _def += level * 5;
            Console.WriteLine("플레이어 체력" + _def);
        }
    }

    class UI
    {
        public static void PlayerLevelUpAlert(int val)
        {
            Console.WriteLine($"플레이어 레벨이 {val} 만큼 올랐습니다.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Delegate 체인: 하나가 아닌 여러 함수를 담아서 쓸 수 있음

            /*
            Player myPlayer = new Player();
            StatChange statChangeChain = UI.PlayerLevelUpAlert;
            statChangeChain += myPlayer.ChangePlayerHp;
            statChangeChain += myPlayer.ChangePlayerAtt;
            statChangeChain += myPlayer.ChangePlayerDef;
            
            
            //하나 바뀌어다고 수많음 함수들을 호출해야 하는 비효율적인 것.
            UI.PlayerLevelUpAlert(2);
            myPlayer.ChangePlayerHp(2);
            myPlayer.ChangePlayerAtt(2);
            myPlayer.ChangePlayerDef(2);

            Console.WriteLine("-------------------------");

            UI.PlayerLevelUpAlert(1);
            myPlayer.ChangePlayerHp(1);
            myPlayer.ChangePlayerAtt(1);
            myPlayer.ChangePlayerDef(1);
            

            statChangeChain(2);
            statChangeChain(2);
            //델리게이트는 수많은 메서드를 동시에 수행해야 할 때 유용하다.

            //필요 없는 건 중간에 뺄 수도 있다.
            statChangeChain -= myPlayer.ChangePlayerDef;
            statChangeChain(1);*/


            //지금 맵에 존해나는 모든 객체들의 Attack(플레이어 정보)
            Player myPlayer = new Player();
            myPlayer.LevelUp(1);
            myPlayer.LevelUp(1);
            myPlayer.LevelUp(1);
        }
    }
}


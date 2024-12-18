using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day19_Project_Assignment_4
{
    enum Shape
    {
        Spade,
        Heart,
        Clover,
        Diamond
    }
    class Card
    {
        Shape Shape;    //4가지의 문양
        int _cardNum;     //13까지의 숫자

        public Shape GetShap
        {
            get { return Shape; }
            set { Shape = value; }
        }
        public int GetNum
        {
            get { return _cardNum; }
            set { _cardNum = value; }
        }
    }

    class CardDeck
    {
        //Card 객체를 52개 담을 수 있는 ???(자료구조) 들을 활용하여 두 개 만드시되,
        //하나는 unusedCards, 하나는 usedCards 의 이름으로 만들겠습니다.
        public static Random random = new Random();
        List<Card> makeCard = new List<Card>();
        Stack<Card> unusedCards = new Stack<Card>();
        Stack<Card> usedCards = new Stack<Card>();

        public void MakeCard()
        {
            //List<Card>의 카드들을 다 만든다.
            for (int j = 0; j < Enum.GetValues(typeof(Shape)).Length; j++)
            {
                for (int i = 1; i < 14; i++)
                {
                    makeCard.Add(new Card { GetShap = (Shape)j, GetNum = i });
                }
            }
            //카드 셔플 함수 실행
            Shuffle(makeCard);

            //셔플된 makeCard리스트를 unusedCards스택에 다 푸쉬한다.
            foreach (Card card in makeCard)
            {
                unusedCards.Push(card);
            }
        }

        //리스트 카드들을 셔플한다
        public static List<Card> Shuffle(List<Card> cards)
        {
            for (int i = cards.Count - 1; i > 0; i--)
            {
                int j = random.Next(0, i + 1);

                Card temp = cards[i];   //i번째꺼 임시로 temp에 담아주고
                cards[i] = cards[j];  //j꺼를 i에 넣고
                cards[j] = temp;  
            }
            return cards;
        }

        //맨 위 카드 확인하기
        public void ShowTopCard()
        {
            Console.WriteLine($"카드의 모양은 {unusedCards.Peek().GetShap}\n카드의 숫자는 {unusedCards.Peek().GetNum}");
        }

        //카드를 드로우
        public void DrawCard()
        {
            Card card = unusedCards.Pop();
            usedCards.Push(card);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            CardDeck deck = new CardDeck();
            
            
            deck.MakeCard();
            
            
            deck.ShowTopCard();
            
            
            deck.DrawCard();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Day30_Project_Study
{
    internal class Program
    {
        /// <summary>
        /// 함수 및 메서드 내용 설명
        /// </summary>
        /// <param name="color"> 여기다가는 색깔 넣어주심 됩니다. </param>
        /// <returns> 이거 뭐뭐 연산한 결과 반환합니다. </returns>
        static int SetColor(string color)
        {
            int toReturn = 1;
            return toReturn;
        }


        static void Main(string[] args)
        {
            int.Parse("asd");
            SetColor("temp");

            //SOLID
            //S 단일 책임 원칙: 하나의 클래스는 하나의 책임을 가진다.
            //O 개방 폐쇄: 확장에 열여있다, 수정엔 닫혀있다.
            //L 리스코프 치환 원칙: 자식 클래스는 부모 클래스를 대처할 수 있어야 한다.
            //I 인터페이스 분리 원칙: 자신이 적용받은 인터페이스에 의존하지 않아야 함.
            //D 의존성 역전: 구체적인 것이 아닌, 추상적인 것에 의존해야 한다.

            //KISS(Keep It Simple, Stupid): 복잡한 것보다 단순한 것이 더 낫다
            //DRY(Don't Repeat Yourself): 중복 코드를 제거해 효율적으로 작성하라
            //YAGNI(You aren't gonna need it): 지금 필요하지 않은 건 만들지 말라


        }
    }
}

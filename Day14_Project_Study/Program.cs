using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Project_Study
{
    internal class Program
    {
        #region 여러가지 설명
        //객체지향 입문
        //구성 요소: 자동차, 바퀴, 엔진, 기어, 브레이크, 핸들, 피스톤, 나사
        //구성 기능: 전진, 후진, 좌회전, 우회전, 음향 변경, 워셔액, 라디오

        //프로그램에 필요한 요소와 기능들만 추려서 담는 것을 보고 "추상화" 라고 합니다.
        //"요소" + "기능" 만들어진 자료형이 바로 "클래스" 입니다.
        //위 자료형 클래스로 만들어진 실체화 결과물이 "객체" 입니다.

        //struct와 class 차이는 간단하게, 값타입이나 참조타입이냐
        //struct는 크기가 작고 간단한 객체를 정의할 때 사용. 클래스는 복잡
        #endregion

        // 값타입과 참조타입
        // 메모리 구조

        static void Main(string[] args)
        {
            #region 가비지 콜렉터 예시
            /*
            Car myCar = new Car();  //참조형들은 new할당을 해주어야 사용 가능하다.
            myCar._posX = 10;

            //가비지 콜렉터가 안쓰는 메모리 회수해감

            myCar = new Car();  //자동차 뉴할당 또했음.

            Console.WriteLine(myCar._posX); //x를 출력하면? 0이나옴. 
            */
            #endregion

            /*
            Car myCar = new Car();
            myCar._posX = 14;

            Car myCar2 = new Car(); //둘째 자동차 생성
            myCar2 = myCar;         //참조형은 그냥 주소를 복사한다.

            Console.WriteLine(myCar2._posX); //이번에는 뭐가 나올까요?

            //가비지콜렉터는 쓰지 않는 힙의 메모리를 회수한다
            //많이 돌면 렉걸린다.
            */

            #region 두번째
            /* 
            Car myCar = new Car();
            myCar.MoveForward(10); //자동차 10칸만큼 전진
            //MoveForward(자동차면, 인자값) //자동차를 들고와서 거기 속 x를 찾아 10을 전진

            myCar.SetCarNum(-10);   //다른 개발자들은 실수 할 수도 있음. 물론 본인도
            Console.WriteLine(myCar.GetCarNum());   //볼 수 있음
            */
            #endregion

            #region 여러가지 설명들
            //Stack
            //스택, 매개변수, 지역변수

            //Heap
            //큰 객체가 여기 잡힘
            //배열도 여기
            //"동적 할당"

            //Data, Code영역
            // 프로그램에 실행되는 코드는 Code영역. 끝
            // 전역변수나 Static등, 프로그램이 실행되는 동안 유지되는 메모리 공간
            #endregion

            /*
            Car mycar = new Car();
            mycar.PosX = 10;
            Console.WriteLine(mycar.PosX);

            mycar.MyName = "csd";
            Console.WriteLine(mycar.MyName);
            */

            #region 오늘 수업 요약
            //오늘 수업 요약
            //추상화: 필요한 것만 추려서 담아낸 것
            //클래스: 설계도
            //객체: 클래스 설계도를 바탕으로 나온 실체

            //클래스와 구조체 차이?
            //1. 클래스 참조, 구조체는 값타임
            //2. 클래스는 좀 크고 복잡하거나 현실 물체를 객체로 표현할 때
            //   구조체는 가볍고 적은 데이터로만. (값타입이라 크면 스택 터짐)

            // Stack, Heap (스택, 힙)
            // Stack: 값타임, 매개변수, 지역변수
            // Heap: 참조타입, 배열, 클래스로 만들어진 객체

            //가바지콜렉터: 쓰레기, 더 이상 참조되지 않는 힙의 메모리 공간

            //메소드: 클래스 내부에서 사용하는 함수, 객체가 쓸 기능들
            //필드: 클래스 내부 각종 요소들, 객체가 쓸 요소들
            //클래스 = 메소드와 필드가 합쳐져서 만들어진다

            //프로퍼티: 클래스 요소들을 안전하게 다루기 위해 제공되는 문법
            //정보은닉: 외부에 공개될 필요 없는 맴버변수를 숨긴다 
            #endregion

            #region Pet쪽 수업 내용
            //Pet myPet = new Pet();
            //myPet.PrintTierWithColor();
            #endregion
        }
    }
}

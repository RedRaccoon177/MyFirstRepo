using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14_Project_Study
{

    enum CarMake
    { 
        Audi, BMW, Kia
    }


    class Car
    {
        //요소
        int _posX;      //맴버변수 혹은 필드
        int _posY;      //맴버변수 혹은 필드
        float _maxSpeed;//맴버변수 혹은 필드
        int _carNumber;

        //기능(이제부터 Method, 메소드라고 부를거임)
        public void MoveForward(int posX)
        {
            _posX += posX;
            //혹은
            //this._posX += posX;
        }

        #region 두번째
        /*
        public int GetCarNum() //객체가 반환도 함
        {
            return _carNumber;
        }

        //외부에서 넘겨준 인자값으로 카넘버 세팅
        public void SetCarNum(int carNumber)
        {
            if (carNumber < 0)
            {
                _carNumber = 0;
            }
            else
            {
                _carNumber = carNumber;
            }
        }
        */
        #endregion


        //굳이 외부에 공개도리 필요 없는 맴버변수를 private로 숨기고,
        //외부에서 직접 접근하지 못하도록 숨기고 메서드를 통해서만 조작하게 하는 걸 "정보 은닉"이라고 합니다.

        // - 객체 내부 데이터 변경을 실수로부터 지킬 수 있음
        // 위 _PosX는 타인이 보기엔 차의 위치일수도, 혹은 주차장의 위치, 윈도우 크기x등 모릅니다.


        #region 프로퍼티 (속성)
        //프로퍼티는 외부에 노출될 필요가 없는 맴버변수들을 정보 은닉시켜줍니다
        //또한 외부와 소통할 일이 있을 때, 직접 맴버변수와 소통하는 것이 아닌 일종의 필터도 가능
        public int PosX
        {
            get                         //입력만 가능
            {
                return _posX;
            }
            set                         //보는 것만 가능
            {
                if (value > 1920)
                {
                    _posX = 1920;
                }
                else
                {
                    _posX = value;
                }
            }
        }
        #endregion

        //자동구현 프로퍼티
        public string MyName
        {
            get; set;
        }

        //클래스, 객체, 기능, 구현


    }
}

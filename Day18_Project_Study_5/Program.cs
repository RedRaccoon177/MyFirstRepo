using System;

namespace Day18_Project_Study_5
{
    //인터페이스와 제네릭
    
    //안드로이드 폰은 무조건 구글 아이디가 있어야 한다고 가정했을 때
    interface IAndroid
    {
        string GoogleID { get; } //프로퍼티 무조건 만들라고 강제할 수 있음
    }
    class Phone
    {

    }

    class Galaxy : Phone, IAndroid
    {
        string googleId;
        public string GoogleID 
        { 
            get 
            { 
                return googleId;
            }    
        }
    }
    class Xperia : Phone, IAndroid
    {
        string googleId;
        public string GoogleID
        {
            get
            {
                return googleId;
            }
        }
    }    
    class Pixel : Phone, IAndroid
    {
        string googleId;
        public string GoogleID
        {
            get
            {
                return googleId;
            }
        }
    }    
    class Iphone : Phone
    {
        string googleId;
        public string GoogleID
        {
            get
            {
                return googleId;
            }
        }
    }    

    class GooglePlay<T> where T : IAndroid
    {
        T phone;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
           GooglePlay<Galaxy> myAsset0 = new GooglePlay<Galaxy>();

           //GooglePlay<Iphone> myAsset1 = new GooglePlay<Iphone>();
        }
    }
}

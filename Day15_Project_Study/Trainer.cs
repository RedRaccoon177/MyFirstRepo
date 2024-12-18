using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day15_Project_Study
{
    partial class Trainer
    {
        //partial class


        int _level;
        string _nickname;
    
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

        public string Name
        {
            get
            {
                return _nickname;
            }
            set
            {
                _nickname = value;
            }
        }

        // 매개변수 디폴트 값. 아무것도 기입 안하면 자동으로 뭔가 들어가길 원할 때
        public Trainer(int lvl=1, string nickname = "레드")
        {
            Level=lvl;
            Name=nickname;
        }


    }
}

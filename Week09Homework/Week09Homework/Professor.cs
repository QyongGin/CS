using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09Homework
{
    class Professor
    {
        //[숙제]자동 구현 프로퍼티 get, set  만든다.
        private string _departmentCode;

        public string DepartmentCode
        {
            get; set;
        }
        
        //[숙제]일반 프로퍼티를 만든다, 단 get만 구현한다.
        private string _number;

        public string Number
        {
            get { return _number; }
        }

        private string _name;
        public string Name {
            get { return _name; }
            set { _name = value; }
        } 

        public override string ToString()
        {
            return $"[{Number}]{Name}";
        }

        //[숙제] 생성자 만들기
        //생성자의 매개별수로 사번, 이름, 학과코드를 받는다.

        public  Professor(string departmentcode,string number, string name)
        {
            DepartmentCode = departmentcode;
            Name = name;
            _number = name;
        }
    }
}

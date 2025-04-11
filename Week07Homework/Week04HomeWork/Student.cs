using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04HomeWork
{
    class Student // class는 인스턴스(자료형)을 만들기 위한 설계도
    {
        public string Number;
        public string Name;
        public DateTime BirthInfo; // Datetime 타입은 년 월 일 시 분 초를 모두 갖는 하나의 자료형.
        public string DepartmentCode;
        public string AdvisorNumber;
        public int Year;
        public string Class;
        public string RegStatus;
        public string Address;
        public string Contact;

        public override string ToString() {
            return $"[{this.Number}] {this.Name}"; //this -> self 와 같다. 나. default값.
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week09Homework
{
    //원래 정체:정수형
    enum YEAR
    {
        ONE=0,
        TWO,
        THREE,
        FOUR,

        END,
    }

    enum CLASS
    {
        A,
        B,
        C,
        END,
    }

    //[숙제] 재적상태 열거형으로 만들기
    //열거형 이름 :  REG_STATUS
    //항목이름 :  ENROLLED, GRADUATED, ONLEAVE, EXPELLED

    public enum REG_STATUS
    {
        ENROLLED,
        GRADUATED,
        ONLEAVE,
        EXPELLED
    }

    class Student {
        //static 필드
        public static Dictionary<YEAR, string> YearName = new Dictionary<YEAR, string>
          {
                { YEAR.ONE,   "1학년" },
                { YEAR.TWO,   "2학년" },
                { YEAR.THREE, "3학년" },
                { YEAR.FOUR,  "4학년(심화)" },
           };

        public static Dictionary<REG_STATUS, string> Reg_Status = new Dictionary<REG_STATUS, string>
          {
                { REG_STATUS.ENROLLED,   "재학" },
                { REG_STATUS.GRADUATED,   "졸업" },
                { REG_STATUS.ONLEAVE, "휴학" },
                { REG_STATUS.EXPELLED,  "퇴학" },
           };

        public string Number {get; private set;} //학번
        public string Name   {get; private set; } //이름

        public void SetName(string name)
        {
            Name = name;
        }
        public DateTime BirthInfo { get; private set; } //생년월일
        public void SetBirthInfo(int year, int month, int day)
        {
            BirthInfo = new DateTime(year, month, day);
        }
        public string DepartmentCode { get; set; } //학과코드
        public string AdvisorNumber { get; set; } //지도교수번호
        public YEAR Year { get; set; } // 학년
        public CLASS Class{get; set;}// 반

        //[숙제] string 대신 열거형 REG_STATUS를 타입으로 적용하기
        public REG_STATUS RegStatus { get; set; }

        public string Address  { get; set;}//주소

        public Student(string number, string name)
        {
            Number = number;
            Name = name;
        }
                              
        //연락처
        //자동 구현 프로퍼티
        //컴파일러가 __contact private 변수 생성
        //get,set을 구현
        public string Contact { get; set; }
       
        public override string ToString() {
            return $"[{this.Number}]{this.Name}";
        }
    }
}

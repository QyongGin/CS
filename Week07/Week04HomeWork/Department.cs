﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04HomeWork
{
    // default값 : Object -> Object 클래스를 상속한 Department 
    // class는 무조건 대문자로 시작
    class Department 
    {
       public string Code; // public -> default값이다. 어떤 Class에서도 접근 가능하다. 
       public string Name;

        // python의 __str__() 와 동일
        public override string ToString() { // 기본 값 수정. override / Department 자료형의 출력 정의
            return $"[{Code}] {Name}"; // 반환(return)을 안하면 오류.
        }
    }
}

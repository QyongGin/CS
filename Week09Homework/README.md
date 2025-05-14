# HomeWork Revise

### 프로퍼티 get ,set
```c#
// 자동 구현 프로퍼티 get, set
private string _departmentCode;
public string DepartmentCode
{
  get; set;
}
// 일반 프로퍼티 제작. get 구현
private string _number;
public string Number
{
    get { return _number; }
}
// 일반 프로퍼티 get, set 구현.
private string _name;
public string Name {
  get { return _name; }
  set { _name = value; }
}
// 생성자 생성. 매개변수는 사번, 이름 학과 코드.
public Professor(string departmentcode, string name, string number)
{
  DepartmentCode = departmentcode;
  Name = name;
  _number = number;
// _number는 set이 없어 외부에서 변경이 불가능하지만,
// class 내부에서는 직접 _number에 값을 할당할 수 있다.
}
// 기존 코드
professors.Add(new Professor() {
    DepartmentCode = departments[0].Code,
    Number = "2020001",
    Name = "김인하"
});
// 수정 코드
professors.Add(new Professor(departments[0].Code, "김인하", "2020001"));
```

### enum
- enum : 상수(constant)를 표현하기 위함. 상수 숫자 대신 의미있는 단어로 표현 가능.
- 각 요소 별도 지정 없으면 첫 요소 0 ,두 번째 요소 1처럼 1씩 증가된 값 할당.
- enum은 class안이나 namespace 내에서만 선언 가능.
- (int)'enumName' 로 int 캐스팅하면 enum의 숫자 값을 얻게 된다.
```c#
// 재적 상태 열거형으로 만들기
enum REG_STATUS
{
    ENROLLED,   // 입학
    GRADUATED,  // 졸업
    ONLEAVE,    // 휴학
    EXPELLED,   // 퇴학
    END,
// END, 로 끝내는 이유 -> 1. 범위의 끝을 명확하게 안다. -> y < YEAR.END 반복문 활용.
// 2. 값의 개수 표현 -> YEAR.END 값은 enum 항목 개수와 같다. int count = (int)YEAR.END
// 주의할 점 -> END는 실제 사용하지 않게 다룬다. 로직에 포함시키지 않는다. 
}
// string 대신 열거형 REG_STATUS 타입으로 적용
public REG_STATUS RegStatus { get; set; }
// 열거형인 REG_STATUS를 ComboBox에 추가하려면
// 문자열을 반환하는 Dictionary로 변환하는 과정 필요.
 public static Dictionary<REG_STATUS, string> Reg_Status = 
     new Dictionary<REG_STATUS, string>
   {
         { REG_STATUS.ENROLLED,   "입학" }, // index 0 
         { REG_STATUS.GRADUATED,   "졸업" },
         { REG_STATUS.ONLEAVE, "휴학" },
         { REG_STATUS.EXPELLED,  "퇴학" },
    };
// 항목을 comboBox에 반복문을 통하여 추가.
for (int i = 0; i < (int)REG_STATUS.END; i++)
{
    cmbRegStatus.Items.Add(Student.Reg_Status[(REG_STATUS)i]);
}
```

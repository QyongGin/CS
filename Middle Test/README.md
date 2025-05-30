### ContainsKey()
- Dictionary<key,value>에 지정한 키()가 포함됐는지 여부 확인
예시
```c#
  private Student SearchStudentByNumber(string number) // textbox에 입력한 내용 
{
    if (students.ContainsKey(number)) // 키 포함 여부 확인
    {
        return students[number];
        // 딕셔너리의 키를 반환하여 그에 해당하는 값 Value를 리턴한다.  
        // 즉, 호출한 곳은 students 배열의 Student 객체를 받게 된다.
        // 받은 곳은 lblTestName.Text = selectedStudent.Name; 받은 객체 토대로 나머지 정보 작성.
    }
    else
    {
        return null;
    }
}
```
### 소수점 출력 정하기
- ``.ToString("F1")``소수점 한 자리 0.() 까지 반올림하여 문자열로 변환.
- ``.ToString("0.0")``자리수와 함께 0까지 채운다.

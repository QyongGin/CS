## try-catch의 목적
- 예외 Exception가 발생할 수 있는 코드를 안전하게 처리하기 위해 사용한다.
- 프로그램 중단되지 않도록 예외상황을 붙잡아서 처리.
- 예외 발생시 사용자에게 알림을 주거나 로그를 남기거나 대체 동작을 수행할 수 있다.
### 사용하는 시기
- 파일 입출력
  - 파일 없거나, 권한 없거나, 디스크 꽉 차는 등 다양한 예외 발생.
  - 고로, 파일을 열거나 읽고 쓸 때 try-catch로 감싸는 게 안전.
- 네트워크 통신
- 형변환, 파싱
- 배열/리스트 인덱스 접근
- 외부 라이브러리 호출
```c#
// 예시
try
{
    // 예외가 발생할 수 있는 코드
    using (var fs = new FileStream("test.txt", FileMode.Open)) // 호출한 객체 실행후 자동 cloase() 호출 
    {
        // 파일 읽기/쓰기
    }
}
catch (Exception ex)
{
    // 예외 발생 시 처리
    MessageBox.Show("파일을 열 수 없습니다: " + ex.Message);
}
```

### 학생정보 등록 시 파일 입력

```c#
private void RegisterStudent()
{ ...
SaveInfo(student, StudentFullFileName); // student는 Studnet 타입이지만 IFile을 구현하므로 매개변수로 전달 가능
}

private void SaveInfo(IFile data, string fileName) // 인터페이스 IFile을 구현한 객체 매개변수로 받음. fileName은 저장할 파일명  
{
    try
    {
        using (var fs = new FileStream(fileName, FileMode.Append)) // fs에 FileStream 타입 finleName 이름의 파일 FileMode.Append 지정한 파일의 끝 부분에 추가한다. 
        {
            using (var sw = new StreamWriter(fs)) // StreamWriter 파일 쓰기 
            {
                sw.WriteLine(data.Record); // WriteLine 줄 단위 작성 data는 IFile을 구현한 Student. Student 클래스의 Record 내용 작성
            }
        } //닫고
    }
    catch (Exception ex)
    {
        MessageBox.Show(ex.Message);
    }
}

# Student class 
public string Record
{
    get { return $"{Number}|{Name}|{Dept.Code}|{BirthInfo:yyyy,MM,dd}|{AdvisorNumber}|{Year}|{(int)Class}|{(int)RegStatus}|{Address}|{Contact}"; }
}
```

# 과제
### 숙제1 : 파일처리 추가
이번 주 성적처리(TEST)의 정보를 학번별로 파일에 저장하기
파일위치는 c:\class_{X}\scores\{학번}.txt
파일 구성 형태 및 필요한 기능은 각자 구현해보기

```c#
private string CreateInfo(IFile student)
{
    // Student 타입으로 캐스팅
    var stu = student as Student;
    if (stu == null)
        throw new ArgumentException("student는 Student 타입이어야 합니다.");

    // 반 정보와 학번 추출
    string className = stu.Class.ToString(); // 예: "A", "B", "C"
    string number = stu.Number; // 학번

    // 폴더 경로 생성
    string tpath = $@"c:\class_{className}\scores";
    if (!Directory.Exists(tpath))
    {
        Directory.CreateDirectory(tpath);
    }

    // 파일 전체 경로 생성
    string filePath = Path.Combine(tpath, $"{number}.txt");

    // 파일이 없으면 생성(빈 파일)
    if (!File.Exists(filePath))
    {
        File.Create(filePath).Close();
    }

    return filePath;
}
```


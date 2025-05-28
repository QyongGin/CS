# 핵심 코드

### 파일 경로 지정과 추가하기
```c#
public partial class FormManager : Form
{
    public string PATH    
    {
        get {
            var path = "c:\\class_c"; // 파일 지정
            if (false == Directory.Exists(path)) { // 파일 존재 확인 Directory 폴더 .Exosts() 존재여부 
                Directory.CreateDirectory(path); // createDirectory()  폴더 생성
            }
            return path;
        }
    }

    public string DepartmentFullFileName
    {
        get {
            return Path.Combine(PATH, "department.txt"); // Path.Combine OS에 맞는 형식으로 결합. PATH 경로에 deaprtment.txt 생성.
        }
    }
```

### 이미 저장된, 존재하는 파일 불러오기.
```C#
 public FormManager()
 {
if (true == File.Exists(DepartmentFullFileName)) { // 파일이 있다면 
    //참고
    try { // 예외처리가 될 수 있는 코드
        // using문은 읽기전용, 지역 변수로 범위 끝에서 삭제된다.
        // 그런 원리로 파일을 자동으로 닫길 원하면 using을 사용하면 된다.
        // FileStream 파일입출력을 다루는 기본 클래스 
        using (var fs = new FileStream(DepartmentFullFileName, FileMode.Open)) { // 경로, 모드 지정
            using (var sr = new StreamReader(fs)) { // StreamReader 텍스트 읽고 저장.
                int deptIndex = 0;
                while (false == sr.EndOfStream) { // 끝까지 읽지 않았다면
                    var data = sr.ReadLine(); // 한 줄 읽고 문자열 반환.
                    //A001|컴퓨터정보
                    var dept = Department.Restore(data); // 읽은 문자열로 Department 객체로 만들어서 반환.
                    // A001 | 컴퓨터정보로 | 구분했으니 parse 파싱해서 Code = A001 Name = 컴퓨터정보 복원된다.
                    // 복구 Resotre : 저장된 문자열 데이터를 객체로 다시 만드는 클래스
                    if (dept != null && deptIndex < departments.Length) { // null 아니고 index가 departments 리스트 길이보다 작다면
                        departments[deptIndex++] = dept;  // index에 dept를 저장하고 index 1 증가
                        lbxDepartment.Items.Add(dept);  // 학과 목록에 추가.
                    }
                }
            }
        }
    } catch (Exception ex) { // 예외처리 발생 시 실행.
        MessageBox.Show(ex.ToString()); // 오류 메세지 출력
    }
}

//LINQ=array, collection + query...
//참고
// FirstOrDefault 조건을 만족하는 첫 번째 요소 찾아서 반환 없으면 null
// 각 항목 m이 null이 아니고 Code가 "A001"이면 반환.
// Code가 A001인 학과를 찾아서 Dept에 넣어라.
Dept = departments.FirstOrDefault(m => m != null && m.Code == "A001"), 

AdvisorNumber = "2020001",
Class = CLASS.B,
Address = "인천 남구 용현동 100",
Contact = "032-870-0000"
}
```

### 등록 버튼 누를 시 파일 저장 방법
```c#
private void btnRegisterDepartment_Click(object sender, EventArgs e)
{
    //참고
    try {
        //file - append
        // 열고
        // 추가하고
        // 닫고
        // Append 해당 파일이 있다면 파일의 끝까지 검색하거나 새 파일 생성. 주로 Write와 사용.
        using (var fs = new FileStream(DepartmentFullFileName, FileMode.Append)) {//열고
            using (var sw = new StreamWriter(fs)) { // writer
                sw.WriteLine(dept.Record); // 줄단위로 쓰기
                //추가하고
            }
        }//닫고
    } catch (Exception ex) {
        MessageBox.Show(ex.Message);
    }
}
        MessageBox.Show(ex.Message);
    }
}
}
```
### 삭제 버튼 누를 시 삭제 방법
```c# 
private void btnRemoveDepartment_Click(object sender, EventArgs e)
{
        try {
            using (var fs = new FileStream(DepartmentFullFileName, FileMode.Create)) {//열고
                using (var sw = new StreamWriter(fs)) {
                    foreach (var dept in departments) {
                        sw.WriteLine(dept.Record); // Record는 departments의 메소드
                      // Code | Name return 줄 작성
                    }
                }
            }
        } catch (NullReferenceException ex) // ex는 예외exception 객체 참조하기 위해 사용하는 변수 이름
                { // NullReferenceException null 객체 접근하려고 할 때 발생하는 예외.
                    Console.WriteLine("배열이 비었나봐" + ex.Message); // 속성 ex.message 예외 메시지 
                } catch (Exception ex)
                { // Exception 모든 예외의 기본 클래스. 처리하지 않은 다른 예외는 여기서 처리.
                    Console.WriteLine(ex); // 예외 전체 정보 출력
                } finally { // 예외 발생 여부 상관없이 항상 실행. 정리 작업, 리소스 해제, 마무리 출력등.
                    Console.WriteLine("파일삭제 처리 끝");
                }
    }
}

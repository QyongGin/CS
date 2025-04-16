using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week04HomeWork
{
    class Grade
    {
        // static field
        // class 들이 공통으로 들어가야할 정보. static 니네 다 과목 9개까지야.
        // 여러개만들면 여러개의 MAX값이 생성.
        // public static int MAX_GRADE_COUNT = 9; -> public 최대를 누구든 바꿀 수 있다.
        // private static int MAX_GRADE_COUNT = 9;
        // const = const + static
        public const int MAX_GRADE_COUNT = 9; // 값을 읽을 수는 있지만 바꾸지는 못한다. Form에서 Grade를 붙여서 불러온다. 

        // instance field
        // public 누구나 사용가능해서 막아야할 때가 많다.
        public string StudentNumber;
#if false
        public List<double> Scores = new List<double>();
#else
        // private _소문자 public 대문자
        // // public은 내가 제어못한다. private 프로그래머 실수 방지. 
        private List<double> _scores = new List<double>();

        // 원하는 정보 가공해서 줄 때 메소드, 감춘 정보를 보여줘야 할 때 메소드.
        public int Count() {
            return _scores.Count;
        }

        public double Get(int i) {
            return _scores[i]; // score 범위 벗어났을 때 항상 생각
        }

        public bool Add(double score) {

            // static은 class의 것이다. 굳이 붙이고 싶다면 this 대신, 클래스명인 Grade
            //if (_scores.Count >= this.MAX_GRADE_COUNT) {
            if (_scores.Count >= MAX_GRADE_COUNT) {
            return false;
            }
            _scores.Add(score);
            return true;
        }
#endif
        // 현재 사용되는 값을 구할 때는 method로
        // 계속 바뀌는 값은 저장이 아니라, 순간마다 계산된다.
        // instance method
        public double Average() {
#if false
            if(this.Scores.Count == 0) {
                return -1.0;
            }
            double sum = 0.0;
            foreach (var score in this.Scores) {
                sum += score;
            }
            return sum / Scores.Count;
        
#else
            if (this._scores.Count == 0) {
                return -1.0;
            }

            return _scores.Average();
            // return _scores.Sum() / _scores.Count;
#endif
        }

#if true
        public void Clear() {
            _scores.Clear();
        }
#endif 
    }
}

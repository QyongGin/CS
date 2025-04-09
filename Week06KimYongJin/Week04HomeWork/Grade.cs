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
        public static int MAX_GRADE_COUNT = 9;

        // instance field
        public string StudentNumber;
        public List<double> Scores = new List<double>();
    }
}

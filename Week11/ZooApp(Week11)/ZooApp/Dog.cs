using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
#if ONE
    class Dog
    {
        private string _name;
        private int _level;
        private COLOR _color;
        private int _year;

        public string Name
        {
            get { return _name; }
        }

        public COLOR Color
        {
            get { return _color; }
        }

        public int Level
        {
            get { return _level; }
        }

        public int Year
        {
            get { return _year; }
        }

        public Dog(string name, COLOR color, int year)
        {
            _name = name;
            _color = color;
            _year = year;
        }

        public override string ToString()
        {
            return $"DOG:{_name}";
        }

        public string Bark(int count)
        {
            StringBuilder bark = new StringBuilder();
            for(int i=0; i < count; i++) {
                bark.Append("왈!");
            }
            return bark.ToString();
        }
                
        private bool AddLevel(int level)
        {
            if (_level + level <= 100) {
                _level += level;
                return true;
            } else {
                _level = 100;
                return false;
            }
        }

        public void Eat()
        {
            AddLevel(3);   
        }

        public void Play()
        {
            AddLevel(2);
        }


    }
#elif TWO
class Dog : Animal
    {

        private int _year;

        public Dog(string name, COLOR color, int year)
            : base(name, color)
           
        {
            //_name = name;
            //_color = color;
            _year = year;
        }


        public override string ToString()
        {
            //return $"DOG:{_name}";
            //return $"DOG:{base._name}";
            return $"DOG:{Name}";
        }

        public string Bark(int count)
        {
            StringBuilder bark = new StringBuilder();
            for (int i = 0; i < count; i++) {
                bark.Append("왈!");
            }
            return bark.ToString();
        }
    }
#endif

#if THREE
    class Dog : Animal
    {

        private int _year;

        public Dog(string name, COLOR color, int year)
            : base(name, color)
           
        {
            //_name = name;
            //_color = color;
            _year = year;
        }


        public override string ToString()
        {
            //return $"DOG:{_name}";
            //return $"DOG:{base._name}";
            return $"DOG:{Name}";
        }

        public string Bark(int count)
        {
            StringBuilder bark = new StringBuilder();
            for (int i = 0; i < count; i++) {
                bark.Append("왈!");
            }
            return bark.ToString();
        }

        public override void Eat()
        {
            AddLevel(2);
        }

        public new void Play()
        {
            AddLevel(3);
        }
    }
#endif

#if FOUR

    class Dog : Animal
    {

        private int _year;

        public Dog(string name, COLOR color, int year)
            : base(name, color)
           
        {
            //_name = name;
            //_color = color;
            _year = year;
        }


        public override string ToString()
        {
            //return $"DOG:{_name}";
            //return $"DOG:{base._name}";
            return $"DOG:{Name}";
        }

        public string Bark(int count)
        {
            StringBuilder bark = new StringBuilder();
            for (int i = 0; i < count; i++) {
                bark.Append("왈!");
            }
            return bark.ToString();
        }

        public override void Eat()
        {
            AddLevel(2);
        }

        public new void Play()
        {
            AddLevel(3);
        }

        protected override bool AddLevel(int level)
        {
            if (_level + level <= 100) {
                _level += level;
                return true;
            } else {
                _level = 100;
                return false;
            }
        }
    }
#endif
    class Dog : Animal
    {
        //아래 두개는 부모 것을 접근 못해서
        //그대로 사용해도 문제 없음.
        //private string _name;
        //private int _level;

        //아래 한 개는 부모 것에 접근 할 수 
        //있지만 나만의 것을 만들 때 쓰는 경우
        //private new COLOR _color;

        //부모에도 없는 것
        private int _year;

        //나중에 한번 주석을 풀어서 이해를 해보세요.

        // 상속받은 필드들. 클래스 내부에 있지 않기 때문에 보호 수준에 못 미쳐 return하지 못한다.
        //public string Name { get { return _name; } }
        //public int Level { get { return _level; } }
        //public COLOR Color { get { return _color; } }
        public int Year { get { return _year; } }

        // : base 부모 클래스의 생성자에 넘긴다.
        public Dog(string name, COLOR color, int year)
            //: base() //기본 base()생성자
            : base(name, color)
        {
            _year = year;
        }

        //Object 클래스의 ToString()을
        //override(재정의)한다.
        public override string ToString()
        {
            return $"DOG:{Name}";
        }

        public string Bark(int count)
        {
            string retValue = "";
            for (int i = 0; i < count; i++) {
                retValue += "왈!";
            }
            return retValue;
        }

        

        protected override bool AddLevel(int level)
        {
            if (_level + level <= 100) {
                _level += level;
                return true;
            } else {
                _level = 100;
                return false;
            }
        }
    }
}

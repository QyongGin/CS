using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class Cat : Animal
    {

        // Animal에게 상속받은 필드들. 
        //private string _name;   // 이름
        //private int _level;     // 레벨
        //private COLOR _color;   // COLOR 컬러

        //// Name Level Color return
        //public string Name { get { return _name; } } 
        //public int Level { get { return _level; } }
        //public COLOR Color { get { return _color; } }

        // 생성자 Cat -> name color 매개변수
        // 바디({}) 는 c#의 생성자에서 무조건 필요하다.
        public Cat(string name, COLOR color) : base(name, color)
        {

        }

        //Object 클래스의 ToString()을
        //override(재정의)한다.
        //Aniaml에서 _name 값을 return해주는 Name 사용.
        public override string ToString()
        {
            return $"CAT:{Name}";
        }

        // 매개변수 값에 따라 "냥!"을 출력하는 함수
        public string Meow(int count)
        {
            string retValue = "";
            for (int i = 0; i < count; i++) {
                retValue += "냥!";
            }
            return retValue;
        }

        // 현재 _level에 매개변수로 추가하는 level을 더해도 100이하라면
        // _level에 더하고 true. 넘는다면 최대치 100 설정 false 반환.

        // Animal 클래스에서 상속된 추상 멤버 AddLevel 구현
        // 숙제 최대 level 200.

        // 부모 클래스인 Animal에서 protected로 선언하여 상속받은 자식클래스만 사용하게끔 제한을 줬다.
        protected override bool AddLevel(int level)
        {
            if (_level + level <= 200)
            {
                _level += level;
                return true;
            }
            else
            {
                _level = 200;
                return false;
            }
        }

        // Eat 3레벨 Play 2레벨
        public override void Eat() 
        {
            AddLevel(300);
        }

        public new void Play()
        {
            AddLevel(200);
        }

        
    }
}

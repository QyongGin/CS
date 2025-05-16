using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooApp
{
    class RobotBird : Animal,IRobot // IRobot을 상속받는다.
    {
        //protected int _level;
        //protected COLOR _color;
        int _batteryLevel;
        private int _year;
        
        public int Year
        {
            get { return _year; }
        }

        // Animal에서 상속받은 생성자 반드시 구현.
        public RobotBird(string name, COLOR color, int year) : base(name, color)
        {
            _year = year;
        }

        // 모든 클래스에 주어지는 ToString을 override한다. 
        // 부모 클래스에서 상속받은 Name 메서드 이용.
        public override string ToString()
        {
            return $"ROBOTBIRD{Name}";
        }


        // 인터페이스인 IRobot에서 상속받은 int BatteryLevel { get; set; }은 반드시 구현해야 한다.
        public int BatteryLevel 
        { 
           get { return _batteryLevel; }
           set {
                // 배터리 최대값은 1000
                if (value > 1000)
                {
                    _batteryLevel = 1000;
                }
                else // 1000만 안넘으면 입력한 그대로 등록.
                {
                    _batteryLevel = value;
                }
            }
        }

        // Charge()도 마찬가지로 인터페이스에서 상속받은 요소로 반드시 구현해야한다.
        // 충전하면 배터리 최대치가 된다.
        public void Charge()
        {
            BatteryLevel = 1000;
        }

        // bool 타입이기 때문에 무조건 true와 false를 반환한다.
        protected override bool AddLevel(int level)
        {
            if (_level + level <= 50)
            {
                _level += level;
                return true;
            }
            else
            {
                _level = 50;
                return false;
            }
        }

        public string Fly(int count)
        {
            string fly = "";
            for (int i=0; i < count; i++)
            {
                fly += "푸드득~";                
            }
            return fly;
        }
    }
}

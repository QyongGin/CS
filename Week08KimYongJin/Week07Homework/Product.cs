using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week07Homework
{
    class Product
    {
        // instance field
        public string Code;
        public string Name;
        public int Price;
        public int Stock;
        public DateTime RegDate;

        // instance method
        public override string ToString() // ToString()은 이미 존재하는 함수로 반환하는 값이 따로있기에 override를 변경해야 한다.
        {
            return $"[{Code}] {Name}"; //  format 대신 $심볼. 
        }
        public int SalePrice()
        {
            // if (DateTime.Now-RegDate > 30 ) 이렇게 하면 DateTime은 TimeSpan이 결과타입이고 비교 대상은 int다. 식이 성립되지 않음.
            // 그렇다면 Datetime의 double속성인 TotalDays를 사용해서 비교한다.
            if ((DateTime.Now-RegDate).TotalDays > 30 )
            {
                // 20% 할인된 가격을 반환해야한다 -> * 0.8. Price를 수정하는게 아니다.
                return (int)(Price * 0.8);
            }
            else
            {
                return Price;
            }
        }

        public int CalPrice(int count) // 함수를 부르며 개수를 입력.
        {
            if ((DateTime.Now - RegDate).TotalDays > 30)
            {
                return count * SalePrice();
            }
            else
            {
                return count * Price;
            }
        }

        
            
    }
}

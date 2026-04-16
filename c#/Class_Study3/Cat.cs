using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Study3
{
    // 상속 받는 형태
    internal class Cat : Animal  // class 자식_클래스_이름 : 부모_클래스_이름
    {
        public string Bell { get; set; }
        public Cat(string name, int legs, string bell) : base(name, legs)
        // 부모에서 생성되는 생성자를 따라가며 앞쪽에는 자식의 생성자 : 부모의 생성자 / base()
        {
            Bell = bell;
        }

        public string Mew()
        {
            return $"{Name} 애오애옹ㅇ {Bell}이 달랑달랑";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Study3
{
    internal class Animal
    {
        protected string Name { get; set; }
        protected int Legs { get; set; }

        public Animal(string name, int legs)
        {
            Name = name;
            Legs = legs;
        }

        public string Property()
        {
            return  $"이 동물은 다리가 {Legs}개 있습니다";
        }
        public string Speak()
        {
            return "동물이 소리를 냅니다";
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test4
{
    internal class SignalTower
    {
        protected bool Power {  get; set; }
        public SignalTower(bool power) 
        {
            Power = power;
        }
    }
}

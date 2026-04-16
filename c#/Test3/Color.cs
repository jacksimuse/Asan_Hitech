using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using test4;

namespace test4
{
    internal class Red : SignalTower
    {
        bool IsTurn { get; set; }
        public Red(bool power, bool isTurn) : base(power)
        {
            IsTurn = isTurn;
        }

        public string TurnON_OFF()
        {
            if (IsTurn)
            {
                return "불이 들어 왔습니다";
            }

            return "불이 안들어 왔습니다";
        }
    }
}

internal class Yellow : SignalTower
{
    bool IsTurn { get; set; }
    public Yellow(bool power, bool isTurn) : base(power)
    {
        IsTurn = isTurn;
    }

    public string TurnON_OFF()
    {
        if (IsTurn)
        {
            return "불이 들어 왔습니다";
        }

        return "불이 안들어 왔습니다";
    }
}

internal class Green : SignalTower
{
    bool IsTurn { get; set; }
    public Green(bool power, bool isTurn) : base(power)
    {
        IsTurn = isTurn;
    }

    public string TurnON_OFF()
    {
        if (IsTurn)
        {
            return "불이 들어 왔습니다";
        }

        return "불이 안들어 왔습니다";
    }
}

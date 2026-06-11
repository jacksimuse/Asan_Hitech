namespace PCB_PLC
{
    public class SignalTower : Actuator
    {
        public byte RedOutputBit { get; }
        public byte YellowOutputBit { get; }
        public byte GreenOutputBit { get; }

        public SignalTower(string name, byte redOutputBit, byte yellowOutputBit, byte greenOutputBit)
            : base(name)
        {
            RedOutputBit = redOutputBit;
            YellowOutputBit = yellowOutputBit;
            GreenOutputBit = greenOutputBit;
        }

        public bool IsRedOn()
        {
            return IO.ReadOutput(RedOutputBit);
        }

        public bool IsYellowOn()
        {
            return IO.ReadOutput(YellowOutputBit);
        }

        public bool IsGreenOn()
        {
            return IO.ReadOutput(GreenOutputBit);
        }

        public void SetRed(bool state)
        {
            IO.WriteOutput(RedOutputBit, state);
        }

        public void SetYellow(bool state)
        {
            IO.WriteOutput(YellowOutputBit, state);
        }

        public void SetGreen(bool state)
        {
            IO.WriteOutput(GreenOutputBit, state);
        }

        public void ToggleRed()
        {
            SetRed(!IsRedOn());
        }

        public void ToggleYellow()
        {
            SetYellow(!IsYellowOn());
        }

        public void ToggleGreen()
        {
            SetGreen(!IsGreenOn());
        }
    }
}

namespace PCB_PLC
{
    public class SingleCylinder : Actuator
    {
        public byte FwdInputBit { get; }
        public byte BwdInputBit { get; }
        public byte OutputBit { get; }

        public SingleCylinder(string name, byte fwdInputBit, byte bwdInputBit, byte outputBit)
            : base(name)
        {
            FwdInputBit = fwdInputBit;
            BwdInputBit = bwdInputBit;
            OutputBit = outputBit;
        }

        public bool IsFwd()
        {
            return IO.ReadInput(FwdInputBit);
        }

        public bool IsBwd()
        {
            return IO.ReadInput(BwdInputBit);
        }

        public void MoveFwd()
        {
            if (IsBwd())
            {
                IO.WriteOutput(OutputBit, true);
            }
        }

        public void MoveBwd()
        {
            if (IsFwd())
            {
                IO.WriteOutput(OutputBit, false);
            }
        }

        public void SetOutput(bool state)
        {
            IO.WriteOutput(OutputBit, state);
        }
    }
}

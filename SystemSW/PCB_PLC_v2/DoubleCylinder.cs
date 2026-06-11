namespace PCB_PLC
{
    public class DoubleCylinder : Actuator
    {
        public byte FwdInputBit { get; }
        public byte BwdInputBit { get; }
        public byte FwdOutputBit { get; }
        public byte BwdOutputBit { get; }

        public DoubleCylinder(string name, byte fwdInputBit, byte bwdInputBit, byte fwdOutputBit, byte bwdOutputBit)
            : base(name)
        {
            FwdInputBit = fwdInputBit;
            BwdInputBit = bwdInputBit;
            FwdOutputBit = fwdOutputBit;
            BwdOutputBit = bwdOutputBit;
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
                IO.WriteOutput(FwdOutputBit, true);
                IO.WriteOutput(BwdOutputBit, false);
            }
        }

        public void MoveBwd()
        {
            if (IsFwd())
            {
                IO.WriteOutput(FwdOutputBit, false);
                IO.WriteOutput(BwdOutputBit, true);
            }
        }

        public void SetOutput(bool fwdState, bool bwdState)
        {
            IO.WriteOutput(FwdOutputBit, fwdState);
            IO.WriteOutput(BwdOutputBit, bwdState);
        }
    }
}

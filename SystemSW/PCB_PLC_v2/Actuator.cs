namespace PCB_PLC
{
    public abstract class Actuator
    {
        public string Name { get; protected set; }

        protected Actuator(string name)
        {
            Name = name;
        }
    }
}

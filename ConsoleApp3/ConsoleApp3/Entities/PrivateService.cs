namespace Action.Entities
{
    internal class PrivateService
    {
        public string Name { get; set; }
        public double Value { get; set; }

        public PrivateService(string name, double value)
        {
            Name = name;
            Value = value;
        }
    }
}

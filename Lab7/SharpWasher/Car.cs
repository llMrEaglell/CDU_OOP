namespace SharpWasher
{
    public class Car
    {
        public Car(string name)
        {
            this.name = name;
            this.clean = false;
        }
        public string name { get; set; }
        public bool clean { get; set; }
    }
}
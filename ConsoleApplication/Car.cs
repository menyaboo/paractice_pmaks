namespace ConsoleApplication
{
    public class Car
    {
        public string Name { get; set; }
        public double Speed { get; set; }
        public double DistanceL { get; set; }

        public Car(string name, double speed, double distanceL)
        {
            Name = name;
            Speed = speed;
            DistanceL = distanceL;
        }
    }
}
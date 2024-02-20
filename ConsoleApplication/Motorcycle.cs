namespace ConsoleApplication
{
    public class Motorcycle
    {
        public string Name { get; set; }
        public double Speed { get; set; }
        public double DistanceS { get; set; }

        public Motorcycle(string name, double speed, double distanceS)
        {
            Name = name;
            Speed = speed;
            DistanceS = distanceS;
        }
    }
}
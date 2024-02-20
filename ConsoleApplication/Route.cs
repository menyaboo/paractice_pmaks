namespace ConsoleApplication
{
    public class Route
    {
        public double DistanceAB { get; set; }
        public double DistanceBC { get; set; }

        public Route(double distanceAB, double distanceBC)
        {
            DistanceAB = distanceAB;
            DistanceBC = distanceBC;
        }

        public double TotalDistance()
        {
            return DistanceAB + DistanceBC;
        }
    }
}
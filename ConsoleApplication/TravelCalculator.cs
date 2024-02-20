namespace ConsoleApplication
{
    public class TravelCalculator
    {
        public string WhoArrivesFirst(Car car, Motorcycle motorcycle)
        {
            double timeCar = (car.DistanceL + motorcycle.DistanceS) / car.Speed;
            double timeMotorcycle = motorcycle.DistanceS / motorcycle.Speed;

            if (timeCar > timeMotorcycle)
            {
                return $"Мотоцикл {motorcycle.Name} приедет раньше";
            }
            else if (timeCar < timeMotorcycle)
            {
                return $"Автомобиль {car.Name} приедет раньше";
            }
            else
            {
                return "Они приедут одновременно";
            }
        }
    }
}
using System;

namespace ConsoleApplication
{
    internal abstract class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Введите название автомобиля:\t");
            string carName = Console.ReadLine();

            Console.Write("Введите расстояние от A до С:\t");
            double distanceAB = double.Parse(Console.ReadLine());
            
            Console.Write("Введите скорость автомобиля от A до C:\t");
            double speedCar = double.Parse(Console.ReadLine());
            
            Console.Clear();
            
            Console.Write("Введите название мотоцикла:\t");
            string motorcycleName = Console.ReadLine();

            Console.Write("Введите расстояние от B до C:\t");
            double distanceBC = double.Parse(Console.ReadLine());
            
            Console.Write("Введите скорость мотоцикла от B до C:\t");
            double speedMotorcycle = double.Parse(Console.ReadLine());
            
            Console.Clear();

            // Создаем автомобиль и мотоцикл с введенными расстояниями
            Car car = new Car(carName, speedCar, distanceAB);
            Motorcycle motorcycle = new Motorcycle(motorcycleName, speedMotorcycle, distanceBC);

            // Действие (Act)
            TravelCalculator calculator = new TravelCalculator();
            string result = calculator.WhoArrivesFirst(car, motorcycle);
            Console.WriteLine(result);
        }
    }
}
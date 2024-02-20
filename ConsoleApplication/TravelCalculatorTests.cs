using NUnit.Framework;

namespace ConsoleApplication
{
    [TestFixture]
    public class TravelCalculatorTests
    {
        [Test]
        // Проверяем, что автомобиль приедет раньше, когда он выезжает из A в C
        public void TestCarArrivesFirst()
        {
            // Подготовка (Arrange)
            double distanceL = 50; // Расстояние от A до B
            double distanceS = 150; // Расстояние от B до C
            double speedCar = 100; // Скорость автомобиля от A до C
            double speedMotorcycle = 50; // Скорость мотоцикла от B до C
            string carName = "BMW"; // Название автомобиля
            string motorcycleName = "Harley Davidson"; // Название мотоцикла

            // Создаем автомобиль и мотоцикл с правильными расстояниями
            Car car = new Car(carName, speedCar, distanceL);
            Motorcycle motorcycle = new Motorcycle(motorcycleName, speedMotorcycle, distanceS);

            // Действие (Act)
            TravelCalculator calculator = new TravelCalculator();
            string result = calculator.WhoArrivesFirst(car, motorcycle);

            // Проверка (Assert)
            Assert.That(result, Is.EqualTo("Автомобиль BMW приедет раньше"));
        }

        [Test]
        // Проверяем, что мотоциклист приедет раньше, когда он выезжает из B в C
        public void TestMotorcycleArrivesFirst()
        {
            // Подготовка (Arrange)
            double distanceL = 100; // Расстояние от A до B
            double distanceS = 200; // Расстояние от B до C
            double speedCar = 100; // Скорость автомобиля от A до C
            double speedMotorcycle = 120; // Скорость мотоцикла от B до C
            string carName = "BMW"; // Название автомобиля
            string motorcycleName = "Harley Davidson"; // Название мотоцикла

            // Создаем автомобиль и мотоцикл с правильными расстояниями
            Car car = new Car(carName, speedCar, distanceL);
            Motorcycle motorcycle = new Motorcycle(motorcycleName, speedMotorcycle, distanceS);

            // Действие (Act)
            TravelCalculator calculator = new TravelCalculator();
            string result = calculator.WhoArrivesFirst(car, motorcycle);

            // Проверка (Assert)
            Assert.That(result, Is.EqualTo("Мотоциклист Harley Davidson приедет раньше"));
        }

        [Test]
        // Проверяем, что они приедут одновременно, когда они выезжают из A и B в C
        public void TestArriveTogether()
        {
            // Подготовка (Arrange)
            double distanceL = 100; // Расстояние от A до B
            double distanceS = 100; // Расстояние от B до C
            double speedCar = 200; // Скорость автомобиля от A до C
            double speedMotorcycle = 100; // Скорость мотоцикла от B до C
            string carName = "BMW"; // Название автомобиля
            string motorcycleName = "Harley Davidson"; // Название мотоцикла

            // Создаем автомобиль и мотоцикл с правильными расстояниями
            Car car = new Car(carName, speedCar, distanceL);
            Motorcycle motorcycle = new Motorcycle(motorcycleName, speedMotorcycle, distanceS);

            // Действие (Act)
            TravelCalculator calculator = new TravelCalculator();
            string result = calculator.WhoArrivesFirst(car, motorcycle);

            // Проверка (Assert)
            Assert.That(result, Is.EqualTo("Они приедут одновременно"));
        }
    }
}
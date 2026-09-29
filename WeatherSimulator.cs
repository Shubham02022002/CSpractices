namespace WeatherSimulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the number of days you want to simulate: ");

            if (!int.TryParse(Console.ReadLine(), out int days) || days <= 0)
            {
                Console.WriteLine("Please enter a valid positive number.");
                return;
            }

            string[] conditions =
            {
                "Sunny",
                "Rainy",
                "Foggy",
                "Cloudy",
                "Lightning"
            };

            double[] temperatures = new double[days];
            string[] actualWeather = new string[days];

            Random random = new Random();

            for (int i = 0; i < days; i++)
            {
                temperatures[i] = random.Next(-10, 40);
                actualWeather[i] = conditions[random.Next(conditions.Length)];
            }

            Console.WriteLine("\nWeather Simulation:");

            for (int i = 0; i < days; i++)
            {
                Console.WriteLine(
                    $"Day {i + 1}: {temperatures[i]}°C - {actualWeather[i]}"
                );
            }

            double avgTemp = Math.Round(AverageTemperature(temperatures),2);
            Console.WriteLine($"Maximum temperature during {days} is: {temperatures.Max()}");
            Console.WriteLine($"Minimum temperature during {days} is: {temperatures.Min()}");
            Console.WriteLine($"Average temperature during {days} is: {avgTemp}");
            Console.ReadKey();
        }

        static double AverageTemperature(double[] temperatures)
        {
            double avg = 0;
            double totalTemp = 0;
            for(int i = 0; i < temperatures.Length; i++)
            {
                totalTemp+= temperatures[i];
            }
            avg = totalTemp / temperatures.Length;
            return avg;
        }
    }
}

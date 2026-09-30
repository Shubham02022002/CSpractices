namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car audi = new Car("A4", "audi");
            audi.TopSpeed();
            Car bmw = new Car("m7", "bmw");
            bmw.TopSpeed();

            Customer c1 = new Customer("John", "john123@gmail.com", "90xxxxxxxxx", "Mars");

            Console.ReadKey();
        }
    }
   
}

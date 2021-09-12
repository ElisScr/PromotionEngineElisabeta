using System;

namespace PromotionEngine.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Promotion Engine");
            Console.WriteLine("First Scenario");
            Calculator calculator = new Calculator();
            int totalPriceScenario1= calculator
                .GetTotalPrice(new System.Collections.Generic.List<char> { 'A', 'B', 'C' });
            Console.WriteLine("Total: " +totalPriceScenario1);

            Console.WriteLine("Second Scenario");
            int totalPriceScenario2 = calculator
                .GetTotalPrice(new System.Collections.Generic.List<char> { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C' });
            Console.WriteLine("Total: " + totalPriceScenario2);

            Console.WriteLine("Third Scenario");
            int totalPriceScenario3 = calculator
                .GetTotalPrice(new System.Collections.Generic.List<char> { 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'D' });
            Console.WriteLine("Total: " + totalPriceScenario3);

            Console.ReadKey();
        }
    }
}

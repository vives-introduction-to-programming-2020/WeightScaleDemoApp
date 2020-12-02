using System;

namespace WeightScaleDemoApp
{
    class Program
    {
        public static double RequestWeight()
        {
            //double result = 0;
            //bool success;
            //do
            //{
            //    Console.Write("Please enter a weight in kg [ <= 0 to stop]: ");
            //    success = Double.TryParse(Console.ReadLine(), out result);
            //    if (!success)
            //    {
            //        Console.WriteLine("That is not a valid weight!");
            //    }
            //} while (!success);

            //return result;

            bool success = true;
            double result = 0;
            do
            {
                try
                {
                    Console.Write("Please enter a weight in kg [ <= 0 to stop]: ");
                    result = Convert.ToDouble(Console.ReadLine());
                    success = true; // Only if Convert does not throw exception
                }
                catch (FormatException fe)
                {
                    Console.WriteLine("That is not a valid weight!");
                    success = false;
                }
            } while (!success);

            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the scale app.");

            Scale scale = new Scale();

            //double weight = 0;
            //do
            //{
            //    weight = RequestWeight();
            //    if (weight > 0)
            //    {
            //        scale.AddElement(weight);
            //        Console.WriteLine($"Current total weight = {scale.TotalWeight()}");
            //    }
            //} while (weight > 0);

            double weight = RequestWeight();
            while (weight > 0)
            {
                scale.AddElementInKilogram(weight);
                Console.WriteLine($"Current total weight = {scale.TotalWeightInKilograms()} kg"
                    + $" or {scale.TotalWeightInPounds()} pounds");

                weight = RequestWeight();
            }

            Console.WriteLine("Thanks for using the scale app");
        }
    }
}

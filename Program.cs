using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = GetInfo("What is your name");
            string favoriteColor = GetInfo("What is your favorite color");
            string favoriteAnimal = GetInfo("What is your favorite animal");
            string favoriteBand = GetInfo("What is your favorite band?");
            OutputStory(name, favoriteColor, favoriteAnimal, favoriteBand);

            Console.WriteLine($"Calling Add(1, 3) Result: {Add(1, 3)}");
            Console.WriteLine($"Calling Add(3, 5, 6, 7) Result: {Add(3, 5, 6, 7)}");

            Console.WriteLine($"Calling Subtract(4, 2) Result: {Subtract(4, 2)}");
            Console.WriteLine($"Calling Subtract(34, 3, 10) Result: {Subtract(34, 3, 10)}");

            Console.WriteLine($"Calling Multiply(3, 4) Result: {Multiply(3, 4)}");
            Console.WriteLine($"Calling Multiply(6, 10, 2, 3) Result: {Multiply(6, 10, 2, 3)}");

            Console.WriteLine($"Calling Divide(35, 5) Result: {Divide(20, 4)}");
            Console.WriteLine($"Calling Divide(160, 4, 2) Result: {Divide(160, 4, 2)}");

            Console.WriteLine($"Calling Modulus(100, 3) Result: {Modulus(100, 3)}");
            Console.WriteLine($"Calling Modulus(80, 4) Result: {Modulus(80, 4)}");
        }

        private static int Add(params int[] addends)
        {
            int sum = 0;
            for (int i = 0; i < addends.Length; i++)
            {
                sum += addends[i];
            }
            return sum;
        }
        private static int Subtract(int minuend, params int[] subtrahends)
        {
            int difference = minuend;
            for (int i = 0; i < subtrahends.Length; i++)
            {
                difference -= subtrahends[i];
            }
            return difference;
        }

        private static int Multiply(params int[] factors)
        {
            int product = 1;
            for (int i = 0; i < factors.Length; i++)
            {
                product *= factors[i];
            }
            return product;
        }

        private static double Divide(double dividend, params double[] divisors)
        {
            double quotient = dividend;
            for (int i = 0; i < divisors.Length; i++)
            {
                quotient /= divisors[i];
            }
            return quotient;
        }

        private static int Modulus(int dividend, int divisor)
        {
            return dividend % divisor;
        }
        private static void OutputStory(string name, string favoriteColor, string favoriteAnimal, string favoriteBand)
        {
            Console.WriteLine();
            Console.WriteLine($"There once was a person named {name} whose favorite animal was the {favoriteAnimal}. This was mostly because their favorite band, {favoriteBand} had a {favoriteColor} {favoriteAnimal} on the cover of their latest album. Which is cool, I guess.");
            Console.WriteLine();
        }

        private static string GetInfo(string prompt)
        {
            Console.WriteLine(prompt);
            return Console.ReadLine();
        }
    }
}

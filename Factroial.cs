namespace Factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO ALGOS");
            Console.WriteLine("Please enter a non-negative integer: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("The Factorial of " + number + " is " + Factor(number));
            Console.ReadLine();
        }

        private static long Factor(int n) 
        {
            return n == 0 ? 1 : (long)n * Factor(n - 1);

            //can only handle upto 25 non-negative integers
        }
    }
}

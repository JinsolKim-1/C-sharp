namespace Hypotenuse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter side A: ");
            Double A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter side B: ");
            Double B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Side C is equals to: " + Math.Sqrt((Math.Pow(A, 2))+(Math.Pow(B,2))));
            

            Console.ReadLine();
        }
    }
}

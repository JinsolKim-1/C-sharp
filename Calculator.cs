namespace CalculatorProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String a = "Addition";
            String b = "Multiplication";
            String c = "Subtraction";
            String d = "Division";
              
            //User's input
            Console.WriteLine("Input First number: ");
            Double First = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("input Second number: ");
            Double Second = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("The following are the answers on each arithmetic operation: ");

            Console.WriteLine(a);
            Console.WriteLine(First + Second);

            Console.WriteLine(b);
            Console.WriteLine(First * Second);

            Console.WriteLine(c);
            Console.WriteLine(First - Second);

            Console.WriteLine(d);
            Console.WriteLine(First / Second);  
            
            
            Console.ReadLine();
        }
    }
}

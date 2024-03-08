namespace Biodata
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("BIODATA");

            Console.WriteLine("What is your name: ");
            string name = Console.ReadLine();
            
            Console.WriteLine("What is your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What is your height: ");
            double height = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your weight (kg): ");
            double weight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("What is your favorite symbol (!,@,#,$,%,&,*,?,^): ");
            Console.WriteLine("Choose only one");
            char symbol = Convert.ToChar(Console.ReadLine());
            
            
            Console.WriteLine("Your name is: " + name);
            Console.WriteLine(age + " years old");
            Console.WriteLine(height + " cm");
            Console.WriteLine(weight + " Kg");
            Console.WriteLine("Favorite symbol: " + symbol);

            Console.WriteLine("Press any key to Exit");
            Console.ReadKey();
        }
    }
}

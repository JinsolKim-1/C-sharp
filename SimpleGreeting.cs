namespace SimpleGreeting
{
    internal class Program
    {
        static void Main(string[] args)
        {
          
            Console.WriteLine("Type your name: " );
            String name = Console.ReadLine();

            Console.WriteLine("Type your age: " );
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello, " + name + "." + "Your age is: " + age);
            Console.WriteLine("\"WELCOME TO ALGOS\"");
            Console.WriteLine("Press ANY key to exit");

            Console.ReadLine();
            
        }
    }
}

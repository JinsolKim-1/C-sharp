namespace loop5Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int i = 1;
                Console.WriteLine(i);
            }
            Console.ReadLine();

            //ANSWER: Infinite loop since i = 1 is always true
        }
    }
}

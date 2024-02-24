namespace loop4Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int count = 2;
            while (i == 0)
            {
                count = count * 3;
                count = count * -1;

                Console.WriteLine(count);
            }
            Console.ReadLine();
        }       
    }  //ANSWER: will run forever since i will be forever zero
}

namespace loop3Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int j = 2;
            // if i < 100, then i = 1 ; j - 1
            // execute while loop
            // after executing while loop, i will be multiplied by 2
            for (int i = 1; i < 100; i = i * 2)
                // int i = 1,2,4,8,16,32,64
                //cannot be 128 since i will be greater than 100
            {
                j = j - 1;

                //while j < 25, then add 5 
                while (j < 25)
                {
                    j = j + 5;
                    // j = 6,10,14,18,22,26
                }
                Console.WriteLine(j);
                Console.ReadLine();
            }
            //ANSWER: for loop wil loop 7 times
            //BONUS : while loop will loop for 6 times
        }
    }
}

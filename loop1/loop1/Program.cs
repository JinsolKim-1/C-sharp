namespace loop1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // p declared = 2
            int p = 2;
            // if q < 32, then q = 2
            // before proceding to while loop
            // after executing while loop, q will be multiplied by 2
            for (int q = 2; q < 32; q = q * 2)
            {
                //p will multiplied by 2 if p is less than q
                while (p < q)
                {
                    p = p * 2;
                }

                q = p - q;
                Console.WriteLine(q);
            }
            //prevents terminal from closing
            Console.ReadLine();
        }
    }      //ANSWER: 8 loops before ending 
           //BONUS: p = p * 2 will execute 3 times 
}

namespace loop2Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //count is set to 5
            int count = 5;
            //while count is greater than 0, then loop
            while (count > 0)
            {
                count = count * 3;
                //makes count less than 0 so it will not loop forever
                count = count * -1;
            }
            Console.WriteLine(count);
            Console.ReadLine();
        }   
        //ANSWER: Ended in one loop
    }
}

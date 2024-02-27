namespace TrySome_things
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Practice in conditionals and loops
            TryAnIf();
            TryAnIfElse();
            TrySomeloops();
        }

        private static void TryAnIf()
        {
            int someValue = 5;
            string name ="Amadeus Jr. ";
            //if the someValue is 3 and the name is Mozart
            //then output - first console.WriteLine
            //else output - second console.WriteLine
            if ((someValue == 3) && (name == "Mozart"))
            {
                Console.WriteLine("x is 3 and the name is Mozart");
            }
            Console.WriteLine("This line runs no matter what");
            Console.ReadLine();
            //ANSWER: "This line runs no matter what"
        }

        private static void TryAnIfElse()
        {
            int x = 5;
            //if x = 10, print "x must be 10"
            //if x isn't equals to 10, print "x isn't 10"
            if (x == 10)
            {
                Console.WriteLine("x must be 10");
                Console.ReadLine();
            }
            else 
            {
                Console.WriteLine("x isn't 10");
                Console.ReadLine();
            }
            //ANSWER:"x isn't 10"
        }

        private static void TrySomeloops()
        {
            int count = 0;
            //while count value isn't greater than 10, continue looping
            //if count value is greater than 10, proceed to for loop
            while (count < 10) 
            {
                count = count + 1;
            }
            
            //if "i" is less than 5, then "count" - 1
            //after "count" deduction, "i" will gain + 1 due to "i++ (increment)"
            //continue looping until "i" is greater than 5
            for (int i = 0; i < 5; i++) 
            {
                count = count - 1;
            }
            Console.WriteLine("The answer is " + count);
            //ANSWER: "The answer is 5"
            Console.ReadLine();
        }
        
    }
}

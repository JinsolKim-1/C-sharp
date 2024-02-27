namespace GuessNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //This "while loop " is used to keep the game from closing
            while (true)
            {
                //Gives an array data range of 1 to 100
                var numbersArray = Enumerable.Range(0, 101).ToArray();
                //System will choose one random number in range 1-100
                Random rnd = new Random();
                int randomIndex = rnd.Next(numbersArray.Length);
                //Holds the random number that the system chose
                int PCselectedNumber = numbersArray[randomIndex];

                /*users attempt of guessing the number
                 * every wrong guess will add a tally*/
                int attempts = 0;

                Console.WriteLine("The System chose a random number from 1-100");

                /*This "while loop" keeps tally of a 
                 * number of attempts to guess the number*/
                while (true)
                {
                    Console.WriteLine("Input your guess (1-100) only: ");
                    //Converts your answer into "int32"
                    int myGuessNumber = Convert.ToInt32(Console.ReadLine());

                    /*if system's chosen number is greater than
                     * your chosen number, then print console.WriteLine
                     * and add +1 to attempt*/
                    //Vice Versa...
                    if (PCselectedNumber > myGuessNumber)
                    {
                        Console.WriteLine("The number is too low");
                        attempts++;

                    }
                    if (PCselectedNumber < myGuessNumber)
                    {
                        Console.WriteLine("The number is too high");
                        attempts++;

                    }
                    //if user guessed the number, then print congrats and the attempts
                    else if (PCselectedNumber == myGuessNumber)
                    {
                        Console.WriteLine("Congratualations! You got the Correct Number");
                        Console.WriteLine("Correct answer is: " + PCselectedNumber);
                        Console.WriteLine("Your attempts: " + attempts);
                        break;
                    }
                }

                //if the user wants to guess again, press y
                //else, quit program
                Console.WriteLine("Would you like to guess again? (y/n): ");
                if (Console.ReadLine().ToLower() != "y")
                
                //Terminates "while loop"
                break;
                
            }
        }
    }
}

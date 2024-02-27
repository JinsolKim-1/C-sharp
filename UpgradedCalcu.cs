using System.Xml.Serialization;

namespace Calculator
{
     
   internal class Program
   {
        static void Main(string[] args)
        {
            String a = "1. Addition";
            String b = "2. Multiplication";
            String c = "3. Subtraction";
            String d = "4. Division";
            int used;

            //User's input
            Console.WriteLine("Input First number: ");
            Double First = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("input Second number: ");
            Double Second = Convert.ToDouble(Console.ReadLine());

            //Arithmetic operation choices
            Console.WriteLine("Type (1~4) for arithmetic operation to be used: ");

            do
            {   //user choices
                Console.WriteLine(a);
                Console.WriteLine(b);
                Console.WriteLine(c);
                Console.WriteLine(d);

                string userInput = Console.ReadLine();

                //Try.parse = converting users input to int
                //out = to check if try.parse is successful in converting
                if (int.TryParse(userInput, out used))
                {
                    switch (used)
                    {   
                        //if user chose key 1
                        case 1:
                            Console.WriteLine(a);
                            Console.WriteLine("Answer is: " + First + Second);
                            break;

                        //if user chose key 2
                        case 2:
                            Console.WriteLine(b);
                            Console.WriteLine("Answer is: " + First * Second);
                            break;
                        
                        //if user chose key 3
                        case 3:
                            Console.WriteLine(c);
                            Console.WriteLine("Answer is: " + (First - Second));
                            break;

                        //if user chose key 4
                        case 4:
                            Console.WriteLine(d);
                            Console.WriteLine("Answer is: " + First / Second);
                            break;
                        //if user chose below 1 or higher than 4
                        default:
                            Console.WriteLine("INVALID NUMBER");
                            break;
                    }

                }
                else
                {
                    //if user pressed an alphabet
                    Console.WriteLine("please choose a number only ranging 1 to 4");
                }
              
              //if the user mistakenly pressed below 1 or higher than 4  
            } while (used is < 1 or > 3);

          //Exits the program
          Console.ReadLine();


        }
   }
    

}

namespace C_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. hypotenuse calculator program:

            //Console.WriteLine("Enter Side A");
            //double a = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Side B");
            //double b = Convert.ToDouble(Console.ReadLine());

            //double c = Math.Sqrt((a * a) + (b * b));

            //Console.WriteLine("The hypotenuse is " + c);

            // 2. number guessing game:

            Random random = new Random();

            int guess;
            int guessTime = 0;
            int answerNumber;
            bool isPlayAgain = true;
            String response;
            int min = 0;
            int max = 100;

            while (isPlayAgain)
            {
                answerNumber = random.Next(min, max + 1);
                guessTime = 0;

                while (true)
                {
                    Console.WriteLine("Enter your answer Number: ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    guessTime++;

                    if(guess > answerNumber)
                    {
                        Console.WriteLine("That is too High!!!");
                    }
                    else if(guess < answerNumber)
                    {
                        Console.WriteLine("That is too Low!!!");
                    }
                    else
                    {
                        break;
                    }
                }

                Console.WriteLine("Congratulations! You WIN!!! The answer is " + answerNumber);
                Console.WriteLine("You took " + guessTime + " times to Win!");

                Console.WriteLine("Would you like to play again (Y/N) ? ");
                response = Console.ReadLine();

                if (response.ToUpper() == "Y")
                {
                    isPlayAgain = true;
                }
                else if (response.ToUpper() == "N")
                {
                    isPlayAgain = false;
                }
            }

            Console.WriteLine("GoodBye!!!!!!!!");

        }
    }
}

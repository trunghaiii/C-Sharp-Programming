namespace C_Programming
{
    internal class Program
    {
        static void Main(string[] args)

        {
            //3. rock - paper - scissors game

            Random random = new Random();
            bool isPlayAgain = true;
            String player = "";
            String computer = "";
            String response = "";

            while (isPlayAgain)
            {
                player = "";
                while (player != "paper" && player != "rock" && player != "scissor")
                {
                    Console.WriteLine("Enter paper, rock or scissor: ");
                    player = Console.ReadLine().ToLower();
                }


                int randomNumber = random.Next(1, 4);

                switch (randomNumber)
                {
                    case 1:
                        computer = "paper";
                        break;
                    case 2:
                        computer = "rock";
                        break;
                    case 3:
                        computer = "scissor";
                        break;
                }

                Console.WriteLine("You Chose "+ player);
                Console.WriteLine("Computer chose "+ computer);

                switch (player)
                {
                    case "paper":
                        if(computer == "paper")
                        {
                            Console.WriteLine("That is a draw");
                        }
                        else if(computer == "rock")
                        {
                            Console.WriteLine("You Win");
                        }
                        else
                        {
                            Console.WriteLine("You Lose");
                        }
                        break;
                    case "rock":
                        if (computer == "paper")
                        {
                            Console.WriteLine("You Lose");
                        }
                        else if (computer == "rock")
                        {
                            Console.WriteLine("That is a draw");
                        }
                        else
                        {
                            Console.WriteLine("You Win");
                        }
                        break;
                    case "scissor":
                        if (computer == "paper")
                        {
                            Console.WriteLine("You Win");
                        }
                        else if (computer == "rock")
                        {
                            Console.WriteLine("You Lose");
                        }
                        else
                        {
                            Console.WriteLine("That is a Draw");
                        }
                        break;
                }

                Console.WriteLine("Do you want to play again(Y/N)?");
                response = Console.ReadLine().ToLower();

                if(response == "y")
                {
                    isPlayAgain = true;
                }
                else if(response == "n")
                {
                    isPlayAgain = false;
                }

            }

            Console.WriteLine("Good Bye");





            // 1. hypotenuse calculator program:

            //Console.WriteLine("Enter Side A");
            //double a = Convert.ToDouble(Console.ReadLine());

            //Console.WriteLine("Enter Side B");
            //double b = Convert.ToDouble(Console.ReadLine());

            //double c = Math.Sqrt((a * a) + (b * b));

            //Console.WriteLine("The hypotenuse is " + c);







            // 2. number guessing game:

            /* Random random = new Random();

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
 */
        }
    }
}

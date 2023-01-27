class Program
{
    /*
    Main
    Date: Jan 26, 2023
    last modified: Jan 26, 2023
    Method Name: Main
    Author: Jesse Arnold
    Purpose: This method is a game where 
    the user has 5 attempts to guess the
    randomly generated number
    */
    public static void Main(string[] args)
    {
        Random Rand = new Random();
        int randNum = Rand.Next(1, 11);
        int attempts = 0;
       
            Console.WriteLine("Welcome! You are trying to guess a random value between 1 - 10, you have 5 attempts");

            while (attempts != 5)
            {
                try
                {
                Console.WriteLine($"Attempts remaining: {5 - attempts}");
                Console.WriteLine("Please Enter A Number between 1 and 10");
                //user input
                int userGuess = Int32.Parse(Console.ReadLine()!);

                //these if's check for the correct answer and where the user is in relation to the random number
                //prob could have used a case switch here to save resources but it wouldn't work immediately and I'm impatient 
                if (userGuess > randNum)
                {
                    Console.WriteLine("The Number is lower than your guess");
                }//end if

                if (userGuess < randNum)
                {
                    Console.WriteLine("The Number is higher than your guess");
                }//end if 

                if (userGuess == randNum)
                {
                    Console.WriteLine("You got it");
                    break;
                }//end if 

                if (userGuess is > 10 or < 0)
                {
                    Console.WriteLine("and not a valid choice, you loose an attempt");
                }//end if


                attempts++;
                } //end try
                catch (Exception e)
                {
                    Console.WriteLine("Please Use a Valid Integer");
           
                } //end catch
            } //end while loop
    } //end main
} //end program
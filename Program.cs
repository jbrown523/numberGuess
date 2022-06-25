// See https://aka.ms/new-console-template for more information

// Uses top-level statements, no Main method written explicitly

getAppInfo();

getUserInfo();

// Play game until user closes app
while (true)
{
    // init random answer
    Random randomNum = new Random();
    int answer = randomNum.Next(10);

    // init user guess
    int guess = 0;


    Console.Write("Guess a number from 1-10: ");

    while (guess != answer)
    {
        // User input
        string input = Console.ReadLine();

        // Input must be a number
        if (!int.TryParse(input, out guess))
        {
            printMessege(ConsoleColor.Red, "Invalid entry, please enter a nubmer: ");

            // keep asking for guesses
            continue;
        }

        // Parese to int
        guess = Convert.ToInt32(input);

        // Incorrect guess messege
        if (guess != answer) { printMessege(ConsoleColor.Red, "Incorrect, please try again: "); }
    }
    // User guesses correclty, succes messege
    printMessege(ConsoleColor.Yellow, "Correct! Nice guessing! ");

    // Play again
    Console.WriteLine("Would you like to play again? {Y or N}. Any other input exits the game.. ");

    string continueAnswer = Console.ReadLine().ToUpper();

    if (continueAnswer == "Y") {
        continue;
    } else if (continueAnswer == "N") {
        return;
    } else { 
        return; }
}

static void getAppInfo()
{
    // Variables
    string appName = "Number Guesser";
    string appVersion = "version-1.0";
    string appAuthor = "Jalen";

    // Change text color
    Console.ForegroundColor = ConsoleColor.Green;

    // App info
    Console.WriteLine("Welcome to {0}: {1}, created by {2}", appName, appVersion, appAuthor);

    // Reset text color
    Console.ResetColor();
}

// User info & greet
static void getUserInfo()
{
    Console.Write("Name: ");
    string userName = Console.ReadLine();
    Console.WriteLine("Hey {0}, let's play a game.", userName);
}

// Output messege
static void printMessege(ConsoleColor color, string messege)
{
    Console.ForegroundColor = color;
    Console.Write(messege);
    Console.ResetColor();
}
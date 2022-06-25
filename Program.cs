// See https://aka.ms/new-console-template for more information

// Uses top-level statements, no Main method written explicitly

// Variables
string appName = "Number Guesser";
string appVersion = "version-1.0";
string appAuthor = "Jalen";

// Change text color
Console.ForegroundColor = ConsoleColor.Yellow;

// App info
Console.WriteLine("Welcome to {0}: {1}, created by {2}", appName, appVersion, appAuthor);

// Reset text color
Console.ResetColor();

// User info
Console.Write("Name: ");
string userName = Console.ReadLine();
Console.WriteLine("Hey {0}, let's play a game.", userName);


// init Correct answer
int answer = 9;

//init user guess
int guess = 0;


Console.Write("Guess a number from 1-10: ");

while (guess != answer)
{
    // User input
    string input = Console.ReadLine();

    // Check user input is number
    if(!int.TryParse(input, out guess))
    {
        Console.ForegroundColor=ConsoleColor.Red;
        Console.Write("Invalid input, please enter a nubmer: ");
        Console.ResetColor();

        // Keep going
        continue;
    }

    // Parese to int
    guess = Convert.ToInt32(input);

    if (guess != answer)
    {
        Console.ForegroundColor= ConsoleColor.Red;

        Console.WriteLine("Incorrect guess, try again");

        Console.ResetColor();

    }
}
// User guesses correclty, succes messege
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("Correct! The answer is {0}, nice guessing!", answer);
Console.ResetColor();
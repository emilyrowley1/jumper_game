public class Player
{
    public int livesLeft = 8; // Players current lives, starts with 8
    List<char> incorrectGuesses = new List<char>(); // List of all the guesses the user has made that are incorrect.

    public void wrongGuess(char guess)
    // Called if the players guess is incorrect. Takes away a guess and keeps track of incorrect guesses.
    {
        livesLeft -= 1;
        incorrectGuesses.Add(guess);
    }
    
    public char getGuess()
    // Gets the first character of whatever the user guesses.
    {
        Console.Write("Save the SkyDiver! Guess (a - z): ");
        return Console.ReadLine()[0];
    }

    public void displayAlreadyGuessed()
// Displays list of character the user has already guessed.
    {
        Console.WriteLine();
        Console.Write("Already guessed: ");
        foreach (char guess in incorrectGuesses)
        {
            Console.Write($"{guess}, ");
        }
        Console.WriteLine();
    }
}

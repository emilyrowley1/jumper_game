public class Player
{
    public int livesLeft = 8;

    public void looseLife()
    {
        livesLeft -= 1;
    }

    public string getGuess()
    {
        Console.WriteLine("Save the SkyDiver! Guess: ");
        
    }
}
// MEMBER VARIABLE: list of guesses
// METHOD: get guess
// METHOD: display previous guesses
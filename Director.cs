public class Director
{
    public void playGame()
    {
        // Creating a player, parachute, and a word.
        Player player = new Player(); 
        Parachute parachute = new Parachute();
        Word word = new Word();

        while (player.livesLeft > 0 && word.wordNotGuessed()) // keep playing while the player has lives the the word isn't guessed
        {
            player.displayAlreadyGuessed(); // Displays what has already been guessed
            parachute.displayParachute(player.livesLeft); // Displays the current parachute and person
            word.displayUnguessedWord(); // Display what the player knows about the word so far.
            char guess = player.getGuess(); // Gets the users guess

            if (word.guessInWord(guess)) // Determines if the guess was correct or not
            {
                word.updateUnguessedList(guess); // If it was the then the guess is displayed in the word
            }
            else
            {
                player.wrongGuess(guess); // If not then the user looses a life
            }

        } 

        parachute.displayParachute(player.livesLeft); // Displays the parachute
        
        if (player.livesLeft == 0) // If the player died...
        {
            Console.WriteLine("FREE FALL!!!!");
            Thread.Sleep(3000);
            Console.WriteLine("\nOpps... the parachute didn't work... :'(");
        }
        else // If the player won
        {
            Console.WriteLine($"Congrats, you saved the skydiver with {player.livesLeft} lives left! ");
        }

        Console.WriteLine($"\nThe word was {word.randomWord}."); // Tells the player what the word was
    }
}

public class Director
{
    public void playGame()
    {
        Player player1 = new Player();
        Parachute p = new Parachute();

        p.displayParachute(player1.livesLeft);
        player1.looseLife();
        Console.WriteLine();
        p.displayParachute(player1.livesLeft);
    }
}
// MEMBER VARIABLE: the word call word.getWord()
// get the word
// display jumper
// display word length
// get guess
// update word
// display previous guesses
// if not dead
// repeat

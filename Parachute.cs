public class Parachute
/// displayParachute
{   
    public void displayParachute(int livesLeft)
    // Displays the current parachute and person based on how many lives they have.
    {
        if (livesLeft >= 8)
        {
            Console.WriteLine("  ___  ");
        }
        if (livesLeft >= 5)
        {
            if (livesLeft >= 7)
            {
                Console.WriteLine(" /___\\  ");
            }
            else if (livesLeft >= 6)
            {
               Console.WriteLine(" /   \\  "); 
            }
            else
            {
                Console.WriteLine(" /      ");
            }
        }
        if (livesLeft >= 3)
        {
            if (livesLeft >= 4)
            {
                Console.WriteLine(" \\   /  ");
            }
            else
            {
               Console.WriteLine(" \\"); 
            }
        }
        if (livesLeft >= 1)
        {
            if (livesLeft >= 2)
            {
                Console.WriteLine("  \\ /  ");
            }
            else
            {
               Console.WriteLine(" \\"); 
            }
        }
        printPerson();
    }
    void printPerson()
    {
        Console.WriteLine("   0   ");
        Console.WriteLine("  /|\\   ");
        Console.WriteLine("  / \\  ");
    }

}

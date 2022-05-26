

public class Word
{
    string[] wordArray = {"sugar", "candy", "memphis", "cost", "phone", "crazy", "puppy", "tired", "ring", "picture", "carrot", "goldfish"}; // list of random words
    public string randomWord;
    List<string> letters = new List<string>(); //Random word put into a list for comparision purposes
    List<string> unguessed = new List<string>(); // What the user knows about the word at any given time.

    public Word()
    {
        randomWord = wordArray[new Random().Next(12)]; // Picking the random word
        populateLists();
    }

    void populateLists()
    // Puts the word and what the user knows about the word into two separate lists
    {
        foreach (char letter in randomWord)
        {
            unguessed.Add("_ ");
            letters.Add($"{letter}");
        }
    }
    public void displayUnguessedWord()
    // Displays what the user knows about the word so far.
    {
        foreach (string placeHolder in unguessed)
        {
            Console.Write(placeHolder);
        }
        Console.WriteLine();
    }

    public bool guessInWord(char guess)
    // Determines if the user guess was correct
    {
        if (randomWord.Contains(guess))
        {
            return true;
        }
        return false;
    }

    public void updateUnguessedList(char guess)
    // Updates what the user can see about the word based on their guess.
    {
        for (int i = 0; i < letters.Count; i++)
            {
                if (letters[i] == $"{guess}")
                {
                    unguessed[i] = letters[i] + " ";
                }
            }
    }
   
   public bool wordNotGuessed()
   {
       foreach (string item in unguessed)
       {
           if (item == "_ ")
           {
               return true;
           }
       }
        return false;
   }
}

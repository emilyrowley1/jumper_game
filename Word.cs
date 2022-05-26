

public class Word
{
    string[] wordArray = {"sugar", "candy", "memphis", "cost", "phone", "crazy", "puppy", "tired", "ring", "picture", "carrot", "goldfish"};
    public string randomWord;
    int wordLength;
    List<string> letters = new List<string>();
    List<string> unguessed = new List<string>();

    public Word()
    {
        int rnd = new Random().Next(12);
        randomWord = wordArray[rnd];
        wordLength = randomWord.Length;
        populateLists();
    }

    void populateLists()
    {
        foreach (char letter in randomWord)
        {
            unguessed.Add("_ ");
            letters.Add($"{letter}");
        }
    }
    public void displayUnguessedWord()
    {
        foreach (string placeHolder in unguessed)
        {
            Console.Write(placeHolder);
        }
        Console.WriteLine();
    }

    public bool guessInWord(string guess)
    {
        if (randomWord.Contains(guess))
        {
           for (int i = 0; i < letters.Count; i++)
            {
                if (letters[i] == guess)
                {
                    unguessed[i] = letters[i] + " ";
                }
            }
            return true;
        }
        return false;
    }
   
}
// MEMBER VARIABLE: array of words
// METHOD: get a random word from the array of words
// METHOD: display word/lines
// METHOD: update lines with letters


public class Word
{
    string[] wordArray = {"sugar", "candy", "memphis", "cost", "phone", "crazy", "puppy", "tired", "ring", "picture", "carrot", "goldfish"};
    public string randomWord;
    int wordLength;
    List<string> letters = new List<string>();

    public Word()
    {
        int rnd = new Random().Next(12);
        randomWord = wordArray[rnd];
        wordLength = randomWord.Length;
        populateLetterList();
    }

    void populateLetterList()
    {
        foreach (char letter in randomWord)
        {
            letters.Add("_ ");
        }
    }
    public void displayUnguessedWord()
    {
        foreach (string letter in letters)
        {
            Console.Write(letter);
        }
    }


   
}
// MEMBER VARIABLE: array of words
// METHOD: get a random word from the array of words
// METHOD: display word/lines
// METHOD: update lines with letters
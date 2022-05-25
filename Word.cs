

public class Word
{
    string[] wordArray = {"sugar", "candy", "memphis", "cost", "phone", "crazy", "puppy", "tired", "ring", "picture", "carrot", "goldfish"};
    int rnd = new Random().Next(12);
    public string randomWord;
    int wordLength;
    public string[] letters = {};

    public Word()
    {
        randomWord = wordArray[rnd];
        wordLength = randomWord.Length;
    }

    public void displayUnguessedWord()
    {
        Console.WriteLine(wordLength);

        for (int i = 0; i < wordLength; i++)
        {
            letters.Append("_");
            Console.WriteLine("appended value");
        }

        Console.WriteLine(letters);
        Console.WriteLine(letters.Length);


        foreach (string letter in letters)
        {
            Console.Write(letter);
            Console.WriteLine("printing Letter");
        }
    }

   
}
// MEMBER VARIABLE: array of words
// METHOD: get a random word from the array of words
// METHOD: display word/lines
// METHOD: update lines with letters
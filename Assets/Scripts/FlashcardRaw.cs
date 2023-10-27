public class FlashcardDeck
{
    public FlashcardDeck(FlashcardRaw[] flashcards)
    {
        this.flashcards = flashcards;
    }

    public FlashcardDeck(string[] terms, string[] descriptions)
    {
        if (terms.Length != descriptions.Length)
            flashcards = new FlashcardRaw[0];

        flashcards = new FlashcardRaw[terms.Length];
        for (int i = 0; i < terms.Length; i++)
            flashcards[i] = new FlashcardRaw(terms[i], descriptions[i]);
    }

    public FlashcardRaw[] flashcards { get; set; }
}

public class FlashcardRaw
{
    public FlashcardRaw(string term, string description)
    {
        this.term = term;
        this.description = description;
    }

    public string term { get; set; }
    public string description { get; set; }
}

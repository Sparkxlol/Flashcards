public class FlashcardDeck
{
    public FlashcardDeck(FlashcardRaw[] flashcards)
    {
        Flashcards = flashcards;
    }

    public FlashcardDeck(string[] terms, string[] descriptions)
    {
        if (terms.Length != descriptions.Length)
            Flashcards = new FlashcardRaw[0];

        Flashcards = new FlashcardRaw[terms.Length];
        for (int i = 0; i < terms.Length; i++)
            Flashcards[i] = new FlashcardRaw(terms[i], descriptions[i]);
    }

    public FlashcardRaw[] Flashcards { get; set; }
}

public class FlashcardRaw
{
    public FlashcardRaw(string term, string description)
    {
        Term = term;
        Description = description;
    }

    public string Term { get; set; }
    public string Description { get; set; }
}

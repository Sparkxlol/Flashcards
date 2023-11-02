using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SingleFlashcard : MonoBehaviour
{
    [SerializeField] private Flashcard flashcard;
    private List<FlashcardRaw> flashcards;
    private int index = 0;

    // Start is called before the first frame update
    void Start()
    {
        TestFlashcardCreation();
    }

    // Update is called once per frame
    void Update()
    {
        CheckForNextFlashcard();
        CheckForFlipFlashcard();
    }

    void TestFlashcardCreation()
    {
        flashcards = new List<FlashcardRaw>();
        flashcards.Add(new FlashcardRaw("Owen", "A cool guy"));
        flashcards.Add(new FlashcardRaw("Jack", "An uncool guy (joking)"));

        ChangeFlashcard(0);
    }

    void CheckForNextFlashcard()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
            ChangeFlashcard(index + 1);
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
            ChangeFlashcard(index - 1);
    }

    void CheckForFlipFlashcard()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
            flashcard.FlipCard();
        else if (Input.GetKeyDown(KeyCode.DownArrow))
            flashcard.FlipCard();
    }

    void ChangeFlashcard(int newIndex)
    {
        if (newIndex < flashcards.Count && newIndex >= 0)
        {
            flashcard.ChangeCard(flashcards[newIndex]);
            index = newIndex;
        }
    }
}

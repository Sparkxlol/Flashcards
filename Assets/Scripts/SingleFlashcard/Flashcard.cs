using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Flashcard : MonoBehaviour
{
    enum Shown { Term, Definition }

    private Shown shownValue;
    private FlashcardRaw flashcard;
    [SerializeField] private TextMeshPro text;

    private Collider2D col;

    // Start is called before the first frame update
    void Start()
    {
        col = GetComponent<Collider2D>();

        if (flashcard == null)
        {
            ChangeCard(new FlashcardRaw("Flashcard", "Object used to practice learning terms and definitions"));
        }

        text.text = flashcard.term;
    }

    // Update is called once per frame
    void Update()
    {
        CheckFlip();
    }

    public void ChangeCard(FlashcardRaw newFlashcard) 
    { 
        flashcard = newFlashcard;
        shownValue = Shown.Term;

        text.text = flashcard.term;
    }

    public void FlipCard()
    {
        if (shownValue == Shown.Term)
        {
            text.text = flashcard.description;
            shownValue = Shown.Definition;
        }
        else
        {
            text.text = flashcard.term;
            shownValue = Shown.Term;
        }
    }

    private void CheckFlip()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

            if (hit.collider == col)
            {
                FlipCard();
            }
        }
    }
}

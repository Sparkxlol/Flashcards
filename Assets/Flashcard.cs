using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Flashcard : MonoBehaviour
{
    private FlashcardRaw flashcard;
    [SerializeField] private TextMeshPro text;

    // Start is called before the first frame update
    void Start()
    {
        if (flashcard == null)
        {
            flashcard = new FlashcardRaw("Flashcard", "Object used to practice learning terms and definitions");
        }

        SetText();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SetText()
    {
        text.text = flashcard.term;
    }
}

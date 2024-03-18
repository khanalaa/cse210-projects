using System;
using System.Collections.Generic;
using System.Linq;

class Scripture {
    private string _ak_text;
    private List<Word> _ak_words;
    private string _ak_reference;

    // Default constructor that initializes the class fields to default values.
    public Scripture(){
        _ak_text = "";
        _ak_words = new List<Word>();
        _ak_reference = "";
    }

    // Constructor that takes scripture text and reference and initializes the class fields.
    public Scripture(string text, string reference) {
        _ak_text = text;
        _ak_reference = reference;
        _ak_words = new List<Word>();

        // Split the text into words and create Word objects for each word.
        string[] wordsArray = text.Split(' ');
        foreach (string word in wordsArray) {
            _ak_words.Add(new Word(word));
        }
    }

    // ToString method to display the scripture with hidden words.
    public string ToString() {
        List<string> ak_displayWords = new List<string>();
        foreach (Word word in _ak_words) {
            ak_displayWords.Add(word.hideOrShow());
        }
        return $"{_ak_reference} - {string.Join(" ", ak_displayWords)}";
    }

    // Check if all words in the scripture are hidden.
    public bool AreAllWordsHidden() {
        return _ak_words.All(word => word.getHidden());
    }

    // Hide a random word in the scripture.
    public void HideRandomWord() {
        Random random = new Random();
        int index;
        do {
            index = random.Next(_ak_words.Count);
        } while (_ak_words[index].getHidden());

        _ak_words[index].Hide();
    }
}
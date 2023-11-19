using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    
    private List<Word> _words = new List<Word>();
    
    public Scripture(Reference reference, string text)
    {
        _reference = Reference;
        _words = ExtractWords(text);
    }

    private List<Word> ExtractWords(string text)
    {
        string[] wordArray = text.Split(" ");
        List<Word> words = new List<Word>();

        foreach (string word in wordArray)
        {
            words.Add(new Word(word));
        }

        return words;
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();

        for(int i = 0; i < numberToHide; i++)
        {
            int indexToHide = random.Next(_words.Count);
            _words[indexToHide].Hide();
        }
    }

    public string GetDisplayText()
    {
        string visibleText = string.Join(" ", _words.Select(word => word.IsHidden() ? "****" : word.GetDisplayText()));
        return $"{_reference.GetDisplayText()} {visibleText}";
    }

    public bool IsCompleteHidden()
    {
        return _words.All(word => word.IsHidden());
    }

}
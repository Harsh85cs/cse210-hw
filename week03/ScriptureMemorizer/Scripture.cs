using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    private Random _rand; // reuse one Random

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();
        _rand = new Random();

        // Simple split; keeps punctuation attached. That's fine for a student project.
        string[] splitText = text.Split(' ');
        for (int i = 0; i < splitText.Length; i++)
        {
            _words.Add(new Word(splitText[i]));
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        // Build a list of indices for words that are still visible
        List<int> visibleIndices = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndices.Add(i);
            }
        }

        // If there are no visible words, just return
        if (visibleIndices.Count == 0)
        {
            return;
        }

        // Limit how many we try to hide to the count of visible words
        int toHide = numberToHide;
        if (toHide > visibleIndices.Count)
        {
            toHide = visibleIndices.Count;
        }

        // Randomly hide from the visible set
        for (int n = 0; n < toHide; n++)
        {
            int pick = _rand.Next(visibleIndices.Count);
            int idx = visibleIndices[pick];

            _words[idx].Hide();

            // Remove this index so we don't pick it again
            visibleIndices.RemoveAt(pick);
        }
    }

    public string GetDisplayText()
    {
        string result = _reference.GetDisplayText() + "\n";
        for (int i = 0; i < _words.Count; i++)
        {
            result += _words[i].GetDisplayText();
            if (i < _words.Count - 1)
            {
                result += " ";
            }
        }
        return result;
    }

    public bool IsCompletelyHidden()
    {
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}

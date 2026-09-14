
using BTA.Core;

namespace BTA.Windows;

public class TextBuffer
{
    private readonly List<char> _currentWord = new();

    public string CurrentWord => new(_currentWord.ToArray());

    public string? OnKey(int vkCode)
    {
        // Space
        if (vkCode == 32)
        {
            var word = CurrentWord;
            _currentWord.Clear();

            if (string.IsNullOrWhiteSpace(word))
                return null;

            return LayoutConverter.ConvertLayout(word);
        }

        // A-Z
        if (vkCode >= 65 && vkCode <= 90)
        {
            _currentWord.Add((char)(vkCode + 32)); // lowercase
        }

        // Backspace
        if (vkCode == 8 && _currentWord.Count > 0)
        {
            _currentWord.RemoveAt(_currentWord.Count - 1);
        }

        return null;
    }
}
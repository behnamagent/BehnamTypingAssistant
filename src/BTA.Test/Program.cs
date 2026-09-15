using BTA.Core;

namespace BTA.Windows;

public record FixResult(string Text, int OriginalLength);

public class TextBuffer
{
    private readonly List<char> _currentWord = new();

    public FixResult? OnKey(int vkCode)
    {
        // Space
        if (vkCode == 32)
        {
            var word = new string(_currentWord.ToArray());
            var length = _currentWord.Count;
            _currentWord.Clear();

            if (length == 0)
                return null;

            return new FixResult(LayoutConverter.ConvertLayout(word), length);
        }

        // A-Z
        if (vkCode >= 65 && vkCode <= 90)
            _currentWord.Add((char)(vkCode + 32));

        // Backspace
        if (vkCode == 8 && _currentWord.Count > 0)
            _currentWord.RemoveAt(_currentWord.Count - 1);

        return null;
    }
}
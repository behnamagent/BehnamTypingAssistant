
namespace BTA.Core;

public static class WordFixer
{
    public static string FixLastWord(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return text;

        var parts = text.Split(' ');

        parts[^1] = LayoutConverter.ConvertLayout(parts[^1]);

        return string.Join(" ", parts);
    }
}
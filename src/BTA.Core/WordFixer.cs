namespace BTA.Core;

public static class WordFixer
{
    public static string FixLastWord(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
            return text;

        var parts = text.Split(' ');

        if (SmartDetector.ShouldConvert(parts[^1]))
        {
            parts[^1] = LayoutConverter.ConvertLayout(parts[^1]);
        }

        return string.Join(" ", parts);
    }
}
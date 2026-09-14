namespace BTA.Core;

public static class SmartDetector
{
    public static bool ShouldConvert(string word)
    {
        if (string.IsNullOrWhiteSpace(word))
            return false;

        // اگر حروف بزرگ دارد (OpenAI, Windows)، تبدیل نکن
        if (word.Any(char.IsUpper))
            return false;

        // فقط اگر کاملاً انگلیسی باشد تبدیل کن
        return word.All(c => c is >= 'a' and <= 'z');
    }
}

namespace BTA.Core;

public static class TextProcessor
{
    public static string ProcessKey(string currentText, char key)
    {
        if (key == ' ')
            return WordFixer.FixLastWord(currentText) + " ";

        return currentText + key;
    }
}
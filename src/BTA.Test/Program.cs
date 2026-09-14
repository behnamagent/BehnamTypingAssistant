using System.Text;
using BTA.Core;

Console.OutputEncoding = Encoding.UTF8;

string[] tests =
{
    "sghl",
    "khubi",
    "OpenAI",
    "Windows"
};

foreach (var t in tests)
{
    Console.WriteLine($"{t} -> {WordFixer.FixLastWord(t)}");
}
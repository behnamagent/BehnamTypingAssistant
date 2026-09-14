
using System.Text;
using BTA.Core;

Console.OutputEncoding = Encoding.UTF8;

string text = "";

foreach (char c in "sghl ")
{
    text = TextProcessor.ProcessKey(text, c);
}

Console.WriteLine($"\u200F{text}");

using System.Text;

namespace BTA.Core;

public static class LayoutConverter
{
    private const string En = "qwertyuiop[]asdfghjkl;'zxcvbnm,./";
    private const string Fa = "ضصثقفغعهخحجچشسیبلاتنمکگظطزرذپو./";

    public static string ConvertLayout(string text)
    {
        var result = new StringBuilder();

        foreach (char c in text)
        {
            int i = En.IndexOf(char.ToLower(c));

            if (i >= 0)
            {
                result.Append(Fa[i]);
                continue;
            }

            i = Fa.IndexOf(c);

            if (i >= 0)
            {
                result.Append(En[i]);
                continue;
            }

            result.Append(c);
        }

        return result.ToString();
    }
}
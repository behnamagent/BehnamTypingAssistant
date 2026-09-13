using System.Text;

namespace BTA.Core;

public static class LayoutConverter
{
    private const string En = "qwertyuiop[]asdfghjkl;'zxcvbnm,./";
    private const string Fa = "ضصثقفغعهخحجچشسیبلاتنمکگظطزرذپو./";

    public static string ConvertLayout(string text)
    {
        var sb = new StringBuilder();

        foreach (char c in text)
        {
            int i = En.IndexOf(char.ToLower(c));

            if (i >= 0)
            {
                sb.Append(Fa[i]);
                continue;
            }

            i = Fa.IndexOf(c);

            if (i >= 0)
            {
                sb.Append(En[i]);
                continue;
            }

            sb.Append(c);
        }

        return sb.ToString();
    }
}

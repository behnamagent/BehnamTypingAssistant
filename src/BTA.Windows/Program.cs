
using System.Windows.Forms;

namespace BTA.Windows;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        using var tray = new TrayManager();
        using var hook = new KeyboardHook();

        var buffer = new TextBuffer();

        hook.KeyPressed += vk =>
        {
            var fixedWord = buffer.OnKey(vk);

            if (fixedWord is not null)
            {
                SendInputHelper.Backspace(buffer.CurrentWord.Length);
                SendInputHelper.TypeText(fixedWord);
                SendInputHelper.TypeText(" ");
            }
        };

        hook.Start();

        Application.Run();
    }
}


using System.Drawing;
using System.Windows.Forms;

namespace BTA.Windows;

public class TrayManager : IDisposable
{
    private readonly NotifyIcon _icon;

    public TrayManager()
    {
        _icon = new NotifyIcon
        {
            Icon = SystemIcons.Information,
            Text = "Behnam Typing Assistant",
            Visible = true
        };

        var menu = new ContextMenuStrip();

        menu.Items.Add("فعال", null, (_, _) => { });

        menu.Items.Add("خروج", null, (_, _) =>
        {
            Application.Exit();
        });

        _icon.ContextMenuStrip = menu;
    }

    public void Dispose()
    {
        _icon.Visible = false;
        _icon.Dispose();
    }
}
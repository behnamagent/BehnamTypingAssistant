
namespace BTA.Core;

public class KeyTracker
{
    private DateTime _lastShift = DateTime.MinValue;

    public bool IsDoubleShift()
    {
        var now = DateTime.UtcNow;

        if ((now - _lastShift).TotalMilliseconds < 350)
        {
            _lastShift = DateTime.MinValue;
            return true;
        }

        _lastShift = now;
        return false;
    }
}
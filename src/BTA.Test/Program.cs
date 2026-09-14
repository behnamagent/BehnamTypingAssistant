
using BTA.Core;

var tracker = new KeyTracker();

Console.WriteLine("Shift...");
Console.ReadKey();

Console.WriteLine("Shift...");
Console.ReadKey();

Console.WriteLine(tracker.IsDoubleShift()
    ? "Double Shift Detected!"
    : "No");
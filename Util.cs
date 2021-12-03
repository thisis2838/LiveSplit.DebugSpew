using LiveSplit.DebugSpew;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

public class TimedTraceListener : DefaultTraceListener
{
    private static TimedTraceListener _instance;
    public static TimedTraceListener Instance => _instance ?? (_instance = new TimedTraceListener());

    private TimedTraceListener() { }

    public override void WriteLine(string message)
    {
        var box = DebugSpewComponent.SpewWindow.boxDebugSpew;
        message = message.Replace("\n", "\r\n");
        if (!DebugSpewComponent.SpewWindow.AutoScroll)
        {
            int selStart = box.SelectionStart;
            int selLen = box.SelectionLength;
            int firstDispIndex = box.GetCharIndexFromPosition(new Point(3, 3));

            box.Suspend();
            box.AppendText(message + "\r\n");
            box.Resume();

            box.Select(firstDispIndex, 0);
            box.ScrollToCaret();
            box.Select(selStart, selLen);
        }
        else
            box.AppendText(message + "\r\n");
    }
}
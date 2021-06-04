using LiveSplit.DebugSpew;
using System.Diagnostics;

public class TimedTraceListener : DefaultTraceListener
{
    private static TimedTraceListener _instance;
    public static TimedTraceListener Instance => _instance ?? (_instance = new TimedTraceListener());

    private TimedTraceListener() { }

    public override void WriteLine(string message)
    {
        DebugSpewComponent.SpewWindow.boxDebugSpew.AppendText(message + "\r\n");
    }
}
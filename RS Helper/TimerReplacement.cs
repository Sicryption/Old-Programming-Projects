using System;
using System.Timers;

public class TimerReplacement : System.Timers.Timer
{
    public TimerReplacement()
    {
        base.Elapsed += Elapsed;
    }

    void Elapsed(object sender, ElapsedEventArgs e)
    {
        var handler = this.Elapsed;
        if (handler != null)
        {
            
        }
    }
}

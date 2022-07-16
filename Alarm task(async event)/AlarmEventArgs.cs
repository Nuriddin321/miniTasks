 public class AlarmEventArgs : EventArgs
 {

    public DateTime Start { get; init; }
    public DateTime End { get; init; }
    public double GetTime
    {
        get =>(End - Start).TotalMilliseconds;
    }
    public AlarmEventArgs(DateTime start, DateTime end)
    {
        Start = start;
        End = end;
    }

    public void getShow()
    {
        Console.WriteLine($"ish bajarildi shoqosim");
        
    }
    
    
    
 }
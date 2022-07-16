public class Alarm
{
    private DateTime _budilnik;

    public Alarm(DateTime budilnik)
    {
        _budilnik = budilnik;
    }

    public event EventHandler<AlarmEventArgs> Onbudilnik;

    public async Task Start()
    {

        await Task.Delay(5000);
        Onbudilnik.Invoke(this, new AlarmEventArgs(_budilnik, DateTime.Now));
        /*
            code here
        */
        
    }

}
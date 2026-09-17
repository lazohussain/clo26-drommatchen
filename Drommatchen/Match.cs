public class Match
{
    // Privata fält
    private string _hemmalag;
    private string _bortalag;
    private string _datum;


    public string Hemmalag
    {
        get { return _hemmalag; }
        private set { _hemmalag = value; }
    }

    public string Bortalag
    {
        get { return _bortalag; }
        private set { _bortalag = value; }
    }

    public string Datum
    {
        get { return _datum; }
        private set { _datum = value; }
    }

    public Match(string hemmalag, string bortalag, string datum)
    {
        Hemmalag = hemmalag;
        Bortalag = bortalag;
        Datum = datum;
    }

    // Metod 1: skriv ut matchens lag och datum
    public void Presentera()
    {
        Console.WriteLine(Hemmalag + " vs " + Bortalag + " — " + Datum);
    }

    public void AnnounceraMålskytt(Spelare spelare)
    {
        Console.WriteLine("MÅÅÅL ! #" + spelare.Nummer + " " + spelare.Namn + " (" + spelare.Position + ")");
    }
}
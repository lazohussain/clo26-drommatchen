class Program
{
    static void Main()
    {
        Spelare spelare1 = new Spelare("Ronaldo", 7, "Forward");
        Spelare spelare2 = new Spelare("Mbappe", 10, "Forward");

        Match match = new Match("Kurdish FC", "Paris", "2029-05-04");

        match.Presentera();

        match.AnnounceraMålskytt(spelare1);
        match.AnnounceraMålskytt(spelare2);
    }
}
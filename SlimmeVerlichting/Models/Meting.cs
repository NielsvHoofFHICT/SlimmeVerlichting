namespace SlimmeVerlichting.Models;

public class Meting
{
    public DateTime Tijdstip { get; init; }
    public float Lichtsterkte { get; init; }
    public bool BewegingGedetecteerd { get; init; }
    public int LantaarnpaalId { get; init; }
}
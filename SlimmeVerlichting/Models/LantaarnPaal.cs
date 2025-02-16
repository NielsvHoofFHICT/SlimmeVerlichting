namespace SlimmeVerlichting.Models;

public class LantaarnPaal
{
    public int Id { get; init; }
    public required string Locatie { get; init; }
    public required string Status { get; set; }

    public void SchakelIn()
    {
        Status = "Aan";
    }

    public void SchakelUit()
    {
        Status = "Uit";
    }
}
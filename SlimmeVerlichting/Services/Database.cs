using SlimmeVerlichting.Models;

namespace SlimmeVerlichting.Services;

public class Database
{
    private readonly List<Meting> _metingen = [];

    public void OpslaanMeting(Meting meting)
    {
        _metingen.Add(meting);
    }

    public List<Meting> HaalMetingenOp(int lantaarnpaalId)
    {
        return _metingen.FindAll(m => m.LantaarnpaalId == lantaarnpaalId);
    }
}
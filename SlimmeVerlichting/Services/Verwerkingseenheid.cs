using SlimmeVerlichting.Models;

namespace SlimmeVerlichting.Services;

public class Verwerkingseenheid(LantaarnPaal lantaarnpaal, Database database)
{
    public void VerwerkSensordata(float lichtsterkte, bool beweging)
    {
        if (lichtsterkte < 30 && beweging)
        {
            lantaarnpaal.SchakelIn();
        }
        else
        {
            lantaarnpaal.SchakelUit();
        }
        
        var meting = new Meting
        {
            Tijdstip = DateTime.Now,
            Lichtsterkte = lichtsterkte,
            BewegingGedetecteerd = beweging,
            LantaarnpaalId = lantaarnpaal.Id
        };
        database.OpslaanMeting(meting);
    }
}
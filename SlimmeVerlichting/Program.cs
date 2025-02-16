using SlimmeVerlichting.Models;
using SlimmeVerlichting.Services;

var database = new Database();
var lantaarnpaal = new LantaarnPaal() { Id = 1, Locatie = "Straat 1", Status = "Uit" };
var verwerkingseenheid = new Verwerkingseenheid(lantaarnpaal, database);

var random = new Random();

while (true)
{
    float lichtsterkte = random.Next(0, 100);
    var beweging = random.Next(0, 2) == 1;

    verwerkingseenheid.VerwerkSensordata(lichtsterkte, beweging);

    Console.WriteLine("--- Status Lantaarnpaal ---");
    Console.WriteLine($"Locatie: {lantaarnpaal.Locatie}");
    Console.WriteLine($"Status: {lantaarnpaal.Status}");
    Console.WriteLine($"Lichtsterkte: {lichtsterkte} lux");
    Console.WriteLine($"Beweging gedetecteerd: {beweging}");
    Console.WriteLine();

    Console.WriteLine("--- Metingen ---");
    var metingen = database.HaalMetingenOp(lantaarnpaal.Id);
    
    foreach (var meting in metingen)
    {
        Console.WriteLine(
            $"{meting.Tijdstip}: Lichtsterkte = {meting.Lichtsterkte} lux, Beweging = {meting.BewegingGedetecteerd}");
    }

    Console.WriteLine();

    Thread.Sleep(5000);
}
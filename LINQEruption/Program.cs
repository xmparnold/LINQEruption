List<Eruption> eruptions = new List<Eruption>()
{
    new Eruption("La Palma", 2021, "Canary Is", 2426, "Stratovolcano"),
    new Eruption("Villarrica", 1963, "Chile", 2847, "Stratovolcano"),
    new Eruption("Chaiten", 2008, "Chile", 1122, "Caldera"),
    new Eruption("Kilauea", 2018, "Hawaiian Is", 1122, "Shield Volcano"),
    new Eruption("Hekla", 1206, "Iceland", 1490, "Stratovolcano"),
    new Eruption("Taupo", 1910, "New Zealand", 760, "Caldera"),
    new Eruption("Lengai, Ol Doinyo", 1927, "Tanzania", 2962, "Stratovolcano"),
    new Eruption("Santorini", 46,"Greece", 367, "Shield Volcano"),
    new Eruption("Katla", 950, "Iceland", 1490, "Subglacial Volcano"),
    new Eruption("Aira", 766, "Japan", 1117, "Stratovolcano"),
    new Eruption("Ceboruco", 930, "Mexico", 2280, "Stratovolcano"),
    new Eruption("Etna", 1329, "Italy", 3320, "Stratovolcano"),
    new Eruption("Bardarbunga", 1477, "Iceland", 2000, "Stratovolcano")
};
// Example Query - Prints all Stratovolcano eruptions
IEnumerable<Eruption> stratovolcanoEruptions = eruptions.Where(c => c.Type == "Stratovolcano");
PrintEach(stratovolcanoEruptions, "Stratovolcano eruptions.");
// Execute Assignment Tasks here!



// IEnumerable<Eruption> firstChile = eruptions.Where(eruption => eruption.Location == "Chile");

Eruption firstChilee = eruptions.Where(eruption => eruption.Location == "Chile").First();
Console.WriteLine(firstChilee.ToString());


Eruption? firstHawaii = eruptions.Where(eruption => eruption.Location == "Hawaiian Is").First();

if (firstHawaii != null) {
    Console.WriteLine(firstHawaii.ToString());
}
else {
    Console.WriteLine("No eruptions found in Hawaiian Is");
}


Eruption? newZealand = eruptions.Where(eruption => eruption.Location == "New Zealand" && eruption.Year > 1900).First();
Console.WriteLine(newZealand.ToString());

IEnumerable<Eruption> elevations = eruptions.Where(eruption => eruption.ElevationInMeters > 2000);
PrintEach(elevations, "Eruptions with volcano's with elevation over 2000m");

IEnumerable<Eruption> startsWithZ = eruptions.Where(eruption => eruption.Volcano.StartsWith("Z"));
Console.WriteLine(startsWithZ.Count() + "eruptions with volcanos starting with Z found");
PrintEach(startsWithZ, "Eruptions with volcano's starting with Z");

int highestElevation = eruptions.Max(eruption => eruption.ElevationInMeters);
Console.WriteLine("Highest Elevation" + highestElevation);

IEnumerable<Eruption> highestElevationVolcano = eruptions.Where(eruption => eruption.ElevationInMeters == (int)highestElevation);
PrintEach(highestElevationVolcano, "Volcano with the highest elevation.");

IEnumerable<Eruption> alhpabetical = eruptions.OrderBy(eruption => eruption.Volcano);
PrintEach(alhpabetical, "All volcanos listed alphabetically.");

IEnumerable<Eruption> alphabeticalBCE = eruptions.Where(eruption => eruption.Year < 1000).OrderBy(eruption=> eruption.Volcano);
PrintEach(alphabeticalBCE, "All eruptions before 1000 CE in alphabetical order.");


 
// Helper method to print each item in a List or IEnumerable.This should remain at the bottom of your class!
static void PrintEach(IEnumerable<dynamic> items, string msg = "")
{
    Console.WriteLine("\n" + msg);
    foreach (var item in items)
    {
        Console.WriteLine(item.ToString());
    }
}

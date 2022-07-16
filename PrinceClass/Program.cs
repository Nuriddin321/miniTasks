
var tests = int.Parse(Console.ReadLine());

while(tests-- > 0)
{
    var coords = Console.ReadLine()
    .Split(' ', StringSplitOptions.RemoveEmptyEntries ).
    Select(int.Parse).
    ToArray();

    var prince = new Prince(
        start: new Point(coords[0], coords[1]),
        end: new Point(coords[2], coords[3])
    );

    var numberOfPlanets = int.Parse(Console.ReadLine());
    var planets = new Circle[numberOfPlanets];

   for(int i = 0; i < numberOfPlanets; i++)
    {
        var planetCoords = Console.ReadLine()
        .Split(' ', StringSplitOptions.RemoveEmptyEntries ).
        Select(int.Parse).
        ToArray();

        planets[i] = new Circle(
            center: new Point(planetCoords[0], planetCoords[1]),
            radius: planetCoords[2]
        );
    }

    Console.WriteLine(prince.CrossingCount(planets));
}


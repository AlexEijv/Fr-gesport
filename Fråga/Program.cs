Console.ForegroundColor = ConsoleColor.Blue;

int points = 0;
Console.WriteLine("Välkommen till min legendariska frågesport");

Console.WriteLine("1, Vilket är det bästa spelserien?");
Console.WriteLine("a) COD b) Halo c) CS");
string q1 = Console.ReadLine().ToLower();

if (q1 =="c")
{
Console.WriteLine("Korrekt");
points++;
}
else
{
    Console.WriteLine("Du har tappat det");
}


Console.WriteLine("2, Vidrigaste vapnet i CS");
Console.WriteLine("a) P90 b) AWP c) m249");
string q2 = Console.ReadLine().ToLower();
if (q2 =="b")
{
    Console.WriteLine("Korrekt");
    points++;
}
else
{
    Console.WriteLine("Herregud, kan man vara sämre?");
}

Console.WriteLine("3, Bästa mid tier kniven i CS:GO");
Console.WriteLine("a) Skeleton b) Nomad c) Talon");
string q3 = Console.ReadLine().ToLower();
if (q3 == "a")
{
    Console.WriteLine("Korrekt");
    points++;
}
else
{
    Console.WriteLine("Snälla... Jag blir fan ledsen");
}
Console.WriteLine("Det här är dina poäng: " + points);

Console.WriteLine("Tryck på en tangent för att avsluta.");
Console.ReadKey();
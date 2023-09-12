Console.WriteLine("Välkommen till min legendariska frågesport");

Console.WriteLine("1, Vilket är det bästa spelserien?");
Console.WriteLine("a) COD b) Halo c) CS");
string q1 = Console.ReadLine();
if (q1 =="c")
{
Console.WriteLine("Korrekt");
}
else
{
    Console.WriteLine("Du är fan mongo");
}


Console.WriteLine("2, Bästa vapnet i CS");
Console.WriteLine("a) AK47 b) AWP c) M4a1-s");
string q2 = Console.ReadLine();
if (q2 =="a")
{
    Console.WriteLine("Korrekt");
}
else
{
    Console.WriteLine("Herregud, kan man vara sämre?");
}

Console.WriteLine("3, Bästa mid tier kniven i CS:GO");
Console.WriteLine("a) Nomad b) Skeleton c) Talon");
string q3 = Console.ReadLine();
if (q3 == "b")
{
    Console.WriteLine("Korrekt");
}
else
{
    Console.WriteLine("Snälla, lär dig nått");
}

Console.WriteLine("Tryck på en tangent för att avsluta.");
Console.ReadKey();
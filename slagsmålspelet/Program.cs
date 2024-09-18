int hp1 = 100;
int hp2 = 100;

Console.Write("vad är ditt namn? ");
String name = Console.ReadLine();
Console.WriteLine($"Välkomen {name} till slagsmåls spelet");
Thread.Sleep(2000);
Console.WriteLine($"{name} vi behöver din styrka att besegra den onde greven");
Thread.Sleep(1000);
Console.WriteLine("Vill du hjälpa?");
Thread.Sleep(1000);
Console.WriteLine("Yes/No");

string acceptering = Console.ReadLine().ToLower();

if (acceptering == "yes"){
    Console.WriteLine("Bra att du vill");
}
else {
Console.WriteLine("Nerver back down never give up , du får ändå");
}

while (true)
{
    

    
}


Console.ReadLine();
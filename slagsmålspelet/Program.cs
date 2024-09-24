
while (true)
{
   int hp2 = 100;
   int hp1 = 100;

   Console.Write("vad är ditt namn? ");
   String name = Console.ReadLine();

   while (name == "")
   {
      Console.WriteLine("skriv något namn snälla");
      Console.WriteLine("försök igen:");
      name = Console.ReadLine();
   }
   Console.Clear();
   Console.WriteLine($"Välkomen {name} till slagsmåls spelet");
   Thread.Sleep(2000);
   Console.Clear();
   Console.WriteLine($"{name} vi behöver din styrka att besegra den onde greven");
   Thread.Sleep(1000);
   Console.WriteLine("Vill du hjälpa?");
   Thread.Sleep(1000);
   Console.WriteLine("Yes/No");


   string acceptering = Console.ReadLine().ToLower();

   if (acceptering == "yes")
   {
      Console.WriteLine("Bra att du vill");
   }
   else
   {
      Console.WriteLine("Nerver back down never give up , du får ändå");
   }

   Thread.Sleep(1000);
   Console.Clear();

   while (true)
   {

      int at1 = Random.Shared.Next(0, 26);
      int at2 = Random.Shared.Next(0, 21);
      
      if (hp1 > 0 && hp2 > 0)
      {
         hp1 -= at2;
         hp2 -= at1;
         Console.WriteLine($"{name} gjorde {at1}dmg, Greven har {hp2} kvar");
         Console.WriteLine($"Greven gjorde {at2}dmg, {name} har {hp1} kvar");

         Console.ReadLine();
         Console.Clear();
      }


      if (at1 == 7)
      {
         Console.WriteLine("Ronadlo kom med i fighten och besgrade greven med en enda spark");
         Console.WriteLine($"{name} och Ronaldo van");
         Console.ReadLine();
         break;
      }
      if (hp1 <= 0)
      {
         Console.WriteLine("Greven besegrade dig");
         Console.ReadLine();
         break;
      }
      if (hp2 <= 0)
      {
         Console.WriteLine($"{name} besegrade greven , bra för dig");
         Console.ReadLine();
         break;

      }



   }

   Console.WriteLine("Tryck på enter knappen för att börja om");
   Console.ReadLine();
   Console.Clear();
}
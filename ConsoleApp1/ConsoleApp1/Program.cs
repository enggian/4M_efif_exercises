using System.Xml.Schema;
Random random = new Random();
random.Next(0, 2);
int z = 0;
int u = 0;

// 0 = schere 1 = stein 2 = papier 



while(z < 3 && u < 3)
{
    //int x = random.Next(0, 2);
    //int y = random.Next(0, 2);
    Console.WriteLine("Spielr 1 ist am Zug");
    string x = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("Spieler 2 ist am Zug");
    string y = Console.ReadLine();
    Console.Clear();
    Console.WriteLine("0 = Schere / 1 = Stein / 2 = Papier");
    if (x == "0" && y == "1")
    {
        Console.WriteLine("schere und schere, niemand gewinnt");
    }
    else if (x == "0" && y == "1")
    {
        Console.WriteLine("schere und stein, stein gewinnt");
        u++;
    }
    else if (x == "0" && y == "2")
    {
        Console.WriteLine("schere und papier, schere gewinnt");
        z++;
    }
    else if (x == "1" && y == "0")
    {
        Console.WriteLine("stein und schere, stein gewinnt");
        z++;
    }
    else if (x == "2" && y == "0")
           
    {
        Console.WriteLine("papier und schere, schere gewinnt");
        u++;
    }
    else if (x == "1" && y == "1")
    {
        Console.WriteLine("stein und stein, niemand gewinnt");
    }
    else if (x == "1" && y == "2")
    {
        Console.WriteLine("stein und papier, papier gewinnt");
        u++;
    }
    else if (x == "2" && y == "1")
    {
        Console.WriteLine("papier und stein, papier gewinnt");
        z++;
    }
    else if (x == "2" && y == "2")
    {
        Console.WriteLine("papier und papier, niemand gewinnt");
    }
    
    

}
if (z == 3)
{
    Console.WriteLine("Spieler 1 hat gewonnen");
}
else if (u == 3)
{
    Console.WriteLine("Spieler 2 hat gewonnen");
}
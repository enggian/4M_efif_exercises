using System;



Random rand = new Random();
int points = 0;
bool lost = false;



while (!lost)
{
    int z1 = rand.Next(1, 6);
    int z2 = rand.Next(1, 6);
    int op = rand.Next(1, 3);
    int result;



    if (op == 1)
    {
        Console.WriteLine($"Was ist {z1} + {z2}?");
        result = z1 + z2;
    }
    else
    {
        Console.WriteLine($"Was ist {z1} - {z2}?");
        result = z1 - z2;
    }



    if (int.TryParse(Console.ReadLine(), out int userAnswer))
    {
        if (userAnswer == result)
        {
            Console.WriteLine(".");
            points++;
        }
        else
        {
            Console.WriteLine($"Falsch, deine Punktzahl ist; {points}");
            lost = true;
        }
    }
    else
    {
        Console.WriteLine("Keine Richtige Angabe .");
    }
}





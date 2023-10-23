//E1
//long a = 1;
//long b = 1;
//int z = 0;
//while (z < 10)
//{
//    console.writeline(a);
//    console.writeline(b);
//    a = a + b;
//    b = a + b;
//    z++;
//
//{
// 
// Fibonacci-Folge / ctr + k + c = alles auskommentieren ctr + k + u = alles auskommenteiren wegmachen

//E2.1
//Console.WriteLine("bitte geben sie eine ganze Zahl ein");
//int p = Convert.ToInt32(Console.ReadLine());
//int count = 0;


//for (int i = 1; i <= p; i++)
//    if (p % i == 0)
//    {
//        count++;
//    }
//if (count == 2)
//{
//    Console.WriteLine("Es ist eine Primzahl");
//}
//else if (count > 2)
//{
//    Console.WriteLine("Keine Primzahl");
//}
// Primzahl überprüfer 


/*
 E2.2
Console.WriteLine("bitte geben sie eine ganze Zahl ein");
int c = Convert.ToInt32(Console.ReadLine());
int counter = 0;


while (c >= 0)
{
    for (int i = 1; i <= c; i++)
        if (c % i == 0)
        {
            counter++;

        }
    if (counter == 2)
    {
        Console.WriteLine(c);
        c = c - 1;
    }
    else if (counter > 2)
    {
        c = c - 1;
        counter = 0;
    }
}
primzahlen von zahl bis 0 20 19 18...
 */



//E3 




Console.WriteLine("bitte geben sie eine ganze Zahl ein");
int Zahl1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("bitte geben sie  zweite ganze Zahl ein die kleiner ist, als die zweite");
int Zahl2 = Convert.ToInt32(Console.ReadLine());

int r = 0;

while (Zahl1 > 0 || Zahl2 > 0)
{
    if(Zahl1%Zahl2 == 1)
    {
        Console.WriteLine("Die Zahlen sind teilerfremd");
        break;
    }


   else if(Zahl1%Zahl2 == 0)
    {
        Console.WriteLine(Zahl2);
        break;
    }
    else if (Zahl1 % Zahl2 > 0)
    {
        r = Zahl1 % Zahl2;
        Zahl1 = Zahl2;
        Zahl2 = r;

    }


 
}
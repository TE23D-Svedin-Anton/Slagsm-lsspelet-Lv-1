int Pl_A_HP = 100;
int Pl_B_HP = 100;
int Round = 0;
bool RoundOver = true;
bool FightOver = false;

static int NästaRunda(bool RoundOver)
{
    if (RoundOver == true)
    {
        return 1;
    }
    else
    {
        return 0;
    }
}

Console.WriteLine("Välkommen till mitt slagsmålsspel");
Console.WriteLine("Skriv in ditt namn");

string name = Console.ReadLine();
while (name.Length < 3 || !name.All(Char.IsLetter))
{
    Console.WriteLine("Skriv in ditt namn, sa jag, dumhuvve");
    name = Console.ReadLine();
}

Console.WriteLine($"Hej {name}");
Console.WriteLine("Tryck Enter För Att Börja");
Console.ReadLine();

Round += NästaRunda(RoundOver);

if (FightOver == true)
{
    Console.WriteLine($"Runda Nummer {Round}");
}


while (true)
{
    int card = Random.Shared.Next(10, 20);
    Console.WriteLine(card);
    Console.ReadLine();
}
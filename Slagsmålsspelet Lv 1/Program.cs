int Pl_1_HP = 100;
int Pl_2_HP = 100;

string Pl2Name = "Dum Person";

int Round = 0;
bool RoundOver = true;
bool FightOver = false;

static int NästaRunda(bool RoundOver, string Pl1Name, int Pl_1_HP, string Pl2Name, int Pl_2_HP)
{
    Console.WriteLine($"{Pl1Name}: {Pl_1_HP} {Pl2Name}; {Pl_2_HP}\n");
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

string Pl1Name = Console.ReadLine();
while (Pl1Name.Length < 3 || !Pl1Name.All(Char.IsLetter))
{
    Console.WriteLine("Skriv in ditt namn, sa jag, dumhuvve");
}

Console.WriteLine($"Hej {Pl1Name}");
Console.WriteLine("Tryck Enter För Att Börja");
Console.ReadLine();

Round += NästaRunda(RoundOver, Pl1Name, Pl_1_HP, Pl2Name, Pl_2_HP);

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
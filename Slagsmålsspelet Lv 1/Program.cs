int Pl_1_HP = 100;
int Pl_2_HP = 100;

string Pl2Name = "Dum Person";

int Round = 1;
bool RoundOver = false;

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
    Pl1Name = Console.ReadLine();   
}

Console.WriteLine($"Hej {Pl1Name}");
Console.WriteLine("Tryck Enter För Att Börja");
Console.ReadLine();

while (Pl_1_HP > 0 &&  Pl_2_HP > 0)
{
    if (RoundOver = true)
{
    Console.WriteLine($"\nRunda{Round}");

    int Pl_1_Damage = Random.Shared.Next(20);
    Pl_2_HP -= Pl_1_Damage;
    Pl_2_HP = Math.Max(0, Pl_2_HP);

    int Pl_2_Damage = Random.Shared.Next(20);
    Pl_1_HP -= Pl_2_Damage;
    Pl_1_HP = Math.Max(0, Pl_1_HP);
    Round += NästaRunda(RoundOver, Pl1Name, Pl_1_HP, Pl2Name, Pl_2_HP);
    Console.ReadKey();

}
}
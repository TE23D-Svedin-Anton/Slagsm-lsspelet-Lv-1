int Pl_A_HP = 100;
int Pl_B_HP = 100;

Console.WriteLine("Välkommen till mitt slagsmålsspel");
Console.WriteLine("Skriv in ditt namn");

string name  = Console.ReadLine();
while (name.Length < 3 || !name.All(Char.IsLetter))
{
    Console.WriteLine("Skriv in ditt namn, sa jag, dumhuvve");
    name = Console.ReadLine();
}


Console.WriteLine($"Hej {name}");

Console.ReadLine();

while (true)
{
int card = Random.Shared.Next(10, 20);
Console.WriteLine(card);
Console.ReadLine();
}
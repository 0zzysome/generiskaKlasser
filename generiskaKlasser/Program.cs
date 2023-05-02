// See https://aka.ms/new-console-template for more information


Random generator = new Random();
Queue<int> NummerLista = new Queue<int>();

for (int i = 0; i < 10; i++)
{
    NummerLista.Enqueue(generator.Next(100));
}


while (NummerLista.Count > 0)
{
    int nummer = NummerLista.Dequeue();
    System.Console.WriteLine(nummer);
}


Console.ReadLine();

Dictionary<string, string> OrdBok = new();
OrdBok.Add("Hej", "En hälsning");

bool IsGoing = true;
while(IsGoing)
{
    Console.Clear();
    System.Console.WriteLine("Skriv ett ord");
    string Ord = Console.ReadLine();

    if(OrdBok.ContainsKey(Ord))
    {
        System.Console.WriteLine(OrdBok[Ord]);
    }
    else
    {
        System.Console.WriteLine("Skriv betydelse");
        string Betydelse = Console.ReadLine();
        OrdBok.Add(Ord, Betydelse);
    }
    Console.ReadLine();
    
}

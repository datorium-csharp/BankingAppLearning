// See https://aka.ms/new-console-template for more information
Console.WriteLine("Welcome to my Bank!");

List<Client> clients = new List<Client>();
clients.Add(new Client("Anna", "Coder", 19, "ACC123456789"));
clients.Add(new Client("Jenifer", "Anders", 32, "ACC654987"));
clients.Add(new Client("Miki", "Ally", 15, "ACC65123456789"));

for (int i = 0; i < 3; i++)
{
    clients[i].Introduce();
}

foreach (var client in clients)
{
    Console.WriteLine($"Now we change age of {client.Name}");
    client.AddOneToAge();
}

Console.Read();

//clients[0].Introduce();
//clients[1].Introduce();
//clients[2].Introduce();

//Console.WriteLine($"My name is: {clients[0].Name}, Account Nr.: {clients[0].Account}");
//Console.WriteLine($"My name is: {clients[1].Name}, Account Nr.: {clients[1].Account}");
//Console.WriteLine($"My name is: {clients[2].Name}, Account Nr.: {clients[2].Account}");

class Client
{
    public Client(string name, string surname, int age, string account)
    {
        Name = name;
        Surname = surname;
        Age = age;
        Account = account;
    }

    /// <summary>
    /// Here we set the properties of a client
    /// </summary>
    public string Name { get; set; }
    public string Surname { get; set; }
    public int Age { get; set; }
    public string Account { get; set; }

    /// <summary>
    /// This method will introduce a client
    /// </summary>
    public void Introduce()
    {
        Console.WriteLine($"My name is: {Name} {Surname}, I'm {Age} years old, account Nr.: {Account}");
    }

    public void InformAccount()
    {
        Console.WriteLine(Account);
    }

    public void AddOneToAge()
    {
        Age += 1;
        Console.WriteLine($"Now I am {Age} years old");
    }

}
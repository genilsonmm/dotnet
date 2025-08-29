/*
Console.Write("Digite seu nome: ");
String nome = Console.ReadLine();

Console.Write("Digite sua idade: ");
int idade = int.Parse(Console.ReadLine());

Console.Write("Olá, " + nome + " sua idade é: " + idade);

Console.ReadLine();
*/

/*using AppDemo;

Loja loja = new Loja();
loja.Iniciar();
*/

using AppDemo;

List<int> valores = new List<int>();
valores.Add(1);
valores.Add(2);
valores.Add(3);

/*
foreach(int i in valores)
{
    Console.WriteLine(i);
}*/

//valores.ForEach(i => Console.WriteLine(i));

User user1 = new User("Maria", 30);
User user2 = new User("João", 24);
User user3 = new User("Daniel", 50);

List<User> users = new List<User>();
users.Add(user1);
users.Add(user2);
users.Add(user3);

List<User> newUsers = users.Where(u => u.Age < 50 && u.Name.Contains("Mar")).ToList();
newUsers.ForEach(user => Console.WriteLine(user.Name));

/*
List<User> newUsers = new List<User>();

foreach (User user in users)
{
    if (user.Age < 50)
    {
        newUsers.Add(user);
    }
}


newUsers.ForEach(user => Console.WriteLine(user.Name)); 
*/
Console.WriteLine();
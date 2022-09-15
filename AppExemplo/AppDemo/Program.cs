using AppDemo;

Console.WriteLine("Hello, World!");

Aluno aluno1 = new Aluno(1, "Alaniel", 20);
Aluno aluno2 = new Aluno(2, "Isaque", 30);
Aluno aluno3 = new Aluno(3, "Romildo", 23);
Aluno aluno4 = new Aluno(4, "João", 29);
Aluno aluno5 = new Aluno(5, "Dhiogo", 21);

List<Aluno> alunos = new List<Aluno>();
alunos.Add(aluno1);
alunos.Add(aluno2);
alunos.Add(aluno3);
alunos.Add(aluno4);
alunos.Add(aluno5);

/*
for (int i = 0; i < alunos.Count; i++)
{
    Console.WriteLine(alunos[i].Name);
}
*/

/*
foreach (var aluno in alunos)
{
    Console.WriteLine(aluno.Name);
}
*/

//alunos.ForEach(aluno => Console.WriteLine(aluno.Name));

/*
alunos.ForEach(aluno =>
{
    if(aluno.Age > 22)
    {
        Console.WriteLine(aluno.Name);
    }
});
*/

List<Aluno> novosAlunos = alunos.Where(aluno => aluno.Age > 22).ToList();
//novosAlunos.ForEach(aluno => Console.WriteLine(aluno.Name));

Aluno aluno = alunos.Find(aluno => aluno.Name.Equals("Dhiogo"));
Console.WriteLine("jhdsjfhsdfsdfdsfdf");

string valor = Console.ReadLine();

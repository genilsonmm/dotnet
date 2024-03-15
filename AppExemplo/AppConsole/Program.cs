
using AppConsole;

Aluno aluno1 = new Aluno() { Nome = "Fulano 1", Cpf = "555555", Idade=18 };
Aluno aluno2 = new Aluno() { Nome = "Fulano 2", Cpf = "232366", Idade=22 };
Aluno aluno3 = new Aluno() { Nome = "Fulano 3", Cpf = "111998", Idade=30 };

List<Aluno> alunos = new List<Aluno>();
alunos.Add(aluno1);
alunos.Add(aluno2);
alunos.Add(aluno3);

Console.WriteLine(alunos.Count);

Aluno alunoSelecionado = alunos.Find(a => a.Cpf.Equals("23236"));
Console.WriteLine(alunoSelecionado);

List<Aluno> alunosSelecionados = alunos.Where(a => a.Idade > 18).ToList();

foreach (var aluno in alunosSelecionados)
{
    Console.WriteLine(aluno);
}

alunosSelecionados.ForEach(a => Console.WriteLine(a));

alunosSelecionados.ForEach(a =>
{
    //Fazer o que precisar
    Console.WriteLine(a);
});






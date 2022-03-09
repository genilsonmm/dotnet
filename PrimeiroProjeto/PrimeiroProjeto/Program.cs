using System;

namespace PrimeiroProjeto
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            Pessoa novaPessoa = new Pessoa("João Victor", 21);

            Console.WriteLine("Nome: " + novaPessoa.ObterNome());
            Console.WriteLine("Idade: " + novaPessoa.ObterIdade());
            */

            Pessoa novaPessoa = new Pessoa("João", "Victor", 21);

            Console.WriteLine("Idade: " + novaPessoa.Nome);
            Console.WriteLine(novaPessoa.NomeCompleto());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace PrimeiroProjeto
{
    class Program
    {
        private static List<Pessoa> pessoas = new List<Pessoa>();

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            /*
            Pessoa novaPessoa = new Pessoa("João Victor", 21);

            Console.WriteLine("Nome: " + novaPessoa.ObterNome());
            Console.WriteLine("Idade: " + novaPessoa.ObterIdade());
            */

            Pessoa novaPessoa1 = new Pessoa("João", "Victor", 21);
            Pessoa novaPessoa2 = new Pessoa("Maria", "ddsddd", 25);
            Pessoa novaPessoa3 = new Pessoa("Paulo", "fffff", 26);
            Pessoa novaPessoa4 = new Pessoa("Daniel", "hhhhhh", 31);

            pessoas.Add(novaPessoa1);
            pessoas.Add(novaPessoa2);
            pessoas.Add(novaPessoa3);
            pessoas.Add(novaPessoa4);


            Pessoa pessoaMaior30 = pessoas.Find(p => p.Idade > 25 && p.Idade < 27);
            List<Pessoa> retorno = pessoas.Where(p => p.Idade > 25).ToList();

            foreach (var item in retorno)
            {
                Console.WriteLine(item.Nome);
            }
        }
    }
}

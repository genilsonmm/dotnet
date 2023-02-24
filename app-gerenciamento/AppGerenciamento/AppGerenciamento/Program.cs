using System;
using System.Collections.Generic;
using System.Linq;

namespace AppGerenciamento
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.Write("Digite o código do ativo: ");
            string value = Console.ReadLine();

            Console.Write("Digite a quantidade: ");
            int quantity = int.Parse(Console.ReadLine());
           


            GerenciadorDeAcoes gerenciadorDeAcoes = new GerenciadorDeAcoes();

            try
            {
                Console.WriteLine(gerenciadorDeAcoes.Add("MGLU3", 100));
                Console.WriteLine(gerenciadorDeAcoes.Add("MGLU3", 50));
                Console.WriteLine(gerenciadorDeAcoes.Add("VIVT3", 20));

            }catch(ArgumentException error)
            {
                Console.WriteLine("O ativo já foi adicionado!");
            }

            Console.WriteLine("-------------------------------------------------------");

            var acoes = gerenciadorDeAcoes.GetAll();
            
            foreach (var item in acoes)
            {
                Console.WriteLine($"Ativo: {item.Key} | Quantidade: {item.Value}");
            }


            try
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine($"Ativo: MGLU3 | Quantidade: {gerenciadorDeAcoes.GetByKey("MGLUy")} ");

            }catch(Exception error)
            {
                Console.WriteLine(error.Message);
            }
             */

            Pessoa pessoa1 = new Pessoa();
            pessoa1.Id = 1;
            pessoa1.Idade = 30;
            pessoa1.Nome = "Daniela da Silva";
            pessoa1.Temp = "asdsads";

            var pessoa2 = new Pessoa()
            {
                Id = 2,
                Idade = 24,
                Nome = "João Ferreira"
            };

            Pessoa pessoa3 = new Pessoa() { Id = 3, Idade = 59, Nome = "Maria Joana" };

            List<Pessoa> pessoaList = new List<Pessoa>();
            pessoaList.Add(pessoa1);
            pessoaList.Add(pessoa2);
            pessoaList.Add(pessoa3);

            List<Pessoa> result = pessoaList.Where(p => p.Idade < 30).ToList();

            Console.Write("Olá C#");
            Console.WriteLine("| Olá C#");


            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Você digitou: " + idade);

            int valor = 1;

            Console.ReadLine();

            Console.Clear();

            switch (valor)
            {
                case 1:
                    {
                        //fazer alguma coisa
                    }
                    break;
                case 2:
                    {
                        //Fazer outra coisa
                    }
                    break;
            }
        }
    }
}

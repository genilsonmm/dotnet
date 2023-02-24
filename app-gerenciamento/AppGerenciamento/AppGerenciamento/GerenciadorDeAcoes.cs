using System;
using System.Collections.Generic;
using System.Text;

namespace AppGerenciamento
{
    internal class GerenciadorDeAcoes
    {
        private readonly Dictionary<string, int> acoes;

        public GerenciadorDeAcoes()
        {
            acoes = new Dictionary<string, int>();
        }

        public string Add(string value, int quantity)
        {
            string message = "Ativo adicionado com sucesso";
            
            if (acoes.ContainsKey(value))
            {
                acoes[value] += quantity;
                message = "Quantidade atualizada com sucesso!";
            }
            else { 
                acoes.Add(value, quantity);
            }

            return message;
        }

        public int GetByKey(string key)
        {
            int value = 0;
            if(!acoes.TryGetValue(key, out value))
            {
                throw new Exception("Ativo não encontrado");
            }

            return value;
        }

        public Dictionary<string,int> GetAll()
        {
            return acoes;
        }
    }
}

using MjBanco.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MjBanco.Parceiros
{
    public class ParceiroComercial : IAutenticavel
    {
        public string Nome { get; set; }
        public string CNPJ { get; set; }
        public string Senha { get; set; }

        public ParceiroComercial(string nome, string cnpj, string senha)
        {   
            Nome = nome;
            CNPJ = cnpj;
            Senha = senha;
        }

        //Metodo derivado da interface IAutenticavel
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjBanco.Funcionarios
{
    //Autenticavel é uma classa abstrata derivada de funcionario que tambem é uma classe abstrata
    //o intuito da classe autenticavel é que somente algumas classes como por ex: Diretor e GerenteDeContas possam ser
    //autenticaveis para usar o sistema interno.
    public abstract class Autenticavel : Funcionario
    {
        public string Senha { get; set; }
        public Autenticavel(string nome, string cpf, decimal salario, int cargo, string senha) : base(nome, cpf, salario, cargo)
        {
            Senha = senha;
        }
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }

    }
}

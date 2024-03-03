using MjBanco.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjBanco.Funcionarios
{
    //A classe abstrata funcionarioAutenticavel é derivado da classe funcionario e da interface IAutenticavel.
    //Deste modo devemos implementar a assinatura do metodo implementado na interface, ou seja, na classe que está 
    //sendo derivada da interface, devemos incluir os metodos implementados na interface, pois a interface é um contrato com o metodo.
    public abstract class FuncionarioAutenticavel : Funcionario , IAutenticavel
    {
        public FuncionarioAutenticavel(string nome, string cpf, decimal salario, int cargo, string senha) : base(nome, cpf, salario, cargo)
        {
            Senha = senha;
        }

        public string Senha { get; set; }

        //Metodo derivado da interface IAutenticavel
        public bool Autenticar(string senha)
        {
            return Senha == senha;
        }
    }
}

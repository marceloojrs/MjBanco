using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjBanco.Funcionarios
{
    //classe do tipo abstrata, é uma classe que nao deve ser instanciada pois serve para realizações do polimorfismo
    //uma classe de funcionario que compartilha informaçoes entre demais classes(diretor, auxiliar, desinger...)
    //A classe abstrata nao deve ser instanciada no programa, deve ser direta ser chamado direto da classe concreta
    public abstract class Funcionario
    {
        public Funcionario(string nome, string cpf, decimal salario, int cargo)
        {
            Nome = nome;
            CPF= cpf;
            Salario = salario;
            Cargo = cargo;
            TotalDeFuncionarios++;
        }
        //variavel do tipo estatica, disponivel a qualquer momento e so tem alteração se forçarmos
        public static int TotalDeFuncionarios { get; private set; }
        public int Cargo { get; protected set; }
        public string Nome { get; private set; }
        public string CPF { get; private set; }
        public decimal Salario { get; protected set; }

        //Modificadores virtual e override: Alguns comportamentos possuem implementações diferentes nas classes derivadas,
        //para resolver este problema basta usarmos métodos virtuais e a sobrescrita.
        
        //metodo abstrato que obriga o dev a criar na classe filha a criar este metodo com o tipo override.
        public abstract decimal GetBonificacao();


        //metodo abstrato que obriga o dev a criar na classe filha a criar este metodo com o tipo override.
        public abstract decimal AumentarSalario();
        
    }
}

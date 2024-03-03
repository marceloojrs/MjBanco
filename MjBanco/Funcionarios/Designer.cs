using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjBanco.Funcionarios
{
    //Herança: Aprendemos herança e vimos que, com sua sintaxe bastante simples, ela é importantíssima em qualquer projeto.
    
    public class Designer : Funcionario
    {
        //Construtor herdando as caracteriscas da classe base. somente nome e CPF como obrigatorio na classe diretor,
        //pq na classe base é somente nome e cpf como obrigatorio, porem estamos instanciando o salario e cargo na classe filha
        //dado que o padrao para Designer é salario de 3K e cargo =2. 
        public Designer(string nome, string cpf) : base(nome, cpf, 3000, 2)
        {

        }
        //Polimorfismo: Com isso, foi possível tratar objetos do tipo Diretor como Funcionario e evitar repetição
        //de código e várias sobrecargas iguais.

        //Modificadores virtual e override: Alguns comportamentos possuem implementações diferentes nas classes derivadas,
        //para resolver este problema basta usarmos métodos virtuais e a sobrescrita.
        public override decimal GetBonificacao()
        {
            //base: A classe filha pode fazer referência aos membros da classe base com uso desta palavra reservada.
            return Salario *= 0.17m;
        }
        public override decimal AumentarSalario()
        {
            return Salario *= 1.11m;
        }
    }
}

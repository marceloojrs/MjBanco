﻿using MjBanco.Funcionarios;
using MjBanco.Parceiros;
using MjBanco.Sitemas;

namespace MjBanco
{
    class Program
    {
        static void Main(string[] args)
        {

            //CalcularBonificacao();
            SistemaInterno();

            Console.ReadLine();

        }

        public static void CalcularBonificacao()
        {
            GerenciadorBonificacao gerenciadorBonificacao = new GerenciadorBonificacao();

            Designer pedro = new Designer("Pedro", "833.222.048-39");

            Diretor roberta = new Diretor("Roberta", "159.753.398-04", "abc");

            Auxiliar igor = new Auxiliar("Igor", "981.198.778-53");

            GerenteDeConta camila = new GerenteDeConta("Camila", "326.985.628-89", "1234");

            gerenciadorBonificacao.RegistrarFuncionario(pedro);
            gerenciadorBonificacao.RegistrarFuncionario(roberta);
            gerenciadorBonificacao.RegistrarFuncionario(igor);
            gerenciadorBonificacao.RegistrarFuncionario(camila);

            Console.WriteLine("Total de bonificações do mês " +
                gerenciadorBonificacao.GetTotalBonificacao());
        }

        public static void SistemaInterno()
        {
            SistemaInterno sistemaInterno = new SistemaInterno();
            GerenteDeConta camila = new GerenteDeConta("Camila", "326.985.628-89", "1234");

            Diretor roberta = new Diretor("Roberta", "326.985.628-89", "abc");

            ParceiroComercial pedro = new ParceiroComercial("Pedro", "833.222.048-39", "444");

            sistemaInterno.Logar(camila, "1234");
            sistemaInterno.Logar(roberta, "Abc");
            sistemaInterno.Logar(pedro, "444");

        }
    }
}
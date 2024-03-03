using MjBanco.Funcionarios;
using MjBanco.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjBanco.Sitemas
{
    //A classe sistemaInterno so permite acesso a usuarios que tem a classe base Autenticavel ex: Diretor e GerenteDeContas
    public class SistemaInterno
    {
        //No Metodo Logar estamos chamando dentro do objeto "usuario" que é derivado da classe "FuncionarioAutenticavel"
        //No metodo "Autenticar" se o retorno for verdadeiro ele cairá no IF se for falso cairá no ELSE.
        public bool Logar(IAutenticavel usuario, string senha)
        {
            //chamando metodo Autenticar que foi criado na classe FuncionarioAutenticavel que é derivada da interface IAutenticavel.
            bool usuarioAutenticado = usuario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine($"Bem-vindo ao sistema!");
                return true;
            }
            else
            {
                Console.WriteLine($"Prezado(a) a senha digitada está incorreta, por favor tente novamente!");
                return false;
            }
        }
    }
}

using MjBanco.Funcionarios;
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
        //No Metodo Logar estamos chamando dentro do objeto "usuario" que é derivado da classe "Autenticavel
        //O metodo "Autenticar" se o retorno for verdadeiro ele cairá no IF se for falso cairá no ELSE
        public bool Logar(Autenticavel usuario, string senha)
        {
            bool usuarioAutenticado = usuario.Autenticar(senha);

            if (usuarioAutenticado)
            {
                Console.WriteLine($"Bem-vindo ao sistema {usuario.Nome}!");
                return true;
            }
            else
            {
                Console.WriteLine($"Prezado(a) {usuario.Nome} a senha está incorreta, por favor tente novamente!");
                return false;
            }
        }
    }
}

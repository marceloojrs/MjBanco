using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MjBanco.Funcionarios;

namespace MjBanco.Interfaces
{
    //IAutenticavel é uma interface -> assinatura/contrato de metodos.
    //Interfaces não possuem implementações! Além disto, interfaces não possuem modificador de acesso em seus membros,
    //pois, todas as implementações de interfaces devem expor seus membros publicamente;
    public interface IAutenticavel 
    {
        //Na interface todos os metodos são publicos e não é necessario colocar o "public".
        bool Autenticar(string senha);

    }
}

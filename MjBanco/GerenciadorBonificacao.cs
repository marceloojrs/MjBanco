using MjBanco.Funcionarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MjBanco
{
    public class GerenciadorBonificacao
    {
        private decimal _totalBonificacao;
        
        public void RegistrarFuncionario(Funcionario funcionario)
        {
            _totalBonificacao += funcionario.GetBonificacao();
        }

        public decimal GetTotalBonificacao() 
        { 
            return _totalBonificacao; 
        }
    }
}

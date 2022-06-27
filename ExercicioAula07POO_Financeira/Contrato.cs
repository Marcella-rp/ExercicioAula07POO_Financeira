using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula07POO_Financeira
{
    public abstract class Contrato
    {
        public Guid IdContrato { get; set; }
        public string Contratante { get; set; }
        public decimal Valor { get; set; }
        public int Prazo { get; set; }


        public abstract decimal CalcularPrestacao();

        public virtual void ExibirInfo()
        {
            Console.WriteLine(@$"
O INDENTIFICADOR do contrato é: {IdContrato};
O CONTRATANTE é: {Contratante};
O VALOR do contrato é: R$ {Valor};
O PRAZO do contrato é de: {Prazo} meses;
O valor da PRESTAÇÃO é de: R$ {CalcularPrestacao()}");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula07POO_Financeira
{
    public class ContratoPessoaJuridica : Contrato
    {
        public string Cnpj { get; private set; }
        public string IEEC { get; private set; }

        public ContratoPessoaJuridica(string contratante, decimal valor, int prazo, string cnpj, string ieec)
        {
            IdContrato = Guid.NewGuid();
            base.Contratante = contratante;
            base.Valor = valor;
            base.Prazo = prazo;
            this.Cnpj = cnpj;
            this.IEEC = ieec;
        }

        public override decimal CalcularPrestacao()
        {
            return Math.Round(base.CalcularPrestacao() + 3, 2);
        }

        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine(@$"
O CNPJ do contrato é de: {Cnpj};
A Inscrição Estadual do contrato é: {IEEC}");
        }
    }
}

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
            this.IdContrato = Guid.NewGuid();
            this.Contratante = contratante;
            this.Valor = valor;
            this.Prazo = prazo;
            Cnpj = cnpj;
            IEEC = ieec;
        }

        public override decimal CalcularPrestacao()
        {
            return Math.Round((Valor / Prazo) + 3, 2);
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

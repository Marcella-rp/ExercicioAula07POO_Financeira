using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula07POO_Financeira
{
    public class ContratoPessoaFisica : Contrato
    {
        public string CPF { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public int idade;

        public ContratoPessoaFisica(string contratante, decimal valor, int prazo, string cpf, DateTime datanascimento)
        {
            this.IdContrato = Guid.NewGuid();
            this.Contratante = contratante;
            this.Valor = valor;
            this.Prazo = prazo;
            CPF = cpf;
            DataNascimento = datanascimento;
        }
        public int CalculoIdade()
        {
            idade = DateTime.Now.Year - DataNascimento.Year;
            if (DateTime.Now.DayOfYear < DataNascimento.DayOfYear)
            {
                idade--;
            }
            return idade;
        }
        public override decimal CalcularPrestacao()
        {
            idade = CalculoIdade();
            decimal adicional;
            if (idade <= 30)
            {
                adicional = 1;
            }
            else if (idade <= 40)
            {
                adicional = 2;
            }
            else if (idade <= 50)
            {
                adicional = 3;
            }
            else
            {
                adicional = 4;
            }
            return Math.Round(Valor / Prazo + adicional, 2);
        }
        public override void ExibirInfo()
        {
            base.ExibirInfo();
            Console.WriteLine(@$"
O CPF do contratante é: {CPF};
A IDADE do contratante é: {CalculoIdade()} anos");
        }
    }
}

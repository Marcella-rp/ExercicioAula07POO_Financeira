using System.Text.RegularExpressions;

namespace ExercicioAula07POO_Financeira
{
    public static class Validacoes
    {
        public static string ObterCadastro()
        {
            Console.WriteLine("Nome do contratante: ");
            string contratante = Console.ReadLine().ToUpper().Trim();
            while (string.IsNullOrWhiteSpace(contratante))
            {
                Console.WriteLine(Mensagens.Msg_Wspace);
                contratante = Console.ReadLine().ToUpper().Trim();
            }
            return contratante;
        }
        public static decimal ObterValor()
        {
            decimal valor;
            bool validacao;
            Console.WriteLine("Valor do contrato (R$): ");
            validacao = decimal.TryParse(Console.ReadLine(), out valor);
            while (!validacao || valor <= 0)
            {
                Console.WriteLine(Mensagens.Msg_Formato);
                validacao = decimal.TryParse(Console.ReadLine(), out valor);
            }
            return valor;
        }
        public static int ObterPrazo()
        {
            int prazo;
            bool validacao;
            Console.WriteLine("Prazo do contrato (meses): ");
            validacao = int.TryParse(Console.ReadLine(), out prazo);
            while (!validacao || prazo <= 0)
            {
                Console.WriteLine(Mensagens.Msg_Formato);
                validacao = int.TryParse(Console.ReadLine(), out prazo);
            }
            return prazo;
        }
        public static string ObterCpf()
        {
            Console.WriteLine("CPF do contratante: ");
            string cpf = Console.ReadLine();
            Regex regexCpf = new(@"(\d{3})[.](\d{3})[.](\d{3})-(\d{2})$");
            while (!regexCpf.Match(cpf).Success)
            {
                Console.WriteLine(Mensagens.Msg_Cpf);
                cpf = Console.ReadLine();
            }
            return cpf;
        }
        public static DateTime ObterData()
        {
            Console.WriteLine("Data de nascimento do contratante (dd/mm/aaaa): ");
            DateTime datanascimento = DateTime.MinValue;
            bool validacao = false;
            while (!validacao)
            {
                validacao = (DateTime.TryParse(Console.ReadLine(), out datanascimento));
                if (!validacao)
                {
                    Console.WriteLine(Mensagens.Msg_Data);
                }
                if (datanascimento >= DateTime.Now)
                {
                    Console.WriteLine(Mensagens.Msg_DataF);
                    validacao = false;
                }
            }
            return datanascimento;
        }
        public static string ObterCnpj()
        {
            Console.WriteLine("CNPJ do contratante: ");
            string cnpj = Console.ReadLine();
            Regex regexCnpj = new(@"(\d{2})[.](\d{3})[.](\d{3})\/(\d{4})-(\d{2})");
            while (!regexCnpj.Match(cnpj).Success)
            {
                Console.WriteLine(Mensagens.Msg_Cnpj);
                cnpj = Console.ReadLine();
            }
            return cnpj;
        }
        public static string ObterIeec()
        {
            Console.WriteLine("Inscrição Estadual do contratante: ");
            string ieec = Console.ReadLine();
            Regex regexIeec = new(@"(\d{3})[.](\d{3})[.](\d{3})[.](\d{3})");
            while (!regexIeec.Match(ieec).Success)
            {
                Console.WriteLine(Mensagens.Msg_Ieec);
                ieec = Console.ReadLine();
            }
            return ieec;
        }
    }
}

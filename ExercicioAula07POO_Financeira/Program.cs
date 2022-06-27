using ExercicioAula07POO_Financeira;
namespace ExercicioAula07POO_Financeira
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mensagens.Menu);
            string numeroMenu = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(numeroMenu) || (numeroMenu != "1" && numeroMenu != "2" && numeroMenu != "3"))
            {
                Console.WriteLine(Mensagens.MsgInvalida);
                numeroMenu = Console.ReadLine();
            }
            if (numeroMenu == "1")
            {
                Console.Clear();
                var contratante = Validacoes.ObterCadastro();
                Console.Clear();
                var cpf = Validacoes.ObterCpf();
                Console.Clear();
                var datanascimento = Validacoes.ObterData();
                Console.Clear();
                var valor = Validacoes.ObterValor();
                Console.Clear();
                var prazo = Validacoes.ObterPrazo();
                Console.Clear();
                var pessoa = new ContratoPessoaFisica(contratante, valor, prazo, cpf, datanascimento);
                pessoa.ExibirInfo();
            }
            else if (numeroMenu == "2")
            {
                Console.Clear();
                var contratante = Validacoes.ObterCadastro();
                Console.Clear();
                var cnpj = Validacoes.ObterCnpj();
                Console.Clear();
                var ieec = Validacoes.ObterIeec();
                Console.Clear();
                var valor = Validacoes.ObterValor();
                Console.Clear();
                var prazo = Validacoes.ObterPrazo();
                Console.Clear();
                var empresa = new ContratoPessoaJuridica(contratante, valor, prazo, cnpj, ieec);
                empresa.ExibirInfo();
            }
            else if (numeroMenu == "3")
            {
                Console.WriteLine(Mensagens.MsgEncerrar);
            }
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioAula07POO_Financeira
{
    public static class Mensagens
    {
        public const string Menu = @"Digite o número do menu que deseja seguir: 
(1) - Cadastrar Contrato Pessoa Física
(2) - Cadastrar Contrato Pessoa Jurídica
(3) - Sair";
        public const string MsgInvalida = @"Opção inválida! Por favor, digite novamente";
        public const string Msg_Formato = @"Valor inválido! Por favor, digite novamente";
        public const string MsgEncerrar = @"Ok! Obrigada e até a próxima!";
        public const string Msg_Wspace = @"A informação precisa ser inserida. Por favor, digite novamente";
        public const string Msg_Cpf = @"CPF inválido. Insira no formato XXX.XXX.XXX-XX";
        public const string Msg_Cnpj = @"CNPJ inválido. Insira no formato XX.XXX.XXX/XXXX-XX";
        public const string Msg_Ieec = @"Inscrição Estadual inválida.Insira no formato XXX.XXX.XXX.XXX";
        public const string Msg_Data = @"Data inválida. Insira no formato dd/mm/aaaa";
        public const string Msg_DataF = @"Data no futuro. Insira data no passado";
    }
}

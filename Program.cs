using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUnip
{
    class Program
    {
        static void Main(string[] args)
        {
            //Modificando
            ContaCorrente contaCorrente = new ContaCorrente();
            Console.WriteLine("Escreva o nome do titular:");
            contaCorrente.Nome = Convert.ToString(Console.ReadLine());
            
            Console.WriteLine("informe sua agencia:");
            contaCorrente.AgenciaNumero = Convert.ToString(Console.ReadLine());

            Console.WriteLine("informe o numero de sua conta:");
            contaCorrente.ContaNumero = Convert.ToInt16(Console.ReadLine());

            Console.WriteLine("Coloque seu saldo atual:");
            contaCorrente.saldo = Convert.ToDouble(Console.ReadLine());


            contaCorrente.VerificaArgumentos(contaCorrente);
            
            if(contaCorrente.VerificaArgumentos(contaCorrente)==false)
            {
                Console.WriteLine("Existem campos Em branco por favor preencha novamente");
            }

            ExibeInformacoes(contaCorrente);
            contaCorrente.Depositar(1500);
            Console.WriteLine($"Apos o deposito seu saldo é de : R${contaCorrente.saldo}");
            contaCorrente.Sacar(750);
            Console.WriteLine($"apos o saque, seu saldo atual é de :R${contaCorrente.saldo}.");
            Console.ReadLine();

        }

        private static void ExibeInformacoes(ContaCorrente contaCorrente)
        {
            Console.WriteLine($"Exibindo informaçoes sobre a conta de;{contaCorrente.Nome}");
            Console.WriteLine($"O numero da sua Agencia é:{contaCorrente.AgenciaNumero}");
            Console.WriteLine($"o numero da sua conta é:{contaCorrente.ContaNumero}");
            Console.WriteLine($"o seu saldo atual é de:{contaCorrente.saldo}");
            return;
        }
    }
}

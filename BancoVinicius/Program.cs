using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoVinicius
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta conta;

            Console.Write("Entre com o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());
            
            Console.Write("Entre com o titular da conta: ");
            string titular = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char opcao = char.Parse(Console.ReadLine());            

            if (opcao == 's')
            {
                Console.Write("Entre com o valor do depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine());
                conta = new Conta(numero, titular, depositoInicial);                
            }
            else
            {
                conta = new Conta(numero, titular);
            }

            Console.WriteLine();
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Entre com um valor para deposito: ");
            conta.depositar(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine(conta);
            Console.WriteLine();


            Console.Write("Entre com um valor para saque: ");
            conta.sacar(double.Parse(Console.ReadLine()));

            Console.WriteLine();
            Console.WriteLine(conta);


            Console.WriteLine("TESTANDO GIT");

            Console.ReadLine();
            
        }
    }
}

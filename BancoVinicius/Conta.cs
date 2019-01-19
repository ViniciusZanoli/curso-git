using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoVinicius
{
    class Conta
    {
        const int Taxa = 5;

        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public Conta(int numero, string titular)
        {
            Numero = numero;
            Titular = titular;
        }

        public Conta(int numero, string titular, double depositoInicial) : this(numero, titular)
        {
            depositar(depositoInicial);
        }

        public double depositar(double valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public double sacar(double valor)
        {
            Saldo -= valor + Taxa;
            return 0;
        }

        public override string ToString()
        {
            return "Dados da conta: \n"
                + "Conta " + Numero + ", "
                + "Titular: " + Titular + ", "
                + "Saldo: $ " + Saldo.ToString("F2");
        }

    }
}

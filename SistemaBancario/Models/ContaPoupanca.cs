using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class ContaPoupanca : Conta
    {
        public ContaPoupanca(string titular, decimal saldoInicial) :base(titular, saldoInicial){}

        public override void Sacar(decimal valor)
        {
            Console.Write("Digite o valor para ser sacado: ");
            valor = decimal.Parse(Console.ReadLine());

            if (valor > Saldo)
                Console.WriteLine($"Você não possui saldo para sacar!");
            
            Saldo -= valor;
        }
    }
}
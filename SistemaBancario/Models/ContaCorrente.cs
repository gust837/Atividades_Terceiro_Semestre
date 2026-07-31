using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public class ContaCorrente : Conta
    {
        private const decimal Limite = 200;

        public ContaCorrente(string titular, decimal saldoInicial) :base(titular, saldoInicial){}

        public override void Sacar(decimal valor)
        {
            Console.Write("Digite o valor para ser sacado em R$: ");
            decimal valorSaque = decimal.Parse(Console.ReadLine());

            if (valor > Saldo + Limite)
                Console.WriteLine($"Voce nao possui limite e nem saldo para sacar!");
            
            Saldo -= valor;
        }
    }
}
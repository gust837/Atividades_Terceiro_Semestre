using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SistemaBancario.Models
{
    public abstract class Conta
    {
        public string? Titular { get; }

        public decimal Saldo { get; protected set; } = 100;

        protected Conta(string titular, decimal saldoInicial)
        {
            Titular = titular;

            Saldo = saldoInicial;
        }

        public void Depositar(decimal valor)
        {
            if (valor <= 0)
                throw new ArgumentException("O depósito precisa ser positivo");

            Saldo += valor;
            
        }

        public abstract void Sacar( decimal valor);

        

        
    }
}
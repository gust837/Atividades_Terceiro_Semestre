using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;
using SistemaBancario.Models;

namespace SistemaBancario.Services
{
    public class Banco
    {
        private readonly List<Conta> _contas = [];

        public void Adicionar(Conta conta)
        {
            _contas.Add(conta);
        }

        public void ProcessarMovimentacoes()
        {
            foreach (Conta c in _contas)
            {
                try
                {
                    c.Depositar(50);
                    c.Sacar(120);
                    Console.WriteLine(c.ToString());
                }
                catch (Exception e)
                {
                    
                    Console.WriteLine(e.Message);
                }

                Console.WriteLine();
            }
        }
    }
}
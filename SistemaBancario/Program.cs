using SistemaBancario.Models;
using SistemaBancario.Services;

Banco banco = new();

banco.Adicionar(new ContaCorrente("Celia", 540000));
banco.Adicionar(new ContaPoupanca("Aura", 25000));

banco.ProcessarMovimentacoes();
﻿using System;

namespace ByteBank
{
    public class ContaCorrente
    {
        private static int TaxaOperacao;
        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular { get; set; }
        public int Agencia { get; }
        public int Numero { get; }
        
        public int ContadorSaquesNaoPermitidos { get; private set; }
        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        public ContaCorrente(int agencia, int numero)
        {
            if (agencia <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0", nameof(agencia));
            }

            if (numero <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0", nameof(numero));
            }

            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
            TaxaOperacao = 30 / TotalDeContasCriadas;
        }
        private double _saldo;

        public double Saldo
        {
            get
            {
                return _saldo;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }

                _saldo = value;
            }
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor de saque não pode ser negativo", nameof(valor));
            }            
            if (_saldo < valor)
            {
                ContadorSaquesNaoPermitidos++;
                throw new SaldoInsuficienteException(_saldo, valor);
            }
            else
                _saldo -= valor;
        }
        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                Console.WriteLine("Valor a depositar deve ser maior que zero");
            }
            else
                _saldo += valor;
        }
        public void Transferir(double valor, ContaCorrente contaDestino)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor de transferência não pode ser negativo", nameof(valor));
            }
            else
            {
                try
                {
                    Sacar(valor);
                }
                catch (SaldoInsuficienteException ex)
                {
                    ContadorTransferenciasNaoPermitidas++;
                    throw new OperacaoFinanceiraException("Operação não realizada.", ex);
                }
                contaDestino.Depositar(valor);
            }
        }
    }
}
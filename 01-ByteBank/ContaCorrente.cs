using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    public class ContaCorrente
    {
        public static int TotalDeContasCriadas { get; private set; }
        public Cliente Titular { get; set; }
        private int _agencia;
        public int Agencia
        {
            get
            {
                return _agencia;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _agencia = value;
            }
        }
        public int Numero { get; set; }

        public ContaCorrente(int agencia, int numero)
        {
            Agencia = agencia;
            Numero = numero;
            TotalDeContasCriadas++;
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

        public bool Sacar(double valor)
        {
            if (_saldo < valor)
            {
                return false;
            }
            else
            {
                _saldo -= valor;
                return true;
            }
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
        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (_saldo < valor)
                return false;
            else
            {
                _saldo -= valor;
                contaDestino.Depositar(valor);
                return true;
            }
        }
    }
}
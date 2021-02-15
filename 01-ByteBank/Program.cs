﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Metodo();
            }
            catch (Exception excecao)
            {
                Console.WriteLine(excecao.Message);
                Console.WriteLine(excecao.StackTrace);
            }
            Console.ReadLine();
        }
        
        static void Metodo()
        {
                TestaDivisao(0);
        }
        static void TestaDivisao (int divisor)
        {
            Dividir(10, divisor);
        }
        public static int Dividir(int numero, int divisor)
        {
            ContaCorrente conta = null;
            Console.WriteLine(conta.Saldo);
            return numero / divisor;
        }
    }
}

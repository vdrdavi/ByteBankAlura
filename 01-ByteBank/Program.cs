using System;
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
                ContaCorrente conta1 = new ContaCorrente(1243, 12344);
                ContaCorrente conta2 = new ContaCorrente(1243, 12344);
                conta1.Transferir(10000, conta2);
                //conta1.Sacar(10000);
            }
            catch(OperacaoFinanceiraException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.StackTrace);

                Console.WriteLine("Informações da INNER EXCEPTION (exceção interna):");

                Console.WriteLine(e.InnerException.Message);
                Console.WriteLine(e.InnerException.StackTrace);
            }
            Console.ReadLine();
        }
        
        //static void Metodo()
        //{
        //        TestaDivisao(0);
        //}
        //static void TestaDivisao (int divisor)
        //{
        //    Dividir(10, divisor);
        //}
        //public static int Dividir(int numero, int divisor)
        //{
        //    try
        //    {
        //        return numero / divisor;
        //    }
        //    catch
        //    {
        //        Console.WriteLine("Exceção com numero=" + numero + " e divisor=" + divisor);
        //        throw;
        //    }
        //}
    }
}

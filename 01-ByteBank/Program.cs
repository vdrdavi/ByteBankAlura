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
                ContaCorrente conta = new ContaCorrente(0, 0);
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ParamName);
            }
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

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

        }
        public static int Dividir(int numero, int divisor)
        {
            return numero / divisor;
        }
        static void Metodo()
        {
            TestaDivisao(0);
        }
        static void TestaDivisao (int divisor)
        {
            Dividir(10, divisor);
        }
    }
}

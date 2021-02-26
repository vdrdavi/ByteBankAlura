using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteBank
{
    class Program
    {
        static void Main(string[] args)
        {
            CarregarContas();
            Console.ReadLine();
        }
        private static void CarregarContas()
        {
            LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt");
            try
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.Fechar();
            }
            catch (IOException e)
            {
                leitor.Fechar();
                Console.WriteLine("Exceção do tipo IOexception capturada e tratada");
            }
        }
    }
}

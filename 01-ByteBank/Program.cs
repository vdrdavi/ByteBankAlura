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
            LeitorDeArquivo leitor = null;
            try
            {
                leitor = new LeitorDeArquivo("contas.txt");
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
            catch (IOException e)
            {
                Console.WriteLine("Exceção do tipo IOexception capturada e tratada");
            }
            finally
            {
                if (leitor != null)
                {
                    leitor.Fechar();
                }
            }
        }
    }
}

using System;
using System.Text;

namespace GeradorDeSenhas
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantidade = int.Parse(args[0]);
            string caracteresPossiveis = 
                "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ" +
                "ABCDEFGHIJKLMNOPQRSTUVWXYZÇ".ToLower() + 
                "0123456789" + 
                "%$#@!"
                ;

            Random sorteio = new Random();
            int numeroSorteado = 0;
            StringBuilder password= new StringBuilder();

            for(int t = 0; t < quantidade; t++)
            {
                numeroSorteado = sorteio.Next(0, caracteresPossiveis.Length - 1);
                password.Append(caracteresPossiveis[numeroSorteado]);
            }
            Console.WriteLine();
            Console.Write(password);
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
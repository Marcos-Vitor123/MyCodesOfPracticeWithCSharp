using System;

namespace Funcao
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            FuncaoSemRetorno();
            int resultado = FuncaoComRetorno(1, 3);
            Console.WriteLine(resultado);
        }

        public static void FuncaoSemRetorno()
        {
            int a = 10, 
                b = 4,
                resultado = a + b;

            Console.WriteLine(resultado);
        }

        public static int FuncaoComRetorno(int a, int b)
        {
            return a * b;
        }
    }
}
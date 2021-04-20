using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora___POO
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int contadorOperações = 0;

            while (true)
            {

                string opção = Menu();
                int transfereContador = contadorOperações++;

                Calculadora calculadora = new Calculadora();
                calculadora.OpçãoSelecionada = opção;
                calculadora.ContadorOperações = transfereContador;

                calculadora.Operações();              

               
                Console.Clear();
            }
        }

        private static string Menu()
        {                        
                Console.WriteLine("Calculadora 2.0 - POO");
                Console.WriteLine();
                Console.WriteLine("Digite 1 para somar");
                Console.WriteLine("Digite 2 para subtrair");
                Console.WriteLine("Digite 3 para multiplicar");
                Console.WriteLine("Digite 4 para dividir");
                Console.WriteLine("Digite 5 para visualizar as operações");
                Console.WriteLine();
                Console.WriteLine("Digite 6 para sair");
                string opção = Console.ReadLine();

           
            return opção;
        }

        public static void VerificaOpção(string opção)
        {
            double verificaOpção;

            if (double.TryParse(opção, out verificaOpção) == false)
            {
                Console.WriteLine("Opção inválida, tente novamente");
                Console.ReadLine();
                Console.Clear();
            }
        } 
               
    }
}





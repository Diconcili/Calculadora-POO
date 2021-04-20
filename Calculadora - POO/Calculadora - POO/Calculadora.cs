using System;

namespace Calculadora___POO
{
    class Calculadora
    {
        string opçãoSelecionada;
        double valor1;
        double valor2;
        string simboloOperação;
        int contadorOperações;
        string[] históricoOperações;
        double resultado;

        public string OpçãoSelecionada { get => opçãoSelecionada; set => opçãoSelecionada = value; }
        public double Valor1 { get => valor1; set => valor1 = value; }
        public double Valor2 { get => valor2; set => valor2 = value; }
        public string SimboloOperação { get => simboloOperação; set => simboloOperação = value; }
        public int ContadorOperações { get => contadorOperações; set => contadorOperações = value; }
        public string[] HistóricoOperações { get => históricoOperações; set => históricoOperações = value; }
        public double Resultado { get => resultado; set => resultado = value; }

        public static void VerificaOpção(string opçãoSelecionada)
        {
            double verificaOpção;

            if (double.TryParse(opçãoSelecionada, out verificaOpção) == false)
            {
                Console.WriteLine("Opção inválida, tente novamente");
                Console.ReadLine();               
            }
            
        } 

        public void Operações()
        {
           VerificaOpção(OpçãoSelecionada);

           string operação = $"O resultado de {Valor1} {SimboloOperação} {Valor2} é: {Resultado}";
            HistóricoOperações[ContadorOperações] = operação; 
            
            switch (OpçãoSelecionada)
                {
                    case "1":
                        SolicitaNumeros(); Soma(); 
                        break;

                    case "2":
                        SolicitaNumeros(); Subtração(); 
                        break;

                    case "3":
                        SolicitaNumeros(); Multiplicação(); 
                        break;

                    case "4":
                        SolicitaNumeros(); Divisão(); 
                        break;

                    case "5":
                    for (int i = 0; i < ContadorOperações; i++)
                    {
                        Console.WriteLine(operação[i]);
                    }
                    
                    Console.WriteLine(operação);
                    Console.ReadLine();
                    break;

                case "6": break;

                    default: break;
                }            
        }

        public void Divisão()
        {
            if (OpçãoSelecionada == "4" && Valor2 != 0)
            {                
                Resultado = Valor1 / Valor2;
                SimboloOperação = "/";
                Console.WriteLine($"Divisão entre {Valor1} e {Valor2} é: {Resultado}");
            } else if (OpçãoSelecionada == "4" && Valor2 == 0)
            {
                Console.WriteLine("Operação indefinida");
            }
        }
    

        public void Multiplicação()
        {
            if (OpçãoSelecionada == "3")
            {
                Resultado = Valor1 * Valor2;
                SimboloOperação = "*";
                Console.WriteLine($"Multiplicação entre {Valor1} e {Valor2} é: {Resultado}");
                Console.ReadLine();
            }
            
        }

        public void Subtração()
        {
            if (OpçãoSelecionada == "2")
            {
                Resultado = Valor1 - Valor2;
                SimboloOperação = "-";
                Console.WriteLine($"Subtração entre {Valor1} e {Valor2} é: {Resultado} ");
                Console.ReadLine();
            }         
        }

        public void Soma()
        {
            if (OpçãoSelecionada == "1")
            {
                Resultado = Valor1 + Valor2;
                SimboloOperação = "+";
                Console.WriteLine($"Soma entre {Valor1} e {Valor2} é: {Resultado}");
                Console.ReadLine();
            }            
        }

        public void VerificaValor(double valor)
        {
            double verifica;
            string valorTxt = valor.ToString();
            if (double.TryParse(valorTxt, out verifica) == false)
            {
                Console.WriteLine("Valor inválido, digite novamente");
            }
        }

        public void SolicitaNumeros()
        {
            System.Console.WriteLine("Digite o primeiro valor");
            Valor1 = Convert.ToDouble(Console.ReadLine());
            VerificaValor(Valor1);

            System.Console.WriteLine("Digite o segundo valor");
            Valor2 = Convert.ToDouble(Console.ReadLine());
            VerificaValor(Valor2);
        }

        public void ApresentarMenagem()
        {

        }

    }
}

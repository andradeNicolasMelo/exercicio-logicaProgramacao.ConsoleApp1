//Crie um programa para calcular o volume de uma caixa retangular

using System.Text;

namespace exercicio_logicaProgramacao.ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Programas disponiveis:");
                Console.WriteLine("1 - Calcular o volume do paralelepipido");
                Console.WriteLine("2 - Calcular o volume do cilindro");
                Console.WriteLine("3 - Calculador de gasto de gasolina");
                Console.WriteLine("4 - Conversor de Celsius para Fahrenheit");
                Console.WriteLine("5 - Calculador de salario");
                Console.WriteLine("6 - Calculador da média");
                Console.WriteLine("7 - Verificador de numeros primos");
                Console.WriteLine();
                Console.Write("Qual opção você escolhe? ");
                string opc = Console.ReadLine()!;

                if (opc == "1")
                {
                    CalcularVolumeRetangulo();
                }

                else if (opc == "2")
                {
                    CalcularVolumeCilindro();
                }

                else if (opc == "3")
                {
                    CalcularGasolina();
                }

                else if (opc == "4")
                {
                    ConversorDeTemperatura();
                }

                else if (opc == "5")
                {
                    CalculadorSalario();
                }

                else if (opc == "6")
                {
                    CalculadorMedia();
                }

                else if (opc == "7")
                {
                    VerificadorNumPrimo();
                }
            }
        }

        static void CalcularVolumeRetangulo()
        {
            Console.Clear();

            Console.WriteLine("Calculo do volume do Paralelepipido");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");
            
            Console.Write("Qual o comprimento? ");
            int comprimento = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            
            Console.Write("Qual a largura? ");
            int largura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Qual a altura? ");
            int altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            int volume = (comprimento * largura) * altura;   

            Console.WriteLine("====================================");
            Console.WriteLine($"O volume do paralelepipido é: {volume}cm");
            Console.WriteLine("====================================");

            Console.ReadLine();
        }

        static void CalcularVolumeCilindro()
        {
            Console.Clear();
            Console.WriteLine("Calculo do volume do Cilindro");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");

            Console.Write("Qual o raio? ");
            decimal raio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Qual a altura? ");
            decimal altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            decimal complemento = 3.14m;
            Console.Write($"o complemento é {complemento}");
            Console.WriteLine("");

            decimal volume = complemento *(raio * raio)* altura;
            Console.WriteLine();
            
            Console.WriteLine("====================================");
            Console.WriteLine($"O volume do cilindro é: {volume}cm");
            Console.WriteLine("====================================");

            Console.ReadLine();
        }

        static void CalcularGasolina()
        {
            Console.Clear();
            Console.WriteLine("Calculo da gasolina que sera gasta");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");

            Console.Write("Qual o km inicial? ");
            decimal kmInicial = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Qual o km final? ");
            decimal kmFinal = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("O veiculo consome quantos litros de gasolina? ");
            decimal gasolina = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine();

            decimal gasolinaGasto = (kmFinal-kmInicial)/gasolina;

            Console.WriteLine("====================================");
            Console.WriteLine($"Voce vai gastar {gasolinaGasto} litros de gasolina");
            Console.WriteLine("====================================");

            Console.ReadLine();
        }

        static void ConversorDeTemperatura()
        {
            Console.Clear();
            Console.WriteLine("Conversor de Celsius para Fahrenheit");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");

            Console.Write("Quantos graus celsius? ");
            decimal graus = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");

            decimal fahrenheit = ((graus * 9) / 5) + 32;

            Console.WriteLine("====================================");
            Console.WriteLine($"Graus Celsius:{graus} / Fahrenheit: {fahrenheit}");
            Console.WriteLine("====================================");

            Console.ReadLine();
        }

        static void CalculadorSalario()
        {
            Console.Clear();
            Console.WriteLine("Calculador de salario");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");

            decimal salarioBase = 1600.00m;

            Console.Write("Quantos reais em vendas? ");
            decimal vendas = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");

            Console.Write("Qual a porcentagem do lucro: ");
            decimal porcentagem = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("");

            decimal salarioFinal = porcentagem * vendas / 100;

            Console.WriteLine("====================================");
            Console.WriteLine($"Salario final do vendedor é: {salarioFinal}");
            Console.WriteLine("====================================");

            Console.ReadLine();
        }

        static void CalculadorMedia()
        {
            //nota 1 (peso 1) | nota 2 (peso 3)

            Console.Clear();
            Console.WriteLine("Calculador de media ponderada");
            Console.WriteLine("---------------------------------------");
            Console.WriteLine("");

            Console.WriteLine("Primeira nota? ");
            decimal nota1 = Convert.ToDecimal(Console.ReadLine());
            int peso1 = 1;

            Console.WriteLine("Segunda nota? ");
            decimal nota2 = Convert.ToDecimal(Console.ReadLine());
            int peso3 = 3;

            decimal numerador = (peso1 * nota1) + (peso3 * nota2);
            int denominador = peso3 + peso1;

            decimal calculo = numerador / denominador;

            Console.WriteLine("====================================");
            Console.WriteLine($"A media ponderada é: {calculo}");
            Console.WriteLine("====================================");

            Console.ReadLine();
        }

        static void VerificadorNumPrimo()
        {
            Console.Write("Digite um numero: ");
            int numDigitado = Convert.ToInt32(Console.ReadLine());
            int numPrimo = numDigitado % 2;

            if(numPrimo == 0)
            {
                Console.WriteLine("numero primo");
            }
            else
            {
                Console.WriteLine("nao é numero primo");
            }

            Console.ReadLine();

        }
    }
}

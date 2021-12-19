using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            bool operador = true;
            double operacao=0;
            string str;
            string[] strArr;
            Console.WriteLine("Digite a operação que deseja calcular. (exemplo 2*3)");
            str = Console.ReadLine();
            foreach (char indice in str)
            {
                switch (indice)
                {
                    case '+':
                        strArr = str.Split('+');
                        operador = false;
                        operacao = Calculadora.Soma(Convert.ToDouble(strArr[0]), (Convert.ToDouble(strArr[1])));
                        break;
                    case '-':
                            strArr = str.Split("-");
                        operador = false;
                        operacao = Calculadora.Subtracao(Convert.ToDouble(strArr[0]), (Convert.ToDouble(strArr[1])));
                        break;
                    case '/':
                        strArr = str.Split("/");
                        operador = false;
                        operacao = Calculadora.Divisao(Convert.ToDouble(strArr[0]), (Convert.ToDouble(strArr[1])));
                        break;
                    case '*':
                        strArr = str.Split("*");
                        operador = false;
                        operacao = Calculadora.Multiplicacao(Convert.ToDouble(strArr[0]), (Convert.ToDouble(strArr[1])));
                        break;
                    default:
                        
                        break;
                }
            }
            if (operador)
            {
                Console.WriteLine("Não foi possível identificar a operação inserida. Verifique se os operadores abaixo foram utilizados corretamente ");
                Console.WriteLine("+ para soma");
                Console.WriteLine("- para subtração");
                Console.WriteLine("* para multiplicação");
                Console.WriteLine("/ para divisão");
            }
            else
            {
                Console.WriteLine($"{str} = {operacao}");
            }

        }
    }
}

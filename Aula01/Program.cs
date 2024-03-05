
//altere o programa para calcular o imc de uma pessoa
// imc = peso / altura * altura
using Aula01;
using System.Globalization;

bool entrada = true;
do
{
    try
    {
        Console.WriteLine("Informe o n1 ");
        int n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Informe o n2 ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        Calculadora calculo = new Calculadora();
        Console.WriteLine(calculo.Soma(n1, n2));

        //Console.WriteLine("Informe o peso atual: ");
        //int peso = Convert.ToInt32(Console.ReadLine());
        //Console.WriteLine("Informe a altura atual: ");
        //float altura = float.Parse(Console.ReadLine());
        //CalculaIMC calculaIMC = new CalculaIMC();
        //Console.WriteLine( calculaIMC.Calcular(peso, altura));
        //string resultado=calculaIMC.Calcular(peso, altura);
        //Console.WriteLine(resultado);
     
        entrada = false;
    }
    catch (FormatException e)
    {
        Console.WriteLine("O peso deve ser um número inteiro e a altura em numero decimal");
    }
} while (entrada);




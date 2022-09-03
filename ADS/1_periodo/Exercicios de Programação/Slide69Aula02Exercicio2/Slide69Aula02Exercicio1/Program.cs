internal class Program
{
    private static void Main(string[] args)
    {
        double valor1, valor2, soma, subtr, divis, multip;
        Console.WriteLine("Insira o primeiro valor");
        valor1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o segundo valor");
        valor2 = Convert.ToDouble(Console.ReadLine());
        soma = valor1+valor2;
        subtr = valor1-valor2;
        divis = valor1/valor2;
        multip = valor1*valor2;

        Console.WriteLine("A soma dos dos números indicados é {0}, a subtração entre os números indicados é {1}, a multiplicação entre os números indicasos é {2} e a divisão entre os números é {3}", soma, subtr, multip, divis);




    }
}
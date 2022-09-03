internal class Program
{
    static double Contas (double a, double b)
{ 
    double result = Math.Pow((Math.Pow(a,2)+Math.Pow(b,2)),0.5);
    return result;   
    
}
    private static void Main(string[] args)
    { 
        double valor1,valor2,resultado;
        Console.WriteLine("Insira o primeiro valor");
        valor1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o segundo valor");
        valor2 = Convert.ToDouble(Console.ReadLine());
        resultado = Contas (valor1,valor2);
        Console.WriteLine("O valor da função é {0:N2}",resultado);
    }
}
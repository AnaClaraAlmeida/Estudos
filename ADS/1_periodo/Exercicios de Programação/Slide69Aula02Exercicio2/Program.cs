internal class Program
{
    private static void Main(string[] args)
    {
        double peso, alt, imc;
        Console.WriteLine("Insira seu peso em kg");
        peso = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira sua altura em metros");
        alt = Convert.ToDouble(Console.ReadLine());
        imc = peso/(alt*alt);
        Console.WriteLine("Seu IMC é de {0}",imc);
        
            
        }


    }

internal class Program
{

    private static void Main(string[] args)

    {   int valorinicial, h, m, s;
        Console.WriteLine("insira a quantidade de segundos");
        valorinicial = Convert.ToInt32(Console.ReadLine());
    
   h = valorinicial/3600;
   m = (valorinicial-(3600*h))/60;
   s = (valorinicial-(3600*h))%60;

    Console.WriteLine("{0} segundos correspondem à {1} horas {2} minutos e {3} segundos",valorinicial,h,m,s);
    }
}
internal class Program
{
    private static void Main(string[] args)
    { 
        double s, v, t, s0, v0, a;
        Console.WriteLine("Insira a posição inicial");
        s0 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira a velocidade inicial");
        v0 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira a acelareção");
        a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o instante");
        t = Convert.ToDouble(Console.ReadLine());

        s = s0+v0*t+(a*t*t)/2.0;
        v = v0+a*t;

        Console.WriteLine("De acordo com as informações inseridas, a posição é {0} e a velocidade é {1}.",s,v);




    }
}
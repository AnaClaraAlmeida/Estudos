internal class Program
{   

    static double Volume (double r)
    {
        double v = (4*3.14*Math.Pow(r,3))/3.0;
        return v; 
    


    }

    private static void Main(string[] args)
    {   double raio, vol;
        Console.WriteLine("Insira o raio");
        raio = Convert.ToDouble(Console.ReadLine());
        vol = Volume (raio);
        Console.WriteLine("O Volume da esfera é {0:N2}.",vol);




    }
}
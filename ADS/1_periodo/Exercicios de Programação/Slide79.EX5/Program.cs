internal class Program
{

    static double dist (double x1, double x2, double y1, double y2)
    { 
        double distan = ((x2-x1)*(x2-x1))+((y2-y1)*(y2-y1));
        double distanraiz = Math.Sqrt(distan);
        return distanraiz;
    }

   /* static void Main(string[] args)
    { 
        double distancia, lat1, lat2, long1, long2;

        Console.WriteLine("Insira o valor da primeira latitude");
        lat1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o valor da primeira longitude");
        long1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o valor da segunda latitude");
        lat2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira o valor da segunda longitude");
        long2 = Convert.ToDouble(Console.ReadLine());
        distancia = dist(lat1, lat2, long1, long2);
        Console.WriteLine("A distância entre os pontos é de {0:N2}",(distancia));
    }*/

     static void Main(string[] args)
    {
        double x1,y1,x2,y2,x3,y3,d1,d2,d3,peri;
        Console.WriteLine("Insira latitude do primeiro ponto");
        x1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira longitudo do primeiro ponto");
        y1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira latitude do segundo ponto");
        x2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira longitude do segundo ponto");
        y2 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira latitude do terceiro ponto");
        x3 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira longitude do terceiro ponto");
        y3 = Convert.ToDouble(Console.ReadLine());
        
        d1 = dist (x1,y1,x2,y2);
        d2 = dist (x2,y2,x3,y3);
        d3 = dist (x3,y3,x1,y1);
        peri= d1+d2+d3;

        Console.WriteLine("O perímetro do triângulo é {0:N2}",peri);
    
       



    }

}
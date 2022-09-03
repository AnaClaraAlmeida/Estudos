internal class Program
{
    static double NotasMedias (double P1, double P2)
{   double P3 = (((5.0*4.0)-P1)-P2)/2.0;
    return P3;
}
    static void Main(string[] args)
    {   
        double nota1,nota2,nota3minima;

        Console.WriteLine("Insira a primeira nota");
        nota1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira a segunda nota");
        nota2 = Convert.ToDouble(Console.ReadLine());
        nota3minima = NotasMedias (nota1,nota2);
        Console.WriteLine("A nota mínima da terceira prova para se atingir a média é de {0}",nota3minima);
    }
}
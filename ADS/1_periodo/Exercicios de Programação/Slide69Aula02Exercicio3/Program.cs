internal class Program
{
    private static void Main(string[] args)
    {
       double comp, alt, larg, volu;
        Console.WriteLine("Insira o comprimento");
        comp = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira a altura");
        alt = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira a largura");
        larg = Convert.ToDouble(Console.ReadLine());
        volu = alt*larg*comp;

        Console.WriteLine("O volume da sua caixa é {0}",volu);

    }
}
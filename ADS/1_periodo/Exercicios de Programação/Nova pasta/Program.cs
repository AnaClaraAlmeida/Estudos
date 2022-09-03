internal class Program
{
    private static void Main(string[] args)
    {
    int conversor, hora, min, sec, hora1;
Console.Write("Escreva o valor pra ser convertido");
conversor = Convert.ToInt32(Console.ReadLine());
hora = conversor/3600;
hora1 = conversor%3600;
min = hora1/60;
sec = hora1%60;


Console.WriteLine(hora);
Console.WriteLine(min);
Console.WriteLine(sec);;
    }
}
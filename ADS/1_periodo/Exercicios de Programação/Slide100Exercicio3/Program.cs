internal class Program
{
    static void Calculo (int anos,int meses,int dias)
{
    int a = anos*365;
    int m = meses*30;
    int total = a+m+dias;
    Console.WriteLine("A idade fornecida corresponde a {0}",total);
}

    static void Main(string[] args)
    { 
        int ano, mes, dia;
        Console.WriteLine("Insira os anos");
        ano = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira os meses");
        mes = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Insira os dias");
        dia = Convert.ToInt32(Console.ReadLine());
        Calculo (ano,mes,dia);
    }
}
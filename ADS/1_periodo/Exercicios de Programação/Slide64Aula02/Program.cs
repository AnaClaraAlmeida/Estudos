internal class Program
{
    private static void Main(string[] args)
    {
         /*int dia, mes, ano;
         Console.WriteLine("Exercicio 01: Informe dia de nascimento");
         dia = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Informe mês de nascimento");
         mes = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Informe o ano de nascimento");
         ano = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("Você nasceu no dia {0}",dia);
         Console.WriteLine("Você nasceu no mês {0}",mes);
        Console.WriteLine("Você nasceu no ano {0}",ano);*/

        /*double valor = 2.346728;
        Console.WriteLine("Exercício 2: Aqui está o número {0} com 1 casa decimal: {0:N1}, 2 casas: {0:N2}, 3 casas: {0:N3} e 5 casas: {0:N5} ",valor);*/

        double valorproduto, valordesconto, valorfinal;
        Console.WriteLine("Qual o valor total do produto?");
        valorproduto = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Insira do valor do desconto que deseja aplicar");
        valordesconto = Convert.ToDouble(Console.ReadLine());
        valorfinal = valorproduto-valordesconto;
        Console.WriteLine("O valor do produto com desconto é {0:N2}",valorfinal);






    
    
    
    }
}

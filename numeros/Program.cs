namespace numeros;

public class Program
{
    static void Main(string[] args)
    {
        //Fazer um progama que lê números inteiros até que um zero seja lido pelo programa. Ao final mostrar a soma
        //dos numeros lidos.

        int N, soma;

        Console.WriteLine("Por favor digite um numero inteiro...");
        Console.Write("Numero = ");
        N = int.Parse(Console.ReadLine());

        soma = 0;

        while(N != 0)
        {
            soma = soma + N;

            N++;
            
            Console.Write("Digite outro numero por favor = ");
            N = int.Parse(Console.ReadLine());

            
        }
            Console.WriteLine("Soma dos valores digitados = " + soma);

    }
}
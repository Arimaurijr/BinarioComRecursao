using System;

internal class Program
{
    private static void Main(string[] args)
    {

        int quociente;
        int numero;
        int[] vetor = new int[8];
        int indice = 0;

        Console.WriteLine("DIGITE UM NÚMERO: ");
        numero = int.Parse(Console.ReadLine());

        while(numero < 0)
        {
            Console.WriteLine("DIGITE UM NÚMERO: ");
            numero = int.Parse(Console.ReadLine());
        }

        Conversao(numero);

        int[] Conversao(int quociente)
        {
            if (quociente == 0)
            {
                return vetor;
            }
            else
            {
                if (quociente == 1)
                {
                    vetor[indice] = quociente;
                    return vetor;
                }
                else
                {
                    vetor[indice] = quociente % 2;
                    indice++;
                    //quociente = quociente / 2;
                    return Conversao(quociente / 2);
                }
            }
        }

        
        for(int i = 7; i >= 0; i--) 
        {
            Console.Write(vetor[i]);
        }
    }
}
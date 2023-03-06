internal class Program
{
    private static void Main(string[] args)
    {
        int quociente;
        int numero;
        int[] vetor = new int[8];
        int indice = 0;

        Console.WriteLine("Digite um valor: ");
        numero = int.Parse(Console.ReadLine());

        Conversao(numero);

        int[] Conversao(int quociente)
        {
           
            if(quociente ==  1)
            {
                vetor[indice] = quociente;
                return vetor;
            }
            else
            {
                vetor[indice] = quociente % 2;
                indice++;
                quociente = quociente / 2;
                return Conversao(quociente);
            }
        }

        for(int i = 7; i >= 0; i--) 
        {
            Console.Write(vetor[i]);
        }

    }
}
namespace calcularFactorial
{
    internal class Program
    {

        static public long metodoFactorial(int numero) 
        {
            if (numero == 1)return 1;
            else
            {
                return numero*(metodoFactorial(numero -1));
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un numero");
            int num1=Int32.Parse(Console.ReadLine());
            int resultadofactorial = 1;

            for (int i=num1; i>=1; i--)
            {
                resultadofactorial = resultadofactorial*i;
            }
            Console.WriteLine(metodoFactorial(num1));
        }
    }
}

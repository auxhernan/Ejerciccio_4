using System.Runtime.Serialization.Formatters;

namespace Ejercicio_4
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("Numero decimal");
            
            int numero = Convert.ToInt32(Console.ReadLine());
            
            long binario = decimalBinario(numero);
            Console.WriteLine("numero decimal" +numero+"en binario es"+binario);
            
            long decimalb = binarioDecimal(binario);            
            Console.WriteLine("numero binario"+binario+"en decimal es"+decimalb);

        }

        public static long decimalBinario (int numerodecimal)
        {
            if (numerodecimal < 0)
            {
                return -1;
            }

            long binario = 0;
            long digito;
            const int divisor = 2;

            for (int i = numerodecimal,  j = 0; i > 0; i /= divisor, j++)
                {
                digito = i % divisor;
                Console.WriteLine(Convert.ToInt64(Math.Pow(10, j))); binario += digito * Convert.ToInt64(Math.Pow(10,j));
                }
            return binario;
        }
        
        public static long binarioDecimal(long binario)
        {
            if (binario<0)
            {
                return -1;
            }

            long numerodecimal = 0;
            long digito;
            const long divisor = 10;

            for (long i=binario, j=0; i > 0; i /= divisor, j++)
            {
                digito = (int) digito % divisor;
                if (digito !=0 && digito !=1)
                {
                    return -1;
                }

                numerodecimal += digito * Convert.ToInt64(Math.Pow(2,j));
            }

            return numerodecimal;
        }

    }
}
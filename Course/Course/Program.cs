namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int result = somar(10, 55);
            Console.WriteLine(result);
            int[] numeros = {1,2,3,4,5,22,54,32,12,89,54};
            listarNumerosPares(numeros);
        }

        public static int somar(int a, int b)
        {
            return a + b;
        }

        public static void listarNumerosPares(int[] numeros)
        {
            foreach (int numero in numeros)
            {
                if ((numero % 2) == 0)
                {
                    Console.WriteLine(numero + " É par!");
                }
            }
        }

    }
}

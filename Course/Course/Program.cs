namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            //int result = somar(10, 55);
            //Console.WriteLine(result);
            int[] numeros = {1,2,3,4,5,22,54,32,12,89,54};
            //listarNumerosPares(numeros);

            //Listar Numeros Pares usando Linq
            int max = numeros.Max(n => n);
      
            Console.WriteLine(max);
          
            BankAccount bankAccount_Yuri = new BankAccount("Yuri", 0001, 112233);
            BankAccount bankAccount_Mylena = new BankAccount("Mylena", 0002, 223344);

            Console.WriteLine(bankAccount_Yuri.getOwner() + " - " + bankAccount_Yuri.getAmount());
            Console.WriteLine(bankAccount_Mylena.getOwner() + " - " + bankAccount_Mylena.getAmount());

            bankAccount_Yuri.deposit(60.0);
            bankAccount_Yuri.withdraw(30);
            Console.WriteLine(bankAccount_Yuri.getOwner() + " - " + bankAccount_Yuri.getAmount());
            Console.WriteLine(bankAccount_Mylena.getOwner() + " - " + bankAccount_Mylena.getAmount());

            bankAccount_Yuri.transfer(-10, bankAccount_Mylena);
            Console.WriteLine(bankAccount_Yuri.getOwner() + " - " + bankAccount_Yuri.getAmount());
            Console.WriteLine(bankAccount_Mylena.getOwner() + " - " + bankAccount_Mylena.getAmount());
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

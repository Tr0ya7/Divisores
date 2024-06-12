namespace exrc_for { 
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um valor inteiro :");

            int value = int.Parse(Console.ReadLine()); //valor deve começar como uma string para evitar erros lógicos no for

            for (int i = 1; i <= value; i++) //começar como i = 1 para evitar erros
            {   
                if (value % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
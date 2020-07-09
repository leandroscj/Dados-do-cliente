using System;

namespace Dados_do_cliente
{
    public static class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o numero da conta: ");
            int conta = int.Parse(Console.ReadLine());

            Console.Write("Digite o nome do titular da conta :");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito na conta? (s/n) ");
            string afirmacao = Console.ReadLine();

            if (afirmacao == "s")
            {
                Console.Write("Digite o valor do depósito: ");
            }

            double deposito = double.Parse(Console.ReadLine());

            Cliente c = new Cliente(nome, conta, deposito);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);

            Console.Write("Digite um valor para depósito: ");
            double depositoc = double.Parse(Console.ReadLine());
            c.Deposito(depositoc);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);


            Console.Write("Digite um valor para saque: ");
            double saquec = double.Parse(Console.ReadLine());
            c.Saque(saquec);

            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c);



        }
    }
}

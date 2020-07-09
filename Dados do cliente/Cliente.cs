namespace Dados_do_cliente
{
    class Cliente
    {
        public int NumeroConta { get; private set; }
        public string Nome { get; private set; }
        public double Saldo { get; private set; }

        public Cliente(string nomeC, int numeroConta, double saldoC)
        {
            NumeroConta = numeroConta;
            Nome = nomeC;
            Saldo = saldoC;
        }

        public void Deposito(double deposito)
        {
            Saldo += deposito;
        }
        public void Saque(double saque)
        {
            Saldo -= saque + 5; 
        }

        public override string ToString()
        {
            return "Conta: " + NumeroConta + ", Titular: " + Nome + ", Saldo: " + Saldo.ToString("F2");
        }
    }
    
}

using ByteBank.Titular;

namespace ByteBank.Contas
{
    public class ContaCorrente
    {
        public static double TaxaOperacao { get; private set; }

        public static int TotalDeContasCriadas { get; private set; }

        public int ContadorSaquesNaoPermitidos { get; private set; }

        public int ContadorTransferenciasNaoPermitidas { get; private set; }

        private int numeroAgencia;
        public int NumeroAgencia
        {
            get { return this.numeroAgencia; }
            private set 
            {
                if (value > 0)
                {
                    this.numeroAgencia = value;
                }
            }
        }

        public string Conta { get; }

        private double saldo = 100;

        public Cliente Titular { get; set; }

        public void Depositar(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor de depósito não pode ser negativo", nameof(valor));
            }

            saldo += valor;
        }

        public void Sacar(double valor)
        {
            if (valor < 0)
            {
                ContadorSaquesNaoPermitidos++;
                throw new ArgumentException("Valor de saque não pode ser negativo", nameof(valor));
            }

            if (valor <= saldo)
            {
                saldo -= valor;
            }
            else
            {
                throw new SaldoInsuficienteException(saldo, valor);
            }
        }

        public bool Transferir(double valor, ContaCorrente destino)
        {
            try
            {
                Sacar(valor);
            }
            catch (SaldoInsuficienteException ex)
            {
                ContadorTransferenciasNaoPermitidas++;
                throw new OperacaoFinanceiraException("Operação não realizada.", ex);
            }

            destino.Depositar(valor);
            return true;
        }

        public void SetSaldo(double valor)
        {
            if (valor < 0)
            {
                throw new ArgumentException("Valor de saldo não pode ser negativo", nameof(valor));
            }
            else
            {
                this.saldo = valor;
            }
        }

        public double GetSaldo()
        {
            return this.saldo;
        }

        public ContaCorrente(int numeroAgencia, string numeroConta)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = numeroConta;

            //TaxaOperacao = 30 / TotalDeContasCriadas;
            if(numeroAgencia <= 0)
            {
                throw new ArgumentException("O argumento agencia devem ser maiores que 0.", nameof(numeroAgencia));
            }
            

            TotalDeContasCriadas++;
        }

        public ContaCorrente(int numeroAgencia, string numeroConta, double saldo, string nome, string cpf, string profissao)
        {
            this.NumeroAgencia = numeroAgencia;
            this.Conta = numeroConta;
            this.SetSaldo(saldo);
            this.Titular = new Cliente(nome, cpf, profissao);
            TotalDeContasCriadas++;
        }

        //Adaptei exemplo do professor
        public ContaCorrente(Cliente Titular, string numeroConta, int numeroAgencia, double saldo)
        {
            this.Titular = Titular;
            this.Conta = numeroConta;
            this.NumeroAgencia = numeroAgencia;
            this.SetSaldo(saldo);
            TotalDeContasCriadas++;
        }


    }
}
using ByteBank.Contas;
using ByteBank.Titular;
using System.Numerics;

namespace ByteBank
{ 
    class Program
    {
        static void Main(string[] args) 
        {
            CarregarContas();

            //ContaCorrente conta = new ContaCorrente(7480, "874250");
            //Console.WriteLine(ContaCorrente.TaxaOperacao);
            //try
            //{
            //    ContaCorrente conta = new ContaCorrente(5265, "52665");
            //    ContaCorrente conta2 = new ContaCorrente(5245, "52665");

            //    conta.Depositar(50);
            //    Console.WriteLine(conta.GetSaldo());
            //    //conta.Sacar(500);
            //    conta.Transferir(500, conta2);
            //    Console.WriteLine(conta.GetSaldo());
            //}
            //catch (ArgumentException ex)
            //{
            //    Console.WriteLine("Erro do parametro: " + ex.ParamName);
            //    Console.WriteLine("Ocorreu um erro do tipo ArgumentException");
            //    Console.WriteLine(ex.StackTrace);
            //    Console.WriteLine(ex.Message);
            //}
            //catch (OperacaoFinanceiraException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //    Console.WriteLine(ex.StackTrace);

            //    Console.WriteLine("Informação da INNER EXCEPTION (exceçao interna):");

            //    Console.WriteLine(ex.InnerException.Message);
            //    Console.WriteLine(ex.InnerException.StackTrace);
            //}

            //try
            //{
            //    Metodo();
            //}
            //catch (DivideByZeroException)
            //{
            //    //Console.WriteLine(excecao.Message);
            //    //Console.WriteLine(excecao.StackTrace);
            //    Console.WriteLine("Ocorreu um erro! Não é possível dividir um número por 0");
            //}
            //catch (NullReferenceException)
            //{
            //    Console.WriteLine("Erro");
            //}
            //catch (Exception excecao)
            //{
            //    Console.WriteLine(excecao.Message);
            //    Console.WriteLine(excecao.StackTrace);
            //}

            Console.ReadLine();
        }

        private static void CarregarContas()
        {
            using(LeitorDeArquivo leitor = new LeitorDeArquivo("contas.txt"))
            {
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
                leitor.LerProximaLinha();
            }
            //catch (IOException e)
            //{  
            //    Console.WriteLine("Exceçao do tipo IOException capturada e tratada");
            //}
            //finally
            //{
            //    leitor.FecharArquivo();
            //}
        }

        private static void Metodo()
        {
            TestaDivisao(0);
        }

        private static void TestaDivisao(int divisor)
        {
            int resultado = Dividir(10, divisor);
            Console.WriteLine("Resultado da divisão de 10 por " + divisor + " é " + resultado);
        }

        private static int Dividir(int numero, int divisor)
        {
            //ContaCorrente conta = null;
            //Console.WriteLine(conta.NumeroAgencia);
            try
            {
                return numero / divisor;
            }
            catch
            {
                Console.WriteLine("Exceção com numero = " + numero + " e divisor = " + divisor);
                throw;
            }
        }
    }
}


//Console.WriteLine("Boas vindas ao seu banco, ByteBank");

//ContaCorrente contaDoLucas = new ContaCorrente();
//contaDoLucas.titular = "Lucas Cândido";
//contaDoLucas.numeroAgencia = 15;
//contaDoLucas.conta = "1010-X";
//contaDoLucas.saldo = 100;

//Console.WriteLine("Saldo Lucas: " + contaDoLucas.saldo);

//ContaCorrente contaDaJulia = new ContaCorrente();
//contaDaJulia.titular = "Júlia Vasconcelos";
//contaDaJulia.numeroAgencia = 17;
//contaDaJulia.conta = "1010-5";
//contaDaJulia.saldo = 350;

//Console.WriteLine("Saldo Júlia: " + contaDaJulia.saldo);

//Cliente cliente = new Cliente();
//cliente.nome = "Lucas Cândido";
//cliente.cpf = "123456789";
//cliente.profissao = "Analista";

//ContaCorrente conta = new ContaCorrente();
//conta.titular = cliente;
//conta.conta = "1010-X";
//conta.numeroAgencia = 15;
//conta.saldo = 100;

//Console.WriteLine("Titular = " + conta.titular.nome);
//Console.WriteLine("CPF = " + conta.titular.cpf);
//Console.WriteLine("Profissao = " + conta.titular.profissao);
//Console.WriteLine("N° Conta = " + conta.conta);
//Console.WriteLine("Saldo = " + conta.saldo);
//Console.WriteLine("N° Agencia = " + conta.numeroAgencia);

//ContaCorrente conta2 = new ContaCorrente();
//conta2.titular = new Cliente();
//conta2.titular.nome = "Júlia Vasconcelos";
//conta2.titular.profissao = "Tester";
//conta2.titular.cpf = "987654321";
//conta2.conta = "9999-X";
//conta2.numeroAgencia = 18;
//conta2.saldo = 500;

//Console.WriteLine(conta2.titular.nome);

//ContaCorrente conta3 = new ContaCorrente();
//conta3.NumeroAgencia = 18;
//conta3.Conta = "1011-H";
//conta3.SetSaldo(200);
//Console.WriteLine(conta3.GetSaldo());
//Console.WriteLine(conta3.NumeroAgencia);
//Console.WriteLine(conta3.Conta);

//ContaCorrente conta4 = new ContaCorrente(18, "1010-X");
//conta4.SetSaldo(500);
//conta4.Titular = new Cliente();
//Console.WriteLine(conta4.GetSaldo());
//Console.WriteLine(conta4.NumeroAgencia);

//ContaCorrente conta5 = new ContaCorrente(283, "1234-X");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
//ContaCorrente conta6 = new ContaCorrente(284, "9874-Z");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);
//ContaCorrente conta7 = new ContaCorrente(285, "1111-Z");
//Console.WriteLine(ContaCorrente.TotalDeContasCriadas);

//ContaCorrente conta8 = new ContaCorrente(286, "2222-X", 200, "Lucas", "12345", "Estagiario");
//Console.WriteLine(conta8.GetSaldo());
//Console.WriteLine(conta8.NumeroAgencia);
//Console.WriteLine(conta8.Conta);
//Console.WriteLine(conta8.Titular.Nome);
//Console.WriteLine(conta8.Titular.Cpf);
//Console.WriteLine(conta8.Titular.Profissao);

//ContaCorrente conta9 = new ContaCorrente(new Cliente("Lucas", "12345", "Estagiario"), "2222-X", 287, 300);
//Console.WriteLine(conta9.GetSaldo());
//Console.WriteLine(conta9.NumeroAgencia);
//Console.WriteLine(conta9.Conta);
//Console.WriteLine(conta9.Titular.Nome);
//Console.WriteLine(conta9.Titular.Cpf);
//Console.WriteLine(conta9.Titular.Profissao);

//Console.ReadKey();
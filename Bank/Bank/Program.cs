using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * Ela tem um @número com 10 dígitos que identifica exclusivamente a conta bancária.
 * Ela tem uma cadeia de caracteres que armazena o @nome ou os nomes dos proprietários.
 * O @saldo pode ser recuperado.
 * Ela aceita @depósitos.
 * Ele aceita @saques.
 * O saldo inicial deve ser positivo.
 * Os saques não podem resultar em um saldo negativo.
 */


namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();
            Conta d = new Conta("Afonso",1000);

            Console.WriteLine("Nome: "+ c);
            Console.WriteLine("Nome: " + d);
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Classe que representa a conta bancária
    /// </summary>
    public class Conta
    {
        public string Nome { get; set; }
        public int NumConta { get; }
        public decimal Saldo { get; }

        /// <summary>
        /// Construtor padrão para @nome = "Anônimo"
        /// </summary>
        public Conta()
        {
            Nome = "Anônimo";
        }

        /// <summary>
        /// Construtor para nome e saldo
        /// </summary>
        /// <param name="nome">Dono da conta</param>
        /// <param name="saldoInicial">Valor inicial</param>
        public Conta(string nome, decimal saldoInicial) {
            this.Nome = nome;
            this.Saldo = saldoInicial;
        }

        /// <summary>
        /// Método para sacar do saldo
        /// </summary>
        /// <param name="valor">Montante</param>
        /// <param name="data">Quando aconteceu</param>
        /// <param name="desc">Motivo</param>
        public void Sacar(decimal valor, DateTime data, string desc){}

        /// <summary>
        /// Método para depositar em saldo
        /// </summary>
        /// <param name="valor">Montante</param>
        /// <param name="data">Quando</param>
        /// <param name="desc">Motivo</param>
        public void Depositar(decimal valor, DateTime data, string desc) {}

        /// <summary>
        /// Retorna o nome do dono da conta
        /// </summary>
        /// <returns>Nome da conta</returns>
        public override string ToString()
        {
            //return base.ToString();
            return Nome;
        }
    }
}

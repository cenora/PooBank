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
            Console.WriteLine("Nome: "+ c);
            Console.ReadKey();
        }
    }

    /// <summary>
    /// Classe que representa a conta bancária
    /// </summary>
    public class Conta
    {
        string Nome { get; set; }
        int NumConta { get; }
        decimal Saldo { get; }

        /// <summary>
        /// Construtor padrão para @nome = "Anônimo"
        /// </summary>
        public Conta()
        {
            Nome = "Anônimo";
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
            return Nome;
        }
    }
}

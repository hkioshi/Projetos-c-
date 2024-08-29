using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Projetos
{
    internal class Conector
    {
        public const string servidor = "localhost";
        public string bancoDados;
        private const string usuario = "root";
        private const string senha = "@2Hkioshi";
        private string conexaoBanco;
        public MySqlConnection conexao;
        public Conector(string db)
        {
            try
            {
                bancoDados = db;
                conexaoBanco = $"server={servidor}; user id={usuario};database={bancoDados}; password={senha}";
                conexao = new MySqlConnection(conexaoBanco);
                Console.WriteLine("Conectado");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }

        }
    }
}

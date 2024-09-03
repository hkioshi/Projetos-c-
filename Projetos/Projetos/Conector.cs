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


        public void SQL_ALL(string tabela)
        {
            try
            {
                conexao.Open();

                string query = $"SELECT * FROM {tabela}";
                MySqlCommand cmd = new MySqlCommand(query, conexao);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string temp = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        temp += reader[i].ToString();
                        if (i < reader.FieldCount - 1)
                            temp += " | ";
                    }
                    Console.WriteLine(temp);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }


        }

        public void SQL_ALL(ListBox list, string tabela)
        {
            try
            {
                conexao.Open();

                string query = $"SELECT * FROM {tabela}";
                MySqlCommand cmd = new MySqlCommand(query, conexao);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string temp = "";
                    for (int i = 0; i < reader.FieldCount; i++)
                    {
                        temp += reader[i].ToString();
                        if (i < reader.FieldCount - 1)
                            temp += " | ";
                    }
                    list.Items.Add(temp);
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
            }
            finally
            {
                conexao.Close();
            }

            



        }
    }
}

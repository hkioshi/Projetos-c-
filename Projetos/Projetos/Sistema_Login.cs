using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Digests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Projetos
{
    internal static class Sistema_Login
    {
        public static bool Logar(out string nome, out string telefone, string email, string senha)
        {
            Conector conector = new Conector("sistema_login");
            bool retorno = false;
            string n = "", t = "";
            try
            {
                conector.conexao.Open();

                string query = $"SELECT nome,telefone FROM usuarios where email = '{email}'";
                MySqlCommand cmd = new MySqlCommand(query, conector.conexao);

                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    n = reader[0].ToString();
                    t = reader[1].ToString();
                    retorno = true;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro: " + ex.Message);
              
            }
            finally
            {
                conector.conexao.Close();
            }
            nome = n; telefone = t;
            return retorno;
        }

        public static bool Cadastrar(string email, string senha, string nome, string telefone)
        {
            
            Conector conector = new Conector("sistema_login");
            bool retorno = false;
            try
            {
                conector.conexao.Open();
                string query = $"SELECT * FROM usuarios WHERE email = {email}";
                MySqlCommand cmd = new MySqlCommand(query, conector.conexao);

                MySqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                    
                reader.Close();
            }
            catch
            {
               
                string query = $"INSERT INTO usuarios (nome, email, senha, telefone) VALUES ('{nome}', '{email}', '{senha}', '{telefone}');";
                MySqlCommand cmd = new MySqlCommand(query, conector.conexao);

                MySqlDataReader reader = cmd.ExecuteReader();
                retorno=true;
            }
            finally
            {
                conector.conexao.Close();
            }
            return retorno;


        }
    }
}

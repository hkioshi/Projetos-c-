using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Newtonsoft.Json;

namespace Projetos
{
    public class Sistema
    {
        public static bool TryParse<T1, T2>(T1 t1, out T2 t2)
        {

            try
            {
                t2 = (T2)Convert.ChangeType(t1, typeof(T2));
                return true;
            }
            catch (Exception ex)
            {
                t2 = default(T2);
                Console.WriteLine("o erro é: " + ex.Message.ToString());
                return false;
            }
        }

        public static string Embaralhar_String(string s)
        {
            Random rng = new Random();
            char[] array = s.ToCharArray();
            int n = array.Length;
            for (int i = n - 1; i > 0; i--)
            {
                int j = rng.Next(0, i + 1);
                // Troca os elementos array[i] e array[j]
                char temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
            return new string(array);


        }

        public static void SQL_ALL(ListBox list,MySqlConnection conexao, string tabela)
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

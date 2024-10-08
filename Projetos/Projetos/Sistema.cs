﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
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

        public static bool ValidarEmail(string email)
        {
            string padrao = @"\@[a-z]+\.[a-z]+(\.[a-z]+)?";
            return Regex.IsMatch(email, padrao)? true: false;
            
        }
        public static bool ValidarTelefone(string tel)
        {
            string padrao = @"\d{2}9\d{8}";
            return Regex.IsMatch(tel, padrao) ? true : false;

        }

    }
}

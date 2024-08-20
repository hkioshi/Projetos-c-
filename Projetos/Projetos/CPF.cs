using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projetos
{
    public class CPF
    {
        int[] cpf = new int[11];
        public string cpf_string;

        public CPF(string numero) 
        {
            try
            {
                for (int i = 0; i < 11; i++)
                {
                    this.cpf[i] = int.Parse(numero[i].ToString());
                }
            }
            catch 
            {
                MessageBox.Show("Nao é um cpf valido");
            }

            cpf_string = numero;

        }
        
        public bool Validar()
        {
            List<int> temp = new List<int>();

           
            for (int i = 0; i < 9; i++)
            {
                temp.Add(cpf[i] * (i + 1));
            }

            int total = temp.Sum() % 11 == 10 ? 0 : temp.Sum() % 11;
            if (total != cpf[9])
            {
                return false;
            }
  
            temp.Clear();

            for (int i = 0; i <= 9; i++)
            {
                temp.Add(cpf[i] * i);
            }

            total = temp.Sum() % 11 == 10 ? 0 : temp.Sum() % 11;

            if (total != cpf[10])
            {
                return false;
            }



            return true;
        }

        public static string GerarCPF()
        {
            CPF a;
            Random rnd = new Random();
            while (true)
            {
                string cpf = "";
                for (int i = 0; i < 11; i++)
                {
                    cpf += rnd.Next(0, 10);
                }

                a = new CPF(cpf);
                if (a.Validar())
                    return a.cpf_string;
            }

        }
    }
}

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
        

        public CPF(string cpf) 
        {
            try
            {
                for (int i = 0; i < 11; i++)
                {
                    this.cpf[i] = int.Parse(cpf[i].ToString());
                }
            }
            catch 
            {
                MessageBox.Show("Nao é um cpf valido");
            }
           
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

    }
}

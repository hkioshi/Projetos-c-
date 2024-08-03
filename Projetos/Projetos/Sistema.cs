using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            catch(Exception ex) 
            {
                t2 = default(T2);
                Console.WriteLine("o erro é: " + ex.Message.ToString());
                return false;
            }
        }
    }
}

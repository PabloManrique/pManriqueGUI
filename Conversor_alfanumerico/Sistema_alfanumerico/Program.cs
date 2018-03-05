using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_alfanumerico
{
    class Program
    {
        static void Main(string[] args)
        {
            string base36 = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            int num = int.Parse(args[0]);
            string alfa;
            string numero="";
            string numeroinvertido="";
            if (num< 0)
            {
                Console.WriteLine("El caracter introducido no es valido");
            }
            else
            {
                do
                {
                    int r = num % 36;
                    alfa = base36.Substring(r, 1);
                    numero += alfa;
                    num = num / 36;
                } while (num != 0);
                for (int x = numero.Length - 1; x >= 0; x--)
                {
                    numeroinvertido += numero[x];
                }
                Console.WriteLine("El numero en alfanumerico es : " + numeroinvertido);
                Console.ReadLine();
            }           
        }
    }
}

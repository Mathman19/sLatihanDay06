using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0605
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOMOR 4 SOAL KORBAN KUNGFU
            //MENCARI POLINDROM DARI INPUT
            Console.Write("Tulis kata/kalimat yang ingin dicek: ");
            string input = Console.ReadLine();
            char[] tmp = input.ToLower().ToCharArray();
            int range = tmp.Length;
            string back = input;
            
            if (range % 2 == 0)
            {
                if (back == genap(tmp, range))
                {
                    Console.WriteLine("'" + input + "'" + " termasuk polindrom");
                }
                else
                {
                    Console.WriteLine("'" + input + "'" + " bukan polindrom");
                }
            }
            if (range % 2 == 1)
            {
                if (back == ganjil(tmp, range))
                {
                    Console.WriteLine("'" + input + "'" + " termasuk polindrom");
                }
                else
                {
                    Console.WriteLine("'" + input + "'" + " bukan polindrom");
                }
            }
            Console.ReadKey();
        }
        static string genap(char[] kata, int l)
        {
            char tmpg;
            for (int i = 0; i < l / 2; i++)
            {
                for (int j = l - 1; j >= l / 2; j--)
                {
                    if (i + j == l - 1)
                    {
                        tmpg = kata[i];
                        kata[i] = kata[j];
                        kata[j] = tmpg;
                    }
                }
            }
            string baru = new string(kata);
            return baru;
        }
        static string ganjil(char[] kata, int l)
        {
            char tmpg;
            for (int i = 0; i < (l - 1) / 2; i++)
            {
                for (int j = l - 1; j > (l - 1) / 2; j--)
                {
                    if (i + j == l - 1)
                    {
                        tmpg = kata[i];
                        kata[i] = kata[j];
                        kata[j] = tmpg;
                    }
                }
            }
            string baru = new string(kata);
            return baru;
        }
    }
}

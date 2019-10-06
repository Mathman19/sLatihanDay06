using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0603
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOMOR 2 SOAL KORBAN KUNGFU
            //MENCARI ANAGRAM DARI DUA INPUT
            Console.Write("Masukan kata/kalimat pertama : ");
            string tmp1 = Console.ReadLine().Replace(" ","");
            Console.Write("Masukan kata/kalimat kedua : ");
            string tmp2 = Console.ReadLine().Replace(" ","");
            char[] tk1 = tmp1.ToLower().ToCharArray();
            char[] tk2 = tmp2.ToLower().ToCharArray();
            int range1 = tk1.Length;
            int range2 = tk2.Length;
            //char tmpg;
            
            if (urut(tk1, range1) == urut(tk2, range2))
            {
                Console.WriteLine("Ternyata ANAGRAM");
            }
            else
            {
                Console.WriteLine("Ternyata BUKAN anagram");
            }
            baca(tk1);
            baca(tk2);
            Console.ReadKey();
        }
        static string urut(char[] kata, int l)
        {
            char tmpg;
            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < l; j++)
                {
                    if (kata[i] < kata[j])
                    {
                        tmpg = kata[j];
                        kata[j] = kata[i];
                        kata[i] = tmpg;
                    }
                }
            }
            string newKata = new string(kata);
            return newKata;
        }
        static void baca(char[] kata)
        {
            foreach (char item in kata)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

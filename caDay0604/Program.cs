using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0604
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOMOR 3 SOAL KORBAN KUNGFU
            //MENCARI BANYAK VOKAL DAN KONSONAN DARI INPUT
            string input = Console.ReadLine();
            string tmp = input.Replace(" ", "");
            char[] pisah = tmp.ToLower().ToCharArray();
            char[] vokal = {'a','i','u','e','o'};
            int jumVok = 0;

            for (int i = 0; i<pisah.Length; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (pisah[i] == vokal[j])
                    {
                        jumVok = jumVok + 1;
                    }
                }
            }
            Console.WriteLine("jumlah konsonan " + (pisah.Length-jumVok));
            Console.Write("jumlah vokal " + jumVok);
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0602
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOMOR 1 SOAL KORBAN KUNGFU
            //MENCARI JUMLAHAN SETIAP ELEMEN DARI HIMPUNAN
            //DIMANA ANGKA YANG SAMA TIDAK BOLEH DIJUMLAHKAN LAGI
            string tampung = Console.ReadLine();
            char[] tkp = tampung.ToCharArray();
            int range = tkp.Length;
            int[] angka = new int[range];
            //Console.WriteLine(range);
            int sum = 0;
            for (int i = 0; i<range; i++)
            {
                angka[i] = (int)char.GetNumericValue(tkp[i]);
            }
            for (int i = 0; i<range; i++)
            {
                if (i < range - 1)
                {
                    for (int j = i+1; j<range; j++)
                    {
                        if (angka[i] == angka[j])
                        {
                            angka[j] = 0;
                        }
                    }

                }
                sum = sum + angka[i];
            }
            
            Console.Write(sum);
            Console.ReadKey();
        }
    }
}

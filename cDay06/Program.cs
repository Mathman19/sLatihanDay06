using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cDay06
{
    class Program
    {
        static void Main(string[] args)
        {
            //MENCARI ANGKA YANG JUMLAHAN ANGKA KIRI DAN KANANNYA SAMA
            string tampung = Console.ReadLine();
            char[] tkp = tampung.ToCharArray();
            int jangkauan = tkp.Length;
            int[] angka = new int[jangkauan];
            for (int i = 0; i<jangkauan; i++)
            {
                angka[i] = (int)char.GetNumericValue(tkp[i]);
            }
            
            for (int j = 0; j<jangkauan; j++)
            {
                Console.Write(angka[j]);
                int bilka = 0;
                if (j < jangkauan-1)
                {
                    for (int k = j+1; k<jangkauan; k++)
                    {
                        bilka = bilka + angka[k];
                    }
                }
                int tmp1 = bilka;
                int bilki = 0;
                if (j > 0)
                {
                    for (int l = 0; l<j; l++)
                    {
                        bilki = bilki + angka[l];
                    }
                }
                int tmp2 = bilki;
                
                if (tmp1 == tmp2)
                {
                    Console.WriteLine(" benar sama");
                }
                else
                {
                    Console.WriteLine(" tidak sama");
                }
            }
            Console.ReadKey();
        }
    }
}

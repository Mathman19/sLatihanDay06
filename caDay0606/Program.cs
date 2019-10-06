using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caDay0606
{
    class Program
    {
        static void Main(string[] args)
        {
            //NOMOR 5 SOAL KORBAN KUNGFU
            Console.Write("Pesan berapa makanan : ");
            int input1 = int.Parse(Console.ReadLine());
            Console.Write("Pesan berapa minuman : ");
            int input2 = int.Parse(Console.ReadLine());
            Console.Write("Pesan berapa ikan : ");
            int input3 = int.Parse(Console.ReadLine());
            int mkn = 0, mnm = 0, ikn = 0;

            int harga1 = 1000000 / (input1 + input2 + input3);
            if (input1>0)
            {
                mkn = mkn + harga1 / 4;
            }
            if (input2>0)
            {
                mnm = mnm + harga1 / 4;
            }
            if (input3>0)
            {
                ikn = ikn + harga1 / 3;
            }

            Console.WriteLine("Adi bayar " + (mkn + mnm + ikn));
            Console.WriteLine("Paimin bayar " + (mkn + mnm + ikn));
            Console.WriteLine("Paijo bayar " + (mkn + mnm + ikn));
            Console.WriteLine("Fulan bayar " + (mkn + mnm));

            Console.ReadKey();
        }
    }
}

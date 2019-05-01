using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSPEMROG
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan krywn = new Karyawan();

            krywn.nama = "SURIYADI";
            krywn.nik = "2317";
            krywn.gaji = 2000000;

            krywn.nama2 = "SARIMENT";
            krywn.nik2 = "2318";
            krywn.gaji2 = 3000000;

            krywn.infoGaji();
            Console.WriteLine();
            krywn.kenaikanGaji();
            Console.WriteLine();
            Console.ReadKey();

        }
    }
}
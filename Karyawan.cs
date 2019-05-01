using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTSPEMROG
{
    class Karyawan
        {
            public string nama { get; set; }
            public string nik { get; set; }
            public int gaji { get; set; }
            public string nama2 { get; set; }
            public string nik2 { get; set; }
            public int gaji2 { get; set; }
            public void infoGaji()
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("gaji anda bulan ini.");
                Console.WriteLine();
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("No    Nik  |    Nama         |    total gaji| ");
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("1    {0}  |    {1}     |     {2}  |", nik, nama, gaji);
                Console.WriteLine("2    {0}  |    {1}     |     {2}  |", nik2, nama2, gaji2);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine();
            }
            public void kenaikanGaji()
            {
                if (gaji < 0)
                {
                    gaji = 0;
                }
                else if (gaji2 < 0)
                {
                    gaji2 = 0;
                }
                Console.WriteLine("bonus yang anda dapatkan bulan ini:");
                Console.WriteLine();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("No    Nik   |   Nama         |  gaji + bonus | ");
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("1     {0}  |   {1}     |     {2}   | ", nik, nama, gaji + (gaji * 0.1));
                Console.WriteLine("2     {0}  |   {1}     |     {2}   | ", nik2, nama2, gaji2 + (gaji2 * 0.1));
                Console.WriteLine("----------------------------------------------");
            }
        }
    }

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Toko
{
    class Karyawan
    {
        public string nama { get; set; }
        public string nik { get; set; }
        public int gaji { get; set; }

        public void cetak()
        {
            Console.WriteLine("{0} {1}  {2}", nik, nama, gaji);
        }

        public Karyawan(string nik, string nama, int gaji)
        {
            this.nik = nik;
            this.nama = nama;
            this.gaji = gaji < 0 ? 0 : gaji;
        }

        public void naik()
        {
            int kenaikan;

            kenaikan = gaji * 110;
            gaji = kenaikan / 100;

            
        }

        static void Main(string[] args)
        {
            Karyawan a1 = new Karyawan("Paijo", "190302123", 4000000);
            Karyawan a2 = new Karyawan("Jono", "190302124", 2000000);

            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1."); a1.cetak();
            Console.WriteLine("2."); a2.cetak();

            a1.naik();
            a2.naik();

            Console.WriteLine("asik naik gaji!");

            Console.WriteLine("No Nik/Nama      Gaji Bulanan");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1."); a1.cetak();
            Console.WriteLine("2."); a2.cetak();

            Console.WriteLine("Klik untuk keluar");
            Console.ReadKey();
        }
    }
}





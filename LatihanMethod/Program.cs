using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarasi variabel
            int hasil;

            //membuat objek dari class calculator
            Calculator calculator = new Calculator();

            //panggil method penjumlah
            hasil = calculator.Penjumlah(10, 2);
            CetakHasil("Hasil Penjumlah : " + hasil);

            //panggil method penjumlah dg 3 parameter (overload method)
            hasil = calculator.Penjumlah(10, 2, 3);
            CetakHasil("Hasil Penjumlah Overload : " + hasil);

            //panggil method Pengurangan
            hasil = calculator.Pengurangan(7, 2);
            CetakHasil("Hasil Pengurangan : " + hasil);

            //panggil static method, langsung dari nama classnya
            hasil = Calculator.Perkalian(5, 2);
            CetakHasil("Hasil Perkalian : " + hasil);

            Console.ReadKey();
        }

        static void CetakHasil (string hasil)
        {
            Console.WriteLine(hasil);
        }
    }
}

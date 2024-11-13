using System;
using System.ComponentModel.DataAnnotations;
class Program
{
    static void Main()
    {
        jajargenjang();
        // // Minta pengguna memasukkan nilai alas
        // Console.Write("Masukkan nilai alas segitiga: ");
        // double alas = Convert.ToDouble(Console.ReadLine());

        // // Minta pengguna memasukan nilai tinggi
        // Console.Write("Masukkan nilai tinggi segitiga: ");
        // double tinggi = Convert.ToDouble(Console.ReadLine());

        // // Hitung luas segitiga 
        // double luas = 0.5 * alas * tinggi;
        // // Tampilkan hasil luas segitiga
        // Console.WriteLine("Luas segitiga adalah: " + luas.ToString());
    }

    static void jajargenjang()
    {
        // MInta pengguna memasukan nilai alas
        Console.Write("Masukkan nilai alas jajargenjang: ");
        double alas = Convert.ToDouble(Console.ReadLine());

        // Minta pengguna memamsukan nilai tinggi
        Console.Write("Masukan nilai tinggi jajargenjang: ");
        double tinggi = Convert.ToDouble (Console.ReadLine());

        // Hitung luas jajargenjang
        double luas = alas * tinggi;

        // Tampilkan hasil luas jajargenjang
        Console.WriteLine("luas jajargenjang adalah: " + luas.ToString());
    }

    
}

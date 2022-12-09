using System;

namespace BasicProgramming
{
    class Program
    {
        // Method void Main merupakan method utama untuk menjalaknkan program
        static void Main(String[] args)
        {
            DaftarMenu(); // Memanggil method nama_toko untuk ditampilkan
            Pilihan();  // Memanggil method pilihan untuk memilih menu
        }
        static void Pilihan()
        {
            int input;
            Console.Write("\nMasukkan Pilihan : ");
            input = InputanPilihan();
            do
            {
                switch (input)
                {
                    case 1:
                        Item();
                        break;
                    case 2:
                        Item();
                        break;
                    case 3:
                        Item();
                        break;
                    case 4:
                        Item();
                        break;
                    case 5:
                        Item();
                        break;
                    case 6:
                        Console.WriteLine("Terima Kasih");
                        break;
                    default:
                        Console.WriteLine("Salah ");
                        break;
                }
            } while (input != 6);// Kondisi While jika nilai inputan bernilai 5 maka akan keluar perulangan
        }
        static int InputanPilihan()
        {
            int a = Convert.ToInt32(Console.ReadLine());
            return a;
        }
        static void Item()
        {
            string[] makanan = new string[4] { "Rendang", "Ayam Bakar", "Sate", "Bakso" };
            Console.Write("Jumlah item : ");
            int input1 = InputanPilihan();
            if (input1 == 1)
            {
                Console.WriteLine("Total bayar " + makanan[0] + " Rp. " + JumlahBarang(20000));
            }
            else if (input1 == 2)
            {
                Console.WriteLine("Total bayar " + makanan[1] + " Rp. " + JumlahBarang(15000));
            }
            else if (input1 == 3)
            {
                Console.WriteLine("Total bayar " + makanan[2] + " Rp. " + JumlahBarang(18000));
            }
            else if (input1 == 4)
            {
                Console.WriteLine("Total bayar " + makanan[3] + " Rp. " + JumlahBarang(13000));
            }
        }
        // Method integer jumlah_barang untuk menghitung jumlah harga barang
        static int JumlahBarang(int harga) // Menggunakan 1 parameter integer
        {
            int jumlah = Convert.ToInt32(Console.ReadLine());
            return jumlah * harga; // Mengembalikan nilai dari jumlah*harga
        }

        // Method void nama_toko untuk menampilkan daftar menu
        static void DaftarMenu()
        {
            Console.WriteLine("====================================");
            Console.WriteLine("|| Selamat Datang di Warung Gelap ||");
            Console.WriteLine("|| 1. Rendang       Rp.20000      ||");
            Console.WriteLine("|| 2. Ayam Bakar    Rp.15000      ||");
            Console.WriteLine("|| 3. Sate          Rp.18000      ||");
            Console.WriteLine("|| 4. Bakso         Rp.13000      ||");
            Console.WriteLine("|| 5. Selesai                     ||");
            Console.WriteLine("====================================");
        }
    }
}

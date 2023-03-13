using System;
using System.IO;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading;
using System.Globalization;

namespace AppKasir
{
    /// <summary>
    /// Menggunakan namespace dengan nama AppKasir. namespace berguna untuk mengumpulkan semua class
    /// </summary>
    //membuat public class
    public class Kasir
    {
        public void KasirOrdinary()
        {
            {
                ///<summary>
                ///Tampilan selamat datang
                /// </summary>
                /// <code>
                /// 
                /// </code>
                Console.WriteLine("===============================================");
                Console.Write("\n");
                Console.WriteLine("         Selamat Datang di Cafe Ordinary          ");
                Console.Write("\n");
                Console.WriteLine("===============================================");
                Console.Write("\n");
                Console.WriteLine("Memilih item dari menu");
                Console.Write("\n");
                ///<summary>
                ///Tampilan memilih menu Makanan beserta list harga
                /// </summary>
                Console.WriteLine("=================== Makanan ===================");
                Console.WriteLine("1. Nachos                        :  Rp 30000");
                Console.WriteLine("2. Chicken Fingers               :  Rp 20000");
                Console.WriteLine("3. Sphageti Bolognese            :  Rp 50000");
                Console.WriteLine("4. Sandwich                      :  Rp 40000");
                Console.WriteLine("5. French Fries                  :  Rp 20000");
                Console.Write("\n");
                ///<summary>
                ///Tampilan memlih menu Minuman beserta list harga
                /// </summary>
                Console.WriteLine("=================== Minuman ===================");
                Console.WriteLine("1. Milshake Vanilla              :  Rp 20000");
                Console.WriteLine("2. Cocktail                      :  Rp 30000");
                Console.WriteLine("3. Vanilla Latte                 :  Rp 25000");
                Console.WriteLine("4. Americano                     :  Rp 20000");
                Console.WriteLine("5. Mango      Juice              :  Rp 22000");
                int jumlah;
                //looping dengan memasukkan jumlah barang menggunakan kondisi do while
                do
                {
                    Console.Write("\nMasukkan jumlah pesanan        :  ");
                    jumlah = int.Parse(Console.ReadLine());
                } while (jumlah <= 0 || jumlah > 100);
                //mendeklarasikan atau mendefinisikan variabel data
                string[] nama = new string[jumlah];
                int[] harga = new int[jumlah];
                int total = 0;
                int bayar, kembalian;
                //menampilkan 'Nama Pelanggan'
                Console.WriteLine("===============================================");
                Console.Write("Nama Pelanggan : ");
                //deklarasi variabel data string
                string namap1 = Console.ReadLine();
                ///<summary>
                ///Menghitung perulangan dengan kombinasi array
                /// </summary>
                /// <param name="nama">Parameter ini untuk memasukkan data nama dalam bentuk string</param>
                /// <param name="jumlah">Parameter ini untuk memasukkan jumlah harga dalam bentuk integer</param>
                /// <param name="namp1"></param>
                /// <code>
                ///  for (int i = 0; i < jumlah; i++)
                /// </code>
                for (int i = 0; i < jumlah; i++)
                {
                    do
                    {
                        //menampilkan input nama barang
                        Console.WriteLine("===============================================");
                        Console.Write("\n");
                        Console.Write("Masukkan nama barang ke-" + (i + 1) + ": ");
                        nama[i] = Console.ReadLine();
                    } //user harus menginput nama barang di atas 0 karakter sampai dengan 20 karakter
                    while (nama[i].Length <= 0 || nama[i].Length >= 20);

                    do
                    {
                        Console.Write("Masukkan harga barang ke-" + (i + 1) + ": ");

                        harga[i] = int.Parse(Console.ReadLine());
                        //user harus menginput harga barang minimal 4000 sampai 1000000
                    }
                    while (harga[i] <= 4000 || harga[i] >= 1000000);
                }
                //menampilkan barang dan harga yang sudah dipilih
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("===============================================");
                Console.WriteLine("           Daftar Menu yang Dipilih            ");
                Console.WriteLine("===============================================");
                for (int i = 0; i < jumlah; i++)
                {
                    //Menampilkan nama barang dan harga barang
                    Console.WriteLine((i + 1) + ". " + nama[i] + "  " + harga[i]);
                }
                foreach (int i in harga)
                {
                    total += i;
                }
                //menampilkan total harga
                Console.WriteLine("===============================================");
                Console.WriteLine("Total harga                     :  Rp" + total);
                do
                {
                    Console.Write("Masukkan uang bayar             :  Rp");
                    bayar = int.Parse(Console.ReadLine());
                    //menampilkan kembalian uang dari uang yang dibayarkan dikurangi uang total
                    kembalian = bayar - total;
                    //kondisi jika input uang yang dibayarkan kurang
                    if (bayar < total)
                    {
                        Console.WriteLine("Uang anda tidak cukup!");
                    }
                    //kondisi dimana input uang yang dibayarkan lebih
                    else //menampilkan uang kembalian
                    {
                        Console.WriteLine("Jumlah uang kembali             :  Rp" + kembalian);
                    }
                } while (bayar < total);
                Console.Write("\n");
                Console.Write("Nama Pelanggan       : {0}", namap1.ToString());
                Console.Write("\n");
                //menampilkan tanggal dan waktu transaksi
                Console.WriteLine("Tanggal transaksi    : " + DateTime.Today.ToString("yyyy-MM-dd"));
                Console.WriteLine("Jam transaksi        : " + DateTime.Now.ToString("HH:mm:ss"));
                Console.WriteLine("===============================================");
                Console.WriteLine("Nama kasir           : Dirgantara");
                Console.WriteLine("================ Terima kasih =================");
                //mencetak nota menggunakan streamwriter
                using (StreamWriter sw = new StreamWriter("D:/" + "File Nota" + ".txt"))
                {
                    sw.WriteLine("===============================================");
                    sw.WriteLine("=============== Nota Pembayaran ===============");
                    sw.WriteLine("===============================================");
                    sw.WriteLine("             Nama Menu yang Dibeli             ");
                    for (int i = 0; i < jumlah; i++)
                    {
                        sw.WriteLine((i + 1) + ". " + nama[i] + "  " + harga[i]);
                    }
                    sw.WriteLine("===============================================");
                    sw.WriteLine("Total harga                     :  Rp" + total);
                    sw.WriteLine("Uang bayar                      :  Rp" + bayar);
                    sw.WriteLine("Uang kembali                    :  Rp" + kembalian);
                    sw.WriteLine("\n");
                    //menampilkan nama pelanggan
                    sw.WriteLine("Nama pelanggan    : {0}", namap1.ToString());
                    //menampilkan tanggal dan waktu transaksi
                    sw.WriteLine("Tanggal transaksi    : " + DateTime.Today.ToString("yyyy-MM-dd"));
                    sw.WriteLine("Jam transaksi        : " + DateTime.Now.ToString("HH:mm:ss"));
                    sw.WriteLine("===============================================");
                    sw.WriteLine("Nama kasir           : Dirgantara");
                    sw.WriteLine("================ Terima kasih =================");
                    Console.Write("\n");
                    Console.WriteLine("Nota berhasil dicetak");
                }
                Console.WriteLine();
                Console.Write("Tekan ENTER/return untuk keluar");
                Console.ReadLine();
            }
        }
        static void Main(string[] args)
        {
            ///<summary>
            ///Memanggil kelas Ordinary
            /// </summary>
            Kasir KasirO = new Kasir();
            KasirO.KasirOrdinary();
        }
    }
}
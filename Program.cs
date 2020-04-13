using System;

namespace ResponsiPemrograman2659
{
    class Program
    {
        static void Main(string[] args)
        {



            Karyawan karyawan = new Karyawan(19192000, "kurniawan", 2000000);
            Karyawan karyawan2 = new Karyawan(19192001, "yosintha", 5000000);


            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n Alhamdulillah naik gaji");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }
}
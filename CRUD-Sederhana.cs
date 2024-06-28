using System;
using System.Collections.Generic;
using System.Data;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

{
    class Program
    {
        static List<dynamic> data = new List<dynamic>();
        static void Main(string[] args)
        {
            bool keluar = false;
            while (!keluar)
            {
                Console.WriteLine("Pilih Operasi:");
                Console.WriteLine("1. Create");
                Console.WriteLine("2. Read");
                Console.WriteLine("3. Update");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Keluar");
                int Pilihan = int.Parse(Console.ReadLine());
                switch (Pilihan)
                {
                    case 1:
                        Create();
                        break;
                    case 2:
                        Read();
                        break;
                    case 3:
                        Update();
                        break;
                    case 4:
                        Delete();
                        break;
                    case 5:
                        keluar = true;
                        break;
                    default:
                        Console.WriteLine("Pilihan Anda Tidak Valid!");
                        break;
                }
            }
        }
        static void Create()
        {
            Console.WriteLine("Masukkan Data Baru (angka atau teks):");
            string input = Console.ReadLine();

            if (int.TryParse(input, out int intData))
            {
                data.Add(intData);
            }
            else
            {
                data.Add(input);
            }
            Console.WriteLine("Data Berhasil Ditambahkan!");
        }
        static void Read()
        {
            Console.WriteLine("Data Saat Ini: ");
            foreach (var item in data)
            {
                Console.WriteLine(item);
            }
        }
        static void Update()
        {
            Console.WriteLine("Masukkan Indeks Data yang ingin diupdate:");
            int IndexFashich = int.Parse(Console.ReadLine());
            if (IndexFashich >= 0 && IndexFashich < data.Count)
            {
                Console.WriteLine("Masukkan Data Baru (angka atau teks):");
                string input = Console.ReadLine();

                if (int.TryParse(input, out int intData))
                {
                    data[IndexFashich] = intData;
                }
                else
                {
                    data[IndexFashich] = input;
                }
                Console.WriteLine("Data Berhasil Di Update!");
            }
            else
            {
                Console.WriteLine("Indeks Tidak Valid!");
            }
        }
        static void Delete()
        {
            Console.WriteLine("Masukkan Indeks Data Yang Ingin Dihapus:");
            int IndexFashich = int.Parse(Console.ReadLine());
            if (IndexFashich >= 0 && IndexFashich < data.Count)
            {
                data.RemoveAt(IndexFashich);
                Console.WriteLine("Data Berhasil Dihapus!");
            }
            else
            {
                Console.WriteLine("Indeks Tidak Valid!");
            }
        }
    }
}

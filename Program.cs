using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa();
            mhs.Nim = "2810";
            mhs.Nama = "Apryan Rizky Saputra";
            mhs.Registrasi();

            Console.ReadKey();
        }
    }
}

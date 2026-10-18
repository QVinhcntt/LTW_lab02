using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 0;
        nhap_n:
            Console.Write("Nhap so luong phan tu: ");
            if (!int.TryParse(Console.ReadLine(), out n) || n < 0)
            {
                Console.WriteLine("Gia tri khong hop le. Hay nhap lai.");
                goto nhap_n;
            }

            Random rd = new Random();

            List<int> mang = new List<int>();
            for (int i = 0; i < n; i++)
            {
                mang.Add(rd.Next(1, 101));
                Console.Write(mang[i] + " ");
            }

            Console.WriteLine("\nMang da sap xep theo thu tu tang dan:");
            mang.Sort();
            for (int i = 0; i < n; i++)
            {
                Console.Write(mang[i] + " ");
            }
        }
    }
}

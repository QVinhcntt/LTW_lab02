using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Baitap1
{
    class NotNegativeException : Exception
    {
        public NotNegativeException() : base("Bieu thuc trong dau can khong duoc < 0") { }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int x = 0, y = 0;
            try
            {
                Console.Write("Nhap so nguyen x: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("Nhap so nguyen y: ");
                y = int.Parse(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.WriteLine("Gia tri nhap vao khong hop le.");
            }
            
            int tuBT = 3 * x + 2 * y;
            int mauBT = 2 * x - y;
            double h;
            bool bieuThuc = false;

            try
            {
                if (mauBT < 0)
                {
                    throw new NotNegativeException();
                }
                h = Math.Sqrt(tuBT / mauBT);
                bieuThuc = true;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Loi chia cho 0. Hay nhap lai x va y.");
            }
            catch (NotNegativeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            if (bieuThuc)
            {
                h = Math.Sqrt(tuBT / mauBT);
                Console.WriteLine("Gia tri cua bieu thuc H = " + h.ToString());
            }
        }
    }
}

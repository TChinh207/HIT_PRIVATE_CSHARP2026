using System;
using System.Collections.Specialized;
namespace Baitapodaudo
{
    class Program
    {
        static void Main(string[] args)
        {
            string hoten = Console.ReadLine();
            int namsinh = int.Parse(Console.ReadLine());
            int diemlt, diemth;
            do
            {
                Console.WriteLine("Nhap diem ly thuyet: ");
                diemlt = int.Parse(Console.ReadLine());
                Console.WriteLine("Nhap diem thuc hanh ");
                diemth = int.Parse(Console.ReadLine());
            } while (diemlt < 0 || diemlt > 10 || diemth < 0 || diemth > 10);
            Console.WriteLine(hoten);
            Console.WriteLine(namsinh);
            Console.WriteLine(diemlt);
            Console.WriteLine(diemth);
        }
    }
}
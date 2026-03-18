using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_collection
{
    class Bai02
    {
        public static void Run()
        {
            Console.WriteLine("=== BÀI 2: TÍNH TỔNG CÁC PHẦN TỬ ===");
            Console.WriteLine("Họ tên: Nguyễn Đình Văn");
            Console.WriteLine("MSSV: 23115053122248 | Lớp: 225LTC01");
            Console.WriteLine("======================================");

            List<int> danhSach = new List<int>();

            Console.Write("\nNhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử [{i}]: ");
                int x = int.Parse(Console.ReadLine());
                danhSach.Add(x);
            }

            int tong = 0;
            foreach (int item in danhSach)
            {
                tong += item;
            }

            Console.WriteLine("\nDanh sách đã nhập:");
            foreach (int item in danhSach)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine($"\nTổng các phần tử: {tong}");
            Console.ReadLine();
        }
    }
}

// Họ tên: Nguyễn Đình Văn
// MSSV: 23115053122248
// Lớp: 225LTC01

using System;
using System.Collections.Generic;

namespace Generic_collection
{
    class Bai03
    {
        public static void Run()
        {
            Console.WriteLine("=== BÀI 3: TÌM SỐ LỚN NHẤT ===");
            Console.WriteLine("Họ tên: Nguyễn Đình Văn");
            Console.WriteLine("MSSV: 23115053122248 | Lớp: 225LTC01");
            Console.WriteLine("================================");

            List<int> danhSach = new List<int>();

            Console.Write("\nNhập số lượng phần tử: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử [{i}]: ");
                int x = int.Parse(Console.ReadLine());
                danhSach.Add(x);
            }

            int max = danhSach[0];
            foreach (int item in danhSach)
            {
                if (item > max)
                    max = item;
            }

            Console.WriteLine("\nDanh sách đã nhập:");
            foreach (int item in danhSach)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine($"\nSố lớn nhất trong danh sách: {max}");
            Console.ReadLine();
        }
    }
}
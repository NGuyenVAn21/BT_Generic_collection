using System;
using System.Collections.Generic;
using System.Text;

namespace Generic_collection
{
    class Bai01
    {
        public static void Run()
        {
            Console.WriteLine("=== BÀI 1: TẠO DANH SÁCH SỐ NGUYÊN ===");
            Console.WriteLine("Họ tên: Nguyễn Đình Văn");
            Console.WriteLine("MSSV: 23115053122248 | Lớp: 225LTC01");
            Console.WriteLine("========================================");

            List<int> danhSach = new List<int>();

            danhSach.Add(10);
            danhSach.Add(25);
            danhSach.Add(7);
            danhSach.Add(42);
            danhSach.Add(13);

            Console.WriteLine("\nCác phần tử trong danh sách:");
            for (int i = 0; i < danhSach.Count; i++)
            {
                Console.WriteLine($"  [{i}] = {danhSach[i]}");
            }

            Console.WriteLine($"\nTổng số phần tử: {danhSach.Count}");
            Console.ReadLine();
        }
    }
}

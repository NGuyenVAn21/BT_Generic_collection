using Generic_collection;
using System;
using System.Text;

Console.OutputEncoding = Encoding.UTF8;
Console.InputEncoding = Encoding.UTF8;

while (true)
{
    Console.WriteLine("\n===== MENU CHÍNH =====");
    Console.WriteLine("Họ tên: Nguyễn Đình Văn");
    Console.WriteLine("MSSV: 23115053122248 | Lớp: 225LTC01");
    Console.WriteLine("======================");
    Console.WriteLine("1. Bài 1 - Tạo danh sách số nguyên");
    Console.WriteLine("2. Bài 2 - Tính tổng các phần tử");
    Console.WriteLine("3. Bài 3 - Tìm số lớn nhất");
    Console.WriteLine("0. Thoát");
    Console.Write("Chọn bài: ");

    string luaChon = Console.ReadLine();

    switch (luaChon)
    {
        case "1": Bai01.Run(); break;
        case "2": Bai02.Run(); break;
        case "3": Bai03.Run(); break;
        case "0": return;
        default: Console.WriteLine("Lựa chọn không hợp lệ!"); break;
    }
}
using System;
using System.Text;

namespace NumberToVietnameseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            // Danh sách test đại diện cho đầy đủ các quy tắc đọc số
            decimal[] testCases = new decimal[]
            {
                0m,                    // Số 0
                5m, 10m, 15m, 21m, 24m,// Số nhỏ & các quy tắc lăm, mười, mốt, tư
                105m, 1005m,           // Quy tắc đọc "lẻ"
                123456789m,            // Số tiền thực tế phổ biến
                9876543210123m,        // Số lớn (hàng nghìn tỷ)
                1000000000000000000m,  // Số cực lớn (hàng tỷ tỷ)
                -5m, -105m,            // Số âm nhỏ
                -9876543210123m        // Số âm lớn
            };

            Console.WriteLine("=== KẾT QUẢ KIỂM THỬ ĐỌC SỐ TIẾNG VIỆT ===");
            foreach (decimal num in testCases)
            {
                Console.WriteLine($"{num,26:N0} -> {num.NumberToVietnameseWords()}");
            }

            Console.ReadLine();
        }
    }
}
using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_18_ChangeValueToReference
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== PATTERN 18: CHANGE VALUE TO REFERENCE ===");

            // 1. BEFORE (Tạo 2 đối tượng Customer riêng biệt trong bộ nhớ dù cùng tên)
            Before order1Before = new Before("Nguyen Kim Ngan");
            Before order2Before = new Before("Nguyen Kim Ngan");
            Console.WriteLine($"[BEFORE] Hai đơn hàng dùng chung cùng một tham chiếu khách hàng? {ReferenceEquals(order1Before.Customer, order2Before.Customer)}");

            // 2. AFTER (Sử dụng Repository để dùng chung 1 tham chiếu duy nhất)
            After order1After = new After("Nguyen Kim Ngan");
            After order2After = new After("Nguyen Kim Ngan");
            Console.WriteLine($"[AFTER] Hai đơn hàng dùng chung cùng một tham chiếu khách hàng? {ReferenceEquals(order1After.Customer, order2After.Customer)}");

            // 3. REAL (Sử dụng ConcurrentDictionary Thread-safe & Registry Pattern)
            Real order1Real = new Real("ORD01", "CUST01", "Nguyen Kim Ngan");
            Real order2Real = new Real("ORD02", "CUST01", "Nguyen Kim Ngan");
            Console.WriteLine($"[REAL] Đơn hàng '{order1Real.OrderId}' và '{order2Real.OrderId}' chung Khách hàng ID ({order1Real.Customer.Id})? {ReferenceEquals(order1Real.Customer, order2Real.Customer)}");

            Console.ReadLine();
        }
    }
}
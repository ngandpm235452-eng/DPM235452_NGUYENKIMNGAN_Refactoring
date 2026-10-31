using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_31_DecomposeConditional
{
    // Đối tượng thông tin đơn đặt vé thực tế trong hệ thống
    public class TicketOrder
    {
        public string CustomerName { get; set; }
        public DateTime BookingDate { get; set; }
        public int Quantity { get; set; }

        public TicketOrder(string customerName, DateTime bookingDate, int quantity)
        {
            CustomerName = customerName;
            BookingDate = bookingDate;
            Quantity = quantity;
        }
    }

    // Lớp Real đóng vai trò xử lý nghiệp vụ ứng dụng thực tế
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Khởi tạo dịch vụ tính giá vé đã tái cấu trúc (After)
            StadiumTicketAfter ticketService = new StadiumTicketAfter();

            // Danh sách các đơn đặt vé thực tế từ khách hàng
            List<TicketOrder> orders = new List<TicketOrder>
            {
                new TicketOrder("Nguyễn Văn A", new DateTime(2026, 7, 15), 4),  // Đặt vé mùa hè
                new TicketOrder("Trần Thị B", new DateTime(2026, 12, 20), 2), // Đặt vé mùa đông
                new TicketOrder("Lê Văn C", new DateTime(2026, 6, 10), 5)    // Đặt vé mùa hè
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("   HỆ THỐNG QUẢN LÝ VÀ TÍNH GIÁ VÉ SÂN VẬN ĐỘNG   ");
            Console.WriteLine("==================================================\n");

            double grandTotal = 0;

            foreach (var order in orders)
            {
                // Gọi phương thức đã được phân rã điều kiện để tính tiền
                double totalPrice = ticketService.CalculateTicketPrice(order.BookingDate, order.Quantity);
                grandTotal += totalPrice;

                Console.WriteLine($"Khách hàng: {order.CustomerName}");
                Console.WriteLine($"  - Ngày xem   : {order.BookingDate:dd/MM/yyyy}");
                Console.WriteLine($"  - Số lượng   : {order.Quantity} vé");
                Console.WriteLine($"  - Thành tiền : ${totalPrice:N2}\n");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine($"TỔNG DOANH THU ĐỢT BÁN VÉ: ${grandTotal:N2}");
            Console.WriteLine("==================================================");

            Console.ReadLine();
        }
    }
}
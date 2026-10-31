using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_40_AddParameter
{
    public class CustomerInvoice
    {
        public string InvoiceId { get; set; }
        public string Region { get; set; }
        public double Subtotal { get; set; }
        public double TaxRate { get; set; }

        public CustomerInvoice(string id, string region, double subtotal, double taxRate)
        {
            InvoiceId = id;
            Region = region;
            Subtotal = subtotal;
            TaxRate = taxRate;
        }
    }

    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<CustomerInvoice> invoices = new List<CustomerInvoice>
            {
                new CustomerInvoice("HD001", "Khu vực Nội thành (Thuế 10%)", 1000.0, 0.10),
                new CustomerInvoice("HD002", "Khu vực Chế xuất (Thuế 8%)", 2500.0, 0.08),
                new CustomerInvoice("HD003", "Khu vực Đặc quyền (Miễn thuế 0%)", 1500.0, 0.00)
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG TÍNH GIÁ TRỊ HÓA ĐƠN THEO KHU VỰC    ");
            Console.WriteLine("==================================================\n");

            foreach (var inv in invoices)
            {
                InvoiceAfter invoiceService = new InvoiceAfter(inv.Subtotal);

                // Truyền tham số taxRate mới thêm vào phương thức CalculateTotal
                double total = invoiceService.CalculateTotal(inv.TaxRate);

                Console.WriteLine($"Mã hóa đơn: {inv.InvoiceId}");
                Console.WriteLine($"  - Địa bàn áp dụng     : {inv.Region}");
                Console.WriteLine($"  - Tiền hàng chưa thuế : ${inv.Subtotal:N2}");
                Console.WriteLine($"  - Thuế suất áp dụng   : {inv.TaxRate * 100}%");
                Console.WriteLine($"  -> Tổng tiền hóa đơn  : ${total:N2}\n");
            }

            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}
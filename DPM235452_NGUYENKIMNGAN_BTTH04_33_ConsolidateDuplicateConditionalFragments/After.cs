using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_33_ConsolidateDuplicateConditionalFragments
{
    public class OrderProcessorAfter
    {
        public double ProcessOrder(double price, bool isSpecialDeal)
        {
            double total;

            if (isSpecialDeal)
            {
                total = price * 0.85; // Giảm giá 15%
            }
            else
            {
                total = price * 0.95; // Giảm giá 5%
            }

            // Hợp nhất: Đưa lời gọi hàm dùng chung ra ngoài khối điều kiện
            SendEmailNotification(total);

            return total;
        }

        private void SendEmailNotification(double total)
        {
            Console.WriteLine($"[Gửi Email]: Hóa đơn thanh toán đã tạo với số tiền: ${total:N2}");
        }
    }
}
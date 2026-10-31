using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_33_ConsolidateDuplicateConditionalFragments
{
    public class OrderProcessorBefore
    {
        public double ProcessOrder(double price, bool isSpecialDeal)
        {
            double total;

            if (isSpecialDeal)
            {
                total = price * 0.85; // Giảm giá 15%
                SendEmailNotification(total); // Đoạn mã bị lặp
            }
            else
            {
                total = price * 0.95; // Giảm giá 5%
                SendEmailNotification(total); // Đoạn mã bị lặp
            }

            return total;
        }

        private void SendEmailNotification(double total)
        {
            Console.WriteLine($"[Gửi Email]: Hóa đơn thanh toán đã tạo với số tiền: ${total:N2}");
        }
    }
}
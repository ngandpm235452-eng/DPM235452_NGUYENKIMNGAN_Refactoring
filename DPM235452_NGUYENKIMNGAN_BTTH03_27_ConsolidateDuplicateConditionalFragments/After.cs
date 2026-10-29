using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_27_ConsolidateDuplicateConditionalFragments
{
    public class After
    {
        public double CalculateTotal(bool isSpecialDeal, double price)
        {
            double total;
            if (isSpecialDeal)
            {
                total = price * 0.90;
            }
            else
            {
                total = price * 0.95;
            }

            // Tái cấu trúc: Trích xuất đoạn mã trùng lặp ra ngoài khối điều kiện if-else
            SendInvoice(total);
            return total;
        }

        private void SendInvoice(double total)
        {
            Console.WriteLine($"[AFTER] Hóa đơn đã được gửi với tổng tiền: {total:N0} VNĐ");
        }
    }
}
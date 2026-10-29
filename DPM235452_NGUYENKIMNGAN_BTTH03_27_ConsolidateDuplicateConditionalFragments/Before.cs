using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_27_ConsolidateDuplicateConditionalFragments
{
    public class Before
    {
        public double CalculateTotal(bool isSpecialDeal, double price)
        {
            double total;
            // Code Smell: Duplicate Conditional Fragments - Đoạn mã SendInvoice(total) xuất hiện giống hệt nhau ở cả 2 nhánh if và else
            if (isSpecialDeal)
            {
                total = price * 0.90;
                SendInvoice(total);
            }
            else
            {
                total = price * 0.95;
                SendInvoice(total);
            }
            return total;
        }

        private void SendInvoice(double total)
        {
            Console.WriteLine($"[BEFORE] Hóa đơn đã được gửi với tổng tiền: {total:N0} VNĐ");
        }
    }
}
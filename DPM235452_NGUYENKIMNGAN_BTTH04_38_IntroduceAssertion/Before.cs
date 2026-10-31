using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_38_IntroduceAssertion
{
    public class ExpenseProjectBefore
    {
        private const double NULL_EXPENSE = -1.0;
        private double expenseLimit = NULL_EXPENSE;

        public void SetExpenseLimit(double limit)
        {
            expenseLimit = limit;
        }

        public double GetExpenseLimit()
        {
            // Giả định ngầm định: expenseLimit đã được khởi tạo và khác NULL_EXPENSE
            // Nếu chưa khởi tạo, chương trình vẫn trả về -1 mà không đưa ra cảnh báo lúc Debug
            return expenseLimit;
        }
    }
}
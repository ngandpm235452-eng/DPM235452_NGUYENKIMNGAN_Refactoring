using System;
using System.Diagnostics;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_38_IntroduceAssertion
{
    public class ExpenseProjectAfter
    {
        private const double NULL_EXPENSE = -1.0;
        private double expenseLimit = NULL_EXPENSE;

        public void SetExpenseLimit(double limit)
        {
            // Thêm Assertion: Đảm bảo hạn mức chi tiêu không được âm
            Debug.Assert(limit >= 0, "Hạn mức chi tiêu không được là số âm!");
            expenseLimit = limit;
        }

        public double GetExpenseLimit()
        {
            // Thêm Assertion: Khẳng định dữ liệu đã được khởi tạo trước khi truy xuất
            Debug.Assert(expenseLimit != NULL_EXPENSE, "Hạn mức chi tiêu dự án chưa được khởi tạo!");
            return expenseLimit;
        }
    }
}
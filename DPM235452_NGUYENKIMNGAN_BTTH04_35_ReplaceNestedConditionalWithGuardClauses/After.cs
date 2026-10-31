using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_35_ReplaceNestedConditionalWithGuardClauses
{
    public class PayrollAfter
    {
        public double GetPayAmount(Employee employee)
        {
            // Dùng Guard Clauses để xử lý các trường hợp đặc biệt và return ngay
            if (employee.IsDead) return DeadAmount();
            if (employee.IsSeparated) return SeparatedAmount();
            if (employee.IsRetired) return RetiredAmount();

            // Luồng xử lý chính cho trường hợp nhân viên bình thường nằm phẳng ở cuối
            return NormalPayAmount();
        }

        private double DeadAmount() => 1000.0;
        private double SeparatedAmount() => 2000.0;
        private double RetiredAmount() => 3000.0;
        private double NormalPayAmount() => 5000.0;
    }
}
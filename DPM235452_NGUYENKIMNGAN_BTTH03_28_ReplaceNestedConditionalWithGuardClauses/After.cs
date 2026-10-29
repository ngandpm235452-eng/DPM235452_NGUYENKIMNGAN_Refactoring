using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_28_ReplaceNestedConditionalWithGuardClauses
{
    public class After
    {
        // Tái cấu trúc: Sử dụng Guard Clauses (thoát sớm với return) để loại bỏ hoàn toàn các cấu trúc if-else lồng nhau
        public double GetPayAmount(bool isDead, bool isSeparated, bool isRetired)
        {
            if (isDead) return DeadAmount();
            if (isSeparated) return SeparatedAmount();
            if (isRetired) return RetiredAmount();

            return NormalPayAmount();
        }

        private double DeadAmount() => 5000.0;
        private double SeparatedAmount() => 2000.0;
        private double RetiredAmount() => 3000.0;
        private double NormalPayAmount() => 1000.0;
    }
}
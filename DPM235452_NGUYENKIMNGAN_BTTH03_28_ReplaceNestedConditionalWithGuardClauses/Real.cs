using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_28_ReplaceNestedConditionalWithGuardClauses
{
    public enum EmployeeStatus
    {
        Active,
        Retired,
        Separated,
        Deceased
    }

    // Ứng dụng thực tế: Kết hợp Enum, Guard Clauses để xử lý điều kiện ngoại lệ/đặc biệt trước, sau đó mới tính lương chính
    public class Real
    {
        public double CalculatePayout(EmployeeStatus status, double baseSalary, int yearsOfService)
        {
            if (baseSalary < 0)
                throw new ArgumentOutOfRangeException(nameof(baseSalary), "Lương cơ bản không được nhỏ hơn 0.");
            if (yearsOfService < 0)
                throw new ArgumentOutOfRangeException(nameof(yearsOfService), "Số năm công tác không được nhỏ hơn 0.");

            // Guard Clauses xử lý các trường hợp trạng thái đặc biệt
            if (status == EmployeeStatus.Deceased) return CalculateDeceasedPayout(baseSalary);
            if (status == EmployeeStatus.Separated) return CalculateSeparatedPayout(baseSalary);
            if (status == EmployeeStatus.Retired) return CalculateRetiredPayout(baseSalary, yearsOfService);

            // Luồng xử lý chính cho nhân viên đang làm việc (Active)
            return baseSalary + (yearsOfService * 500_000);
        }

        private double CalculateDeceasedPayout(double baseSalary) => baseSalary * 5.0;
        private double CalculateSeparatedPayout(double baseSalary) => baseSalary * 1.5;
        private double CalculateRetiredPayout(double baseSalary, int years) => baseSalary * 3.0 + (years * 200_000);
    }
}
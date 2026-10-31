using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_61_ExtractInterface
{
    public class EmployeeBefore
    {
        public string Name { get; set; }
        public double Rate { get; set; }

        public EmployeeBefore(string name, double rate)
        {
            Name = name;
            Rate = rate;
        }

        public double GetRate() => Rate;

        public bool HasSpecialSkill() => Rate > 50.0;
    }

    // Lớp tính toán chi phí phụ thuộc trực tiếp vào lớp cụ thể EmployeeBefore
    public class TimeSheetBefore
    {
        // Vi phạm: Phương thức Charge phụ thuộc trực tiếp vào lớp cụ thể EmployeeBefore, 
        // làm giảm tính linh hoạt và không thể tái sử dụng cho các thực thể tính phí khác (như Nhà thầu, Thiết bị...)
        public double Charge(EmployeeBefore employee, int hours)
        {
            double result = employee.GetRate() * hours;
            if (employee.HasSpecialSkill())
            {
                result *= 1.15; // Phụ phí cho kỹ năng đặc biệt
            }
            return result;
        }
    }
}
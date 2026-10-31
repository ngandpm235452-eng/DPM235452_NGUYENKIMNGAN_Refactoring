using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_61_ExtractInterface
{
    // Tái cấu trúc: Trích xuất giao diện IBillable cho các đối tượng có khả năng tính phí
    public interface IBillable
    {
        double GetRate();
        bool HasSpecialSkill();
    }

    public class EmployeeAfter : IBillable
    {
        public string Name { get; set; }
        public double Rate { get; set; }

        public EmployeeAfter(string name, double rate)
        {
            Name = name;
            Rate = rate;
        }

        public double GetRate() => Rate;

        public bool HasSpecialSkill() => Rate > 50.0;
    }

    public class TimeSheetAfter
    {
        // Tái cấu trúc: Giờ đây TimeSheet phụ thuộc vào giao diện IBillable trừu tượng, 
        // cho phép tính phí cho bất kỳ đối tượng nào triển khai IBillable
        public double Charge(IBillable billable, int hours)
        {
            double result = billable.GetRate() * hours;
            if (billable.HasSpecialSkill())
            {
                result *= 1.15; // Phụ phí cho kỹ năng đặc biệt
            }
            return result;
        }
    }
}
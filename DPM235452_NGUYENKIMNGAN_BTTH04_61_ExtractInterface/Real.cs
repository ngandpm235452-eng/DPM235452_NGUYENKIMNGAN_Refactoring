using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_61_ExtractInterface
{
    // Lớp Nhà thầu phụ triển khai giao diện IBillable
    public class ContractorAfter : IBillable
    {
        public string CompanyName { get; set; }
        public double HourlyRate { get; set; }
        public bool IsExpert { get; set; }

        public ContractorAfter(string companyName, double hourlyRate, bool isExpert)
        {
            CompanyName = companyName;
            HourlyRate = hourlyRate;
            IsExpert = isExpert;
        }

        public double GetRate() => HourlyRate;
        public bool HasSpecialSkill() => IsExpert;
    }

    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            TimeSheetAfter timeSheet = new TimeSheetAfter();

            // Khởi tạo các thực thể khác nhau cùng triển khai giao diện IBillable
            IBillable emp1 = new EmployeeAfter("Nguyễn Văn A", 40.0);
            IBillable emp2 = new EmployeeAfter("Trần Thị B", 65.0);
            IBillable contractor = new ContractorAfter("Công ty Cung ứng TechCorp", 80.0, true);

            Console.WriteLine("==================================================");
            Console.WriteLine("   HỆ THỐNG TÍNH CHI PHÍ DỊCH VỤ VÀ THỜI GIAN     ");
            Console.WriteLine("==================================================\n");

            int hoursWorked = 40;

            Console.WriteLine($"1. Nhân viên chính thức A (Đơn giá ${emp1.GetRate()}/h):");
            Console.WriteLine($"  - Chi phí 40h làm việc: ${timeSheet.Charge(emp1, hoursWorked):N2}\n");

            Console.WriteLine($"2. Nhân viên chuyên gia B (Đơn giá ${emp2.GetRate()}/h):");
            Console.WriteLine($"  - Chi phí 40h làm việc (Có phụ phí): ${timeSheet.Charge(emp2, hoursWorked):N2}\n");

            Console.WriteLine($"3. Đối tác Nhà thầu TechCorp (Đơn giá ${contractor.GetRate()}/h):");
            Console.WriteLine($"  - Chi phí 40h làm việc (Có phụ phí): ${timeSheet.Charge(contractor, hoursWorked):N2}\n");

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Lưu ý: Việc trích xuất giao diện IBillable giúp hệ thống");
            Console.WriteLine("dễ dàng mở rộng cho các loại hình đối tượng mới mà không");
            Console.WriteLine("cần chỉnh sửa phương thức tính chi phí Charge().");
            Console.WriteLine("==================================================");

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_43_ParameterizeMethod
{
    public class EmployeeRecord
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public double RaiseRate { get; set; }
        public EmployeeAfter EmployeeData { get; set; }

        public EmployeeRecord(string name, string position, double raiseRate, double salary)
        {
            Name = name;
            Position = position;
            RaiseRate = raiseRate;
            EmployeeData = new EmployeeAfter(salary);
        }
    }

    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<EmployeeRecord> staff = new List<EmployeeRecord>
            {
                new EmployeeRecord("Nguyễn Văn A", "Quản lý", 0.15, 2000.0),            // Tăng 15%
                new EmployeeRecord("Trần Thị B", "Nhân viên chính thức", 0.10, 1200.0), // Tăng 10%
                new EmployeeRecord("Lê Văn C", "Thực tập sinh", 0.05, 500.0)            // Tăng 5%
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG ĐIỀU CHỈNH TĂNG LƯƠNG NHÂN VIÊN      ");
            Console.WriteLine("==================================================\n");

            foreach (var emp in staff)
            {
                Console.WriteLine($"Nhân viên : {emp.Name} ({emp.Position})");
                Console.WriteLine($"  - Lương ban đầu   : ${emp.EmployeeData.Salary:N2}");
                Console.WriteLine($"  - Tỷ lệ tăng      : {emp.RaiseRate * 100}%");

                // Gọi duy nhất 1 phương thức Raise() linh hoạt với tham số tương ứng
                emp.EmployeeData.Raise(emp.RaiseRate);

                Console.WriteLine($"  -> Lương sau tăng : ${emp.EmployeeData.Salary:N2}\n");
            }

            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}
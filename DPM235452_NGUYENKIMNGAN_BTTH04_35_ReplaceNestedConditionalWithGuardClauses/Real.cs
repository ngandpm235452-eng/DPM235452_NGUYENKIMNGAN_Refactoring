using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_35_ReplaceNestedConditionalWithGuardClauses
{
    public class EmployeeRecord
    {
        public string Name { get; set; }
        public Employee Status { get; set; }

        public EmployeeRecord(string name, Employee status)
        {
            Name = name;
            Status = status;
        }
    }

    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            PayrollAfter payrollService = new PayrollAfter();

            List<EmployeeRecord> employees = new List<EmployeeRecord>
            {
                new EmployeeRecord("Nguyễn Văn A", new Employee(false, false, false)), // Nhân viên bình thường
                new EmployeeRecord("Trần Thị B", new Employee(false, false, true)),  // Nhân viên đã nghỉ hưu
                new EmployeeRecord("Lê Văn C", new Employee(false, true, false)),   // Nhân viên đã nghỉ việc
                new EmployeeRecord("Phạm Văn D", new Employee(true, false, false))   // Nhân viên đã mất
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("     HỆ THỐNG TÍNH LƯƠNG / TRỢ CẤP NHÂN VIÊN      ");
            Console.WriteLine("==================================================\n");

            foreach (var emp in employees)
            {
                double amount = payrollService.GetPayAmount(emp.Status);
                Console.WriteLine($"Nhân viên: {emp.Name}");
                Console.WriteLine($"  - Số tiền chi trả: ${amount:N2}\n");
            }

            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_36_ReplaceConditionalWithPolymorphism
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // Tận dụng tính đa hình: Quản lý danh sách nhân viên thông qua lớp cha
            List<EmployeeAfter> employees = new List<EmployeeAfter>
            {
                new Engineer(),
                new Salesman(),
                new Manager(),
                new Engineer()
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG TÍNH LƯƠNG NHÂN VIÊN (ĐA HÌNH)      ");
            Console.WriteLine("==================================================\n");

            double totalPayroll = 0;

            foreach (var emp in employees)
            {
                // Gọi phương thức GetPayAmount() tương ứng với từng lớp con cụ thể
                double pay = emp.GetPayAmount();
                totalPayroll += pay;

                Console.WriteLine($"Chức vụ: {emp.GetType().Name,-10} | Lương thực nhận: ${pay:N2}");
            }

            Console.WriteLine("\n--------------------------------------------------");
            Console.WriteLine($"TỔNG TIỀN LƯƠNG CÔNG TY TRẢ: ${totalPayroll:N2}");
            Console.WriteLine("==================================================");

            Console.ReadLine();
        }
    }
}
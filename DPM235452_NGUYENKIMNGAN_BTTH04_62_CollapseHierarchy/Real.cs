using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_62_CollapseHierarchy
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<EmployeeAfter> employees = new List<EmployeeAfter>
            {
                new EmployeeAfter("Nguyễn Văn A", 1200.0),
                new EmployeeAfter("Trần Thị B", 1500.0)
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG QUẢN LÝ NHÂN VIÊN (GỘP BẬC THỪA KẾ)  ");
            Console.WriteLine("==================================================\n");

            foreach (var emp in employees)
            {
                Console.WriteLine($"Nhân viên : {emp.Name}");
                Console.WriteLine($"  - Mức lương hàng tháng: ${emp.Salary:N2}\n");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Lưu ý: Lớp con Salesman đã được gộp trực tiếp vào");
            Console.WriteLine("lớp EmployeeAfter nhằm đơn giản hóa cấu trúc hệ thống,");
            Console.WriteLine("loại bỏ các lớp thừa không còn vai trò riêng biệt.");
            Console.WriteLine("==================================================");

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_54_PullUpField
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<EmployeeAfter> employees = new List<EmployeeAfter>
            {
                new SalesmanAfter("Nguyễn Văn A"),
                new EngineerAfter("Trần Thị B")
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG QUẢN LÝ DANH SÁCH NHÂN VIÊN         ");
            Console.WriteLine("==================================================\n");

            foreach (var emp in employees)
            {
                string position = emp is SalesmanAfter ? "Nhân viên Kinh doanh" : "Kỹ sư Phần mềm";

                // Trường _name được truy xuất đồng nhất từ lớp cha EmployeeAfter
                Console.WriteLine($"Họ và tên : {emp.GetName()}");
                Console.WriteLine($"  - Vị trí làm việc : {position}\n");
            }

            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}
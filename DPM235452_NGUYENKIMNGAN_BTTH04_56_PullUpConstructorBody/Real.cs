using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_56_PullUpConstructorBody
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            List<EmployeeAfter> employees = new List<EmployeeAfter>
            {
                new ManagerAfter("NV001", "Nguyễn Văn A", 3),
                new EngineerAfter("NV002", "Trần Thị B", "Lập trình C# .NET")
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("   HỆ THỐNG QUẢN LÝ KHỞI TẠO HỒ SƠ NHÂN VIÊN      ");
            Console.WriteLine("==================================================\n");

            foreach (var emp in employees)
            {
                Console.WriteLine($"Mã nhân viên : {emp.Id}");
                Console.WriteLine($"Họ và tên    : {emp.Name}");

                if (emp is ManagerAfter mgr)
                {
                    Console.WriteLine($"Chức vụ      : Quản lý (Cấp độ: {mgr.Grade})");
                }
                else if (emp is EngineerAfter eng)
                {
                    Console.WriteLine($"Chức vụ      : Kỹ sư (Chuyên môn: {eng.Specialization})");
                }
                Console.WriteLine();
            }

            Console.WriteLine("==================================================");
            Console.ReadLine();
        }
    }
}
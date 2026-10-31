using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_38_IntroduceAssertion
{
    public class ProjectBudget
    {
        public string ProjectName { get; set; }
        public ExpenseProjectAfter ExpenseManager { get; set; }

        public ProjectBudget(string name)
        {
            ProjectName = name;
            ExpenseManager = new ExpenseProjectAfter();
        }
    }

    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("==================================================");
            Console.WriteLine("   HỆ THỐNG QUẢN LÝ HẠN MỨC NGÂN SÁCH DỰ ÁN        ");
            Console.WriteLine("==================================================\n");

            // Dự án 1: Khởi tạo hợp lệ
            ProjectBudget project1 = new ProjectBudget("Dự án Nâng cấp Server");
            project1.ExpenseManager.SetExpenseLimit(15000.0);

            Console.WriteLine($"Dự án: {project1.ProjectName}");
            Console.WriteLine($"  - Hạn mức ngân sách: ${project1.ExpenseManager.GetExpenseLimit():N2}\n");

            // Dự án 2: Khởi tạo hợp lệ
            ProjectBudget project2 = new ProjectBudget("Dự án Xây dựng Website");
            project2.ExpenseManager.SetExpenseLimit(8500.0);

            Console.WriteLine($"Dự án: {project2.ProjectName}");
            Console.WriteLine($"  - Hạn mức ngân sách: ${project2.ExpenseManager.GetExpenseLimit():N2}\n");

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Lưu ý: Các câu lệnh Debug.Assert sẽ phát hiện lỗi");
            Console.WriteLine("ngay trong quá trình phát triển (Debug mode) nếu");
            Console.WriteLine("dữ liệu vi phạm các quy tắc giả định.");
            Console.WriteLine("==================================================");

            Console.ReadLine();
        }
    }
}
using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_60_ExtractSuperclass
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            EmployeeAfter emp1 = new EmployeeAfter("Nguyễn Văn A", "NV01", 1500.0);
            EmployeeAfter emp2 = new EmployeeAfter("Trần Thị B", "NV02", 2000.0);

            DepartmentAfter devDept = new DepartmentAfter("Phòng Phát Triển Phần Mềm");
            devDept.AddMember(emp1);
            devDept.AddMember(emp2);

            // Quản lý đồng nhất cả nhân viên cá nhân và phòng ban thông qua lớp cha PartyAfter
            List<PartyAfter> parties = new List<PartyAfter>
            {
                emp1,
                emp2,
                devDept
            };

            Console.WriteLine("==================================================");
            Console.WriteLine("   HỆ THỐNG QUẢN LÝ VÀ THỐNG KÊ CHI PHÍ THƯỜNG NIÊN");
            Console.WriteLine("==================================================\n");

            foreach (var party in parties)
            {
                string type = party is DepartmentAfter ? "Tập thể / Phòng ban" : "Cá nhân Nhân viên";
                Console.WriteLine($"Đối tượng    : {party.Name} ({type})");
                Console.WriteLine($"  -> Chi phí hàng năm: ${party.GetAnnualCost():N2}\n");
            }

            Console.WriteLine("--------------------------------------------------");
            Console.WriteLine("Lưu ý: Lớp cha PartyAfter được trích xuất giúp quản lý");
            Console.WriteLine("đồng nhất cả nhân viên và phòng ban thông qua tính đa hình.");
            Console.WriteLine("==================================================");

            Console.ReadLine();
        }
    }
}
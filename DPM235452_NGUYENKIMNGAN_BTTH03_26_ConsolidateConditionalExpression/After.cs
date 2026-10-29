using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_20_ReplaceArrayWithObject
{
    public class PerformanceAfter
    {
        public string Name { get; set; }
        public int Wins { get; set; }
    }

    public class After
    {
        // Tái cấu trúc: Thay thế mảng bằng đối tượng PerformanceAfter có tên thuộc tính và kiểu dữ liệu rõ ràng
        public PerformanceAfter GetPerformanceData()
        {
            return new PerformanceAfter
            {
                Name = "Liverpool",
                Wins = 15
            };
        }
    }
}
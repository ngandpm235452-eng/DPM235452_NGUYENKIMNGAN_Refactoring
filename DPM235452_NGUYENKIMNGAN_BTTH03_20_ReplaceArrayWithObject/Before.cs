using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_20_ReplaceArrayWithObject
{
    public class Before
    {
        // Code Smell: Primitive Obsession / Array Abuse - Sử dụng mảng string[] chứa các phần tử mang ý nghĩa khác hẳn nhau (Tên đội, Số trận thắng)
        public string[] GetPerformanceData()
        {
            string[] row = new string[2];
            row[0] = "Liverpool"; // Tên đội
            row[1] = "15";        // Số trận thắng (phải lưu dạng chuỗi)
            return row;
        }
    }
}
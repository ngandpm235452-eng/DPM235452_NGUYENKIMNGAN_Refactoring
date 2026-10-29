using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_20_ReplaceArrayWithObject
{
    // Ứng dụng thực tế: Thiết kế class strongly-typed, thuộc tính chỉ đọc (readonly) và kiểm tra tính hợp lệ dữ liệu
    public class PerformanceReal
    {
        public string TeamName { get; }
        public int Wins { get; }

        public PerformanceReal(string teamName, int wins)
        {
            if (string.IsNullOrWhiteSpace(teamName))
                throw new ArgumentException("Tên đội không được để trống.", nameof(teamName));
            if (wins < 0)
                throw new ArgumentOutOfRangeException(nameof(wins), "Số trận thắng không được nhỏ hơn 0.");

            TeamName = teamName.Trim();
            Wins = wins;
        }
    }

    public class Real
    {
        public PerformanceReal GetPerformanceData()
        {
            return new PerformanceReal("Liverpool", 15);
        }
    }
}
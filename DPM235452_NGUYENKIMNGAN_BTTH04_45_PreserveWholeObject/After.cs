using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_45_PreserveWholeObject
{
    public class HeatingPlanAfter
    {
        private TempRange _range = new TempRange(18, 25);

        // Tái cấu trúc: Truyền toàn bộ đối tượng TempRange làm tham số
        public bool WithinRange(TempRange roomRange)
        {
            return (roomRange.Low >= _range.Low && roomRange.High <= _range.High);
        }
    }
}
using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_45_PreserveWholeObject
{
    public class TempRange
    {
        public int Low { get; set; }
        public int High { get; set; }

        public TempRange(int low, int high)
        {
            Low = low;
            High = high;
        }
    }

    public class HeatingPlanBefore
    {
        private TempRange _range = new TempRange(18, 25);

        // Vi phạm: Bóc tách thuộc tính lẻ (low, high) thay vì truyền cả đối tượng TempRange
        public bool WithinRange(int low, int high)
        {
            return (low >= _range.Low && high <= _range.High);
        }
    }
}
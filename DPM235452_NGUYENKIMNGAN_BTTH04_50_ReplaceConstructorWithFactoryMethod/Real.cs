using System;
using System.Collections;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_51_EncapsulateDowncast
{
    public class Reading
    {
        public int Value { get; set; }
        public DateTime Date { get; set; }

        public Reading(int value, DateTime date)
        {
            Value = value;
            Date = date;
        }
    }

    public class SiteBefore
    {
        private ArrayList _readings = new ArrayList();

        public void AddReading(Reading reading)
        {
            _readings.Add(reading);
        }

        // Vi phạm: Phương thức trả về kiểu generic/object buộc các nơi gọi phải tự ép kiểu downcast
        public object LastReading()
        {
            if (_readings.Count == 0) return null;
            return _readings[_readings.Count - 1];
        }
    }
}
using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_19_ChangeReferenceToValue
{
    // Tái cấu trúc: Biến Currency thành Value Object bất biến (Immutable), ghi đè Equals và GetHashCode để so sánh bằng giá trị
    public class CurrencyAfter
    {
        public string Code { get; }

        public CurrencyAfter(string code)
        {
            Code = code;
        }

        public override bool Equals(object obj)
        {
            if (obj is CurrencyAfter other)
            {
                return Code == other.Code;
            }
            return false;
        }

        public override int GetHashCode()
        {
            return Code != null ? Code.GetHashCode() : 0;
        }
    }

    public class After
    {
        public CurrencyAfter Currency { get; }

        public After(CurrencyAfter currency)
        {
            Currency = currency;
        }
    }
}
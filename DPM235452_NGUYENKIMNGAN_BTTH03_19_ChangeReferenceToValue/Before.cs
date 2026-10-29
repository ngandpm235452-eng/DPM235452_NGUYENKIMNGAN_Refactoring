using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_19_ChangeReferenceToValue
{
    public class CurrencyBefore
    {
        public string Code { get; set; }

        public CurrencyBefore(string code)
        {
            Code = code;
        }
    }

    public class Before
    {
        // Code Smell: Reference Object - Đối tượng Currency có thể bị chỉnh sửa (Mutable). Khi dùng chung tham chiếu, việc sửa ở một nơi sẽ gây lỗi ngoài ý muốn ở nơi khác (Side-effects)
        public CurrencyBefore Currency { get; set; }

        public Before(CurrencyBefore currency)
        {
            Currency = currency;
        }
    }
}
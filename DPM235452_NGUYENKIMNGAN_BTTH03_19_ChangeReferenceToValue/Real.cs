using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_19_ChangeReferenceToValue
{
    // Ứng dụng thực tế: Thiết kế Value Object bất biến hoàn chỉnh triển khai IEquatable<T>, nạp chồng toán tử ==, != và validate mã tiền tệ ISO 3 ký tự
    public sealed class CurrencyReal : IEquatable<CurrencyReal>
    {
        public string Code { get; }

        public CurrencyReal(string code)
        {
            if (string.IsNullOrWhiteSpace(code) || code.Trim().Length != 3)
                throw new ArgumentException("Mã tiền tệ phải bao gồm đúng 3 ký tự (VD: VND, USD).", nameof(code));

            Code = code.Trim().ToUpper();
        }

        public bool Equals(CurrencyReal other)
        {
            if (other is null) return false;
            if (ReferenceEquals(this, other)) return true;
            return Code == other.Code;
        }

        public override bool Equals(object obj) => Equals(obj as CurrencyReal);

        public override int GetHashCode() => Code.GetHashCode();

        public static bool operator ==(CurrencyReal left, CurrencyReal right)
        {
            if (left is null) return right is null;
            return left.Equals(right);
        }

        public static bool operator !=(CurrencyReal left, CurrencyReal right) => !(left == right);
    }

    public class Real
    {
        public CurrencyReal Currency { get; }
        public decimal Amount { get; }

        public Real(decimal amount, CurrencyReal currency)
        {
            if (amount < 0)
                throw new ArgumentOutOfRangeException(nameof(amount), "Số tiền không được nhỏ hơn 0.");

            Amount = amount;
            Currency = currency ?? throw new ArgumentNullException(nameof(currency));
        }
    }
}
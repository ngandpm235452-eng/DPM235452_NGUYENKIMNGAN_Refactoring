using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_52_ReplaceErrorCodeWithException
{
    public class AccountAfter
    {
        private double _balance;

        public AccountAfter(double balance)
        {
            _balance = balance;
        }

        public double Balance => _balance;

        // Tái cấu trúc: Thay thế mã lỗi bằng việc ném ra ngoại lệ (Exception) minh bạch
        public void Withdraw(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Số tiền rút phải lớn hơn 0!");
            }
            if (amount > _balance)
            {
                throw new InvalidOperationException("Số dư tài khoản không đủ để thực hiện giao dịch!");
            }

            _balance -= amount;
        }
    }
}
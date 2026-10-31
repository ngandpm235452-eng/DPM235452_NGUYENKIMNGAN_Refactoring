using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_52_ReplaceErrorCodeWithException
{
    public class AccountBefore
    {
        private double _balance;

        public AccountBefore(double balance)
        {
            _balance = balance;
        }

        public double Balance => _balance;

        // Vi phạm: Trả về mã lỗi (-1, -2) thay vì ném Exception, buộc nơi gọi phải tự nhớ mã lỗi
        public int Withdraw(double amount)
        {
            if (amount <= 0) return -2;         // Mã lỗi -2: Số tiền không hợp lệ
            if (amount > _balance) return -1;   // Mã lỗi -1: Số dư không đủ

            _balance -= amount;
            return 0;                           // Mã 0: Thành công
        }
    }
}
using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_52_ReplaceErrorCodeWithException
{
    public class Real
    {
        public static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            AccountAfter account = new AccountAfter(1000.0);

            Console.WriteLine("==================================================");
            Console.WriteLine("    HỆ THỐNG GIAO DỊCH RÚT TIỀN TÀI KHOẢN         ");
            Console.WriteLine("==================================================\n");

            Console.WriteLine($"Số dư ban đầu: ${account.Balance:N2}\n");

            // Lần 1: Rút hợp lệ
            ExecuteWithdrawal(account, 300.0);

            // Lần 2: Rút vượt quá số dư hiện tại (Xử lý Exception)
            ExecuteWithdrawal(account, 1200.0);

            // Lần 3: Rút số tiền không hợp lệ (Xử lý Exception)
            ExecuteWithdrawal(account, -50.0);

            Console.WriteLine("==================================================");
            Console.ReadLine();
        }

        private static void ExecuteWithdrawal(AccountAfter account, double amount)
        {
            Console.WriteLine($"-> Thực hiện giao dịch rút: ${amount:N2}");
            try
            {
                account.Withdraw(amount);
                Console.WriteLine($"   [THÀNH CÔNG] Rút tiền thành công. Số dư còn lại: ${account.Balance:N2}\n");
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine($"   [LỖI THAM SỐ]: {ex.Message}\n");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"   [LỖI TÁC VỤ]: {ex.Message}\n");
            }
        }
    }
}
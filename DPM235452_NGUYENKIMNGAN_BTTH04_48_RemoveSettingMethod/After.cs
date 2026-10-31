using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_48_RemoveSettingMethod
{
    public class AccountAfter
    {
        private readonly string _accountId;

        // Giá trị chỉ được khởi tạo duy nhất một lần thông qua Constructor
        public AccountAfter(string accountId)
        {
            _accountId = accountId;
        }

        // Tái cấu trúc: Loại bỏ Setter hoàn toàn, biến trường dữ liệu thành Read-Only
        public string AccountId => _accountId;
    }
}
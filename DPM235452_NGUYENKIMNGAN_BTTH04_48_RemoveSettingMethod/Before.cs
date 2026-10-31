using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_48_RemoveSettingMethod
{
    public class AccountBefore
    {
        private string _accountId;

        public AccountBefore(string accountId)
        {
            _accountId = accountId;
        }

        public string AccountId
        {
            get { return _accountId; }
            // Vi phạm: Phương thức Setter cho phép thay đổi Mã tài khoản bất kỳ lúc nào, làm mất tính toàn vẹn dữ liệu
            set { _accountId = value; }
        }
    }
}
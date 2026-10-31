using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_42_SeparateQueryFromModifier
{
    public class SecurityCheckerAfter
    {
        // 1. Hàm Query: Chỉ tìm kiếm và trả về dữ liệu, hoàn toàn KHÔNG gây tác dụng phụ
        public string FoundMiscreant(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == "Don" || people[i] == "John")
                {
                    return people[i];
                }
            }
            return string.Empty;
        }

        // 2. Hàm Modifier: Chỉ thực hiện hành động thay đổi trạng thái/gửi thông báo
        public void SendAlert(string[] people)
        {
            string miscreant = FoundMiscreant(people);
            if (!string.IsNullOrEmpty(miscreant))
            {
                SendAlertNotification(miscreant);
            }
        }

        private void SendAlertNotification(string person)
        {
            Console.WriteLine($"[CẢNH BÁO]: Phát hiện người trong danh sách cấm: {person}");
        }
    }
}
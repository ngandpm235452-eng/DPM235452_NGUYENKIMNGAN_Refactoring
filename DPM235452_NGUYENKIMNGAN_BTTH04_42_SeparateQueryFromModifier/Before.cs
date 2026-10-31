using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_42_SeparateQueryFromModifier
{
    public class SecurityCheckerBefore
    {
        // Vi phạm: Phương thức vừa thực hiện Query (tìm người) vừa thực hiện Modifier (gửi cảnh báo)
        public string CheckForMiscreantAndAlert(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == "Don" || people[i] == "John")
                {
                    SendAlert(people[i]); // Tác dụng phụ (Side-effect / Modifier)
                    return people[i];      // Trả về giá trị (Query)
                }
            }
            return string.Empty;
        }

        private void SendAlert(string person)
        {
            Console.WriteLine($"[CẢNH BÁO]: Phát hiện người trong danh sách cấm: {person}");
        }
    }
}
using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_34_RemoveControlFlag
{
    public class SecurityCheckerBefore
    {
        public void CheckSecurity(string[] people)
        {
            bool found = false; // Biến cờ điều khiển (Control Flag)

            for (int i = 0; i < people.Length; i++)
            {
                if (!found)
                {
                    if (people[i] == "Don" || people[i] == "John")
                    {
                        SendAlert(people[i]);
                        found = true; // Đặt giá trị biến cờ để dừng xử lý ở các vòng lặp tiếp theo
                    }
                }
            }
        }

        private void SendAlert(string person)
        {
            Console.WriteLine($"[CẢNH BÁO]: Phát hiện người trong danh sách đen: {person}");
        }
    }
}
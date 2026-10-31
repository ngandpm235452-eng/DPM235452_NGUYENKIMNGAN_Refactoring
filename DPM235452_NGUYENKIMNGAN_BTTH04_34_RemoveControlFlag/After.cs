using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_34_RemoveControlFlag
{
    public class SecurityCheckerAfter
    {
        public void CheckSecurity(string[] people)
        {
            for (int i = 0; i < people.Length; i++)
            {
                if (people[i] == "Don" || people[i] == "John")
                {
                    SendAlert(people[i]);
                    return; // Bỏ biến cờ, thoát trực tiếp khỏi hàm ngay khi thỏa điều kiện
                }
            }
        }

        private void SendAlert(string person)
        {
            Console.WriteLine($"[CẢNH BÁO]: Phát hiện người trong danh sách đen: {person}");
        }
    }
}
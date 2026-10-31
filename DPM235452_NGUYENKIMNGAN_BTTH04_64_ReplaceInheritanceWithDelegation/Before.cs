using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_64_ReplaceInheritanceWithDelegation
{
    // Vi phạm: MyStackBefore kế thừa trực tiếp List<string>, làm lộ các phương thức truy xuất/chèn/xóa ở vị trí bất kỳ
    // của List (vi phạm nguyên tắc đóng gói LIFO của Stack)
    public class MyStackBefore : List<string>
    {
        public void Push(string item)
        {
            Add(item);
        }

        public string Pop()
        {
            if (Count == 0) throw new InvalidOperationException("Stack đang rỗng!");
            string result = this[Count - 1];
            RemoveAt(Count - 1);
            return result;
        }
    }
}
using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_64_ReplaceInheritanceWithDelegation
{
    // Tái cấu trúc: Bỏ thừa kế, chuyển sang ủy quyền (Delegation) để bảo vệ tính đóng gói của Stack
    public class MyStackAfter
    {
        private readonly List<string> _list = new List<string>();

        public void Push(string item)
        {
            _list.Add(item);
        }

        public string Pop()
        {
            if (IsEmpty) throw new InvalidOperationException("Stack đang rỗng!");
            string result = _list[_list.Count - 1];
            _list.RemoveAt(_list.Count - 1);
            return result;
        }

        public bool IsEmpty => _list.Count == 0;
        public int Count => _list.Count;
    }
}
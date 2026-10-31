using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_53_ReplaceExceptionWithTest
{
    public class ResourcePoolAfter
    {
        private Stack<string> _availableResources = new Stack<string>();

        public ResourcePoolAfter()
        {
            _availableResources.Push("Tài nguyên A");
            _availableResources.Push("Tài nguyên B");
        }

        // Tái cấu trúc: Dùng câu lệnh kiểm tra (if) để kiểm tra trạng thái trước khi lấy tài nguyên
        public string GetResource()
        {
            if (_availableResources.Count == 0)
            {
                return "Tài nguyên mới cấp phát bổ sung";
            }
            return _availableResources.Pop();
        }
    }
}
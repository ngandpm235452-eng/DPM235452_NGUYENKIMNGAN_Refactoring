using System;
using System.Collections.Generic;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_53_ReplaceExceptionWithTest
{
    public class ResourcePoolBefore
    {
        private Stack<string> _availableResources = new Stack<string>();

        public ResourcePoolBefore()
        {
            _availableResources.Push("Tài nguyên A");
            _availableResources.Push("Tài nguyên B");
        }

        // Vi phạm: Sử dụng khối try-catch để kiểm tra trường hợp danh sách rỗng (luồng điều khiển thông thường)
        public string GetResource()
        {
            try
            {
                return _availableResources.Pop();
            }
            catch (InvalidOperationException)
            {
                // Xử lý logic nghiệp vụ bình thường trong khối catch làm giảm hiệu năng và mờ logic
                return "Tài nguyên mới cấp phát bổ sung";
            }
        }
    }
}
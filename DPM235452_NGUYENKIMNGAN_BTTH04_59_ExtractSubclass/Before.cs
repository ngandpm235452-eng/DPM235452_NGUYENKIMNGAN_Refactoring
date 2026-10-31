using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_59_ExtractSubclass
{
    public class JobItemBefore
    {
        private int _unitPrice;
        private int _quantity;
        private bool _isLabor;
        private EmployeeBefore _employee;

        // Vi phạm: Dùng cờ _isLabor và gánh trách nhiệm của cả công việc vật tư lẫn công việc nhân công trong cùng 1 lớp
        public JobItemBefore(int unitPrice, int quantity, bool isLabor, EmployeeBefore employee)
        {
            _unitPrice = unitPrice;
            _quantity = quantity;
            _isLabor = isLabor;
            _employee = employee;
        }

        public int GetTotalPrice()
        {
            return _quantity * GetUnitPrice();
        }

        public int GetUnitPrice()
        {
            return _isLabor ? _employee.Rate : _unitPrice;
        }

        public EmployeeBefore Employee => _employee;
    }

    public class EmployeeBefore
    {
        public int Rate { get; set; }

        public EmployeeBefore(int rate)
        {
            Rate = rate;
        }
    }
}
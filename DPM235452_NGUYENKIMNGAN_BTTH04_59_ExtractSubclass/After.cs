using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH04_59_ExtractSubclass
{
    // Lớp cơ sở xử lý các hạng mục công việc vật tư / thông thường
    public class JobItemAfter
    {
        private int _unitPrice;
        private int _quantity;

        public JobItemAfter(int unitPrice, int quantity)
        {
            _unitPrice = unitPrice;
            _quantity = quantity;
        }

        public int Quantity => _quantity;

        public virtual int GetTotalPrice()
        {
            return _quantity * GetUnitPrice();
        }

        public virtual int GetUnitPrice()
        {
            return _unitPrice;
        }

        public virtual bool IsLabor => false;
    }

    // Tái cấu trúc: Trích xuất lớp con LaborItemAfter chuyên xử lý các hạng mục tính theo chi phí nhân công
    public class LaborItemAfter : JobItemAfter
    {
        private EmployeeAfter _employee;

        public LaborItemAfter(int quantity, EmployeeAfter employee) : base(0, quantity)
        {
            _employee = employee;
        }

        public EmployeeAfter Employee => _employee;

        public override int GetUnitPrice()
        {
            return _employee.Rate;
        }

        public override bool IsLabor => true;
    }

    public class EmployeeAfter
    {
        public int Rate { get; set; }

        public EmployeeAfter(int rate)
        {
            Rate = rate;
        }
    }
}
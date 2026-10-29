using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_29_ReplaceConditionalWithPolymorphism
{
    public class BirdBefore
    {
        public const int EUROPEAN = 0;
        public const int AFRICAN = 1;
        public const int NORWEGIAN_BLUE = 2;

        public int Type { get; set; }
        public double Voltage { get; set; }
        public bool IsNailed { get; set; }

        public double GetSpeed()
        {
            // Code Smell: Switch Statements - Câu lệnh switch kiểm tra mã loại để thực hiện các công thức tính toán khác nhau
            switch (Type)
            {
                case EUROPEAN:
                    return GetBaseSpeed();
                case AFRICAN:
                    return GetBaseSpeed() - GetLoadFactor() * 1.5;
                case NORWEGIAN_BLUE:
                    return IsNailed ? 0 : GetBaseSpeed(Voltage);
                default:
                    throw new InvalidOperationException("Loài chim không hợp lệ.");
            }
        }

        private double GetBaseSpeed() => 10.0;
        private double GetBaseSpeed(double voltage) => voltage * 1.5;
        private double GetLoadFactor() => 1.5;
    }

    public class Before
    {
        public double CalculateSpeed(int type)
        {
            var bird = new BirdBefore { Type = type, Voltage = 12, IsNailed = false };
            return bird.GetSpeed();
        }
    }
}
using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_29_ReplaceConditionalWithPolymorphism
{
    // Ứng dụng thực tế: Áp dụng đa hình để tính phí dịch vụ vận chuyển cho từng hình thức giao hàng (Standard, Express, SameDay)
    public abstract class ShippingCalculatorReal
    {
        public double BaseWeight { get; }

        protected ShippingCalculatorReal(double baseWeight)
        {
            if (baseWeight <= 0)
                throw new ArgumentOutOfRangeException(nameof(baseWeight), "Trọng lượng đơn hàng phải lớn hơn 0.");

            BaseWeight = baseWeight;
        }

        public abstract double CalculateShippingCost();
    }

    public class StandardShippingReal : ShippingCalculatorReal
    {
        public StandardShippingReal(double baseWeight) : base(baseWeight) { }

        public override double CalculateShippingCost() => BaseWeight * 10_000;
    }

    public class ExpressShippingReal : ShippingCalculatorReal
    {
        public ExpressShippingReal(double baseWeight) : base(baseWeight) { }

        public override double CalculateShippingCost() => (BaseWeight * 10_000) + 30_000;
    }

    public class SameDayShippingReal : ShippingCalculatorReal
    {
        public bool IsDistanceOver20Km { get; }

        public SameDayShippingReal(double baseWeight, bool isDistanceOver20Km) : base(baseWeight)
        {
            IsDistanceOver20Km = isDistanceOver20Km;
        }

        public override double CalculateShippingCost()
        {
            double baseFee = (BaseWeight * 10_000) + 70_000;
            return IsDistanceOver20Km ? baseFee + 50_000 : baseFee;
        }
    }

    public class Real
    {
        public double CalculateCost(ShippingCalculatorReal calculator)
        {
            if (calculator == null)
                throw new ArgumentNullException(nameof(calculator), "Bộ tính phí không được để trống.");

            return calculator.CalculateShippingCost();
        }
    }
}
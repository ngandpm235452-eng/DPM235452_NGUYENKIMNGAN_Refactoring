using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_29_ReplaceConditionalWithPolymorphism
{
    // Tái cấu trúc: Thay thế switch-case bằng lớp trừu tượng BirdAfter và các lớp con kế thừa triển khai đa hình
    public abstract class BirdAfter
    {
        public abstract double GetSpeed();
        protected double GetBaseSpeed() => 10.0;
    }

    public class EuropeanBirdAfter : BirdAfter
    {
        public override double GetSpeed() => GetBaseSpeed();
    }

    public class AfricanBirdAfter : BirdAfter
    {
        private readonly double _numberOfCoconuts;

        public AfricanBirdAfter(double numberOfCoconuts = 1.5)
        {
            _numberOfCoconuts = numberOfCoconuts;
        }

        public override double GetSpeed() => GetBaseSpeed() - GetLoadFactor() * _numberOfCoconuts;
        private double GetLoadFactor() => 1.5;
    }

    public class NorwegianBlueBirdAfter : BirdAfter
    {
        public double Voltage { get; }
        public bool IsNailed { get; }

        public NorwegianBlueBirdAfter(double voltage, bool isNailed)
        {
            Voltage = voltage;
            IsNailed = isNailed;
        }

        public override double GetSpeed() => IsNailed ? 0 : Voltage * 1.5;
    }

    public class After
    {
        public double CalculateEuropeanSpeed()
        {
            BirdAfter bird = new EuropeanBirdAfter();
            return bird.GetSpeed();
        }
    }
}
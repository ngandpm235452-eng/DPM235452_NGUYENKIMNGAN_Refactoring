using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_24_ReplaceSubclassWithFields
{
    // Code Smell: Lazy Class / Subclassing Overhead - Tạo các lớp con chỉ để trả về hằng số cố định
    public abstract class PersonBefore
    {
        public abstract bool IsMale { get; }
        public abstract char Code { get; }
    }

    public class MaleBefore : PersonBefore
    {
        public override bool IsMale => true;
        public override char Code => 'M';
    }

    public class FemaleBefore : PersonBefore
    {
        public override bool IsMale => false;
        public override char Code => 'F';
    }

    public class Before
    {
        public PersonBefore CreateMale() => new MaleBefore();
        public PersonBefore CreateFemale() => new FemaleBefore();
    }
}
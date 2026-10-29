using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_21_ReplaceTypeCodeWithClass
{
    public class PersonBefore
    {
        // Code Smell: Primitive Obsession - Dùng hằng số int thô để định nghĩa các loại nhóm máu
        public const int O = 0;
        public const int A = 1;
        public const int B = 2;
        public const int AB = 3;

        public int BloodGroup { get; set; }

        public PersonBefore(int bloodGroup)
        {
            BloodGroup = bloodGroup;
        }
    }

    public class Before
    {
        public PersonBefore CreatePerson()
        {
            return new PersonBefore(PersonBefore.A);
        }
    }
}
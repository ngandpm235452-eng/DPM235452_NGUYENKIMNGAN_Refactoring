using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_21_ReplaceTypeCodeWithClass
{
    // Tái cấu trúc: Thay thế mã loại số nguyên thành một class riêng với các instances tĩnh cố định
    public class BloodGroupAfter
    {
        public static readonly BloodGroupAfter O = new BloodGroupAfter(0);
        public static readonly BloodGroupAfter A = new BloodGroupAfter(1);
        public static readonly BloodGroupAfter B = new BloodGroupAfter(2);
        public static readonly BloodGroupAfter AB = new BloodGroupAfter(3);

        public int Code { get; }

        private BloodGroupAfter(int code)
        {
            Code = code;
        }
    }

    public class PersonAfter
    {
        public BloodGroupAfter BloodGroup { get; set; }

        public PersonAfter(BloodGroupAfter bloodGroup)
        {
            BloodGroup = bloodGroup;
        }
    }

    public class After
    {
        public PersonAfter CreatePerson()
        {
            return new PersonAfter(BloodGroupAfter.A);
        }
    }
}
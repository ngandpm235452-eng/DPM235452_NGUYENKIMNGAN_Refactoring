using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_21_ReplaceTypeCodeWithClass
{
    // Ứng dụng thực tế: Thiết kế Value Object mã loại hoàn chỉnh có mô tả, hỗ trợ tra cứu an toàn từ chuỗi (Parse)
    public class BloodGroupReal
    {
        public static readonly BloodGroupReal O = new BloodGroupReal("O", "Nhóm máu O");
        public static readonly BloodGroupReal A = new BloodGroupReal("A", "Nhóm máu A");
        public static readonly BloodGroupReal B = new BloodGroupReal("B", "Nhóm máu B");
        public static readonly BloodGroupReal AB = new BloodGroupReal("AB", "Nhóm máu AB");

        public string Code { get; }
        public string Description { get; }

        private BloodGroupReal(string code, string description)
        {
            Code = code;
            Description = description;
        }

        public static BloodGroupReal FromCode(string code)
        {
            return code?.Trim().ToUpper() switch
            {
                "O" => O,
                "A" => A,
                "B" => B,
                "AB" => AB,
                _ => throw new ArgumentException($"Mã nhóm máu '{code}' không hợp lệ.", nameof(code))
            };
        }
    }

    public class PersonReal
    {
        public string Name { get; }
        public BloodGroupReal BloodGroup { get; }

        public PersonReal(string name, BloodGroupReal bloodGroup)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên không được để trống.", nameof(name));

            Name = name.Trim();
            BloodGroup = bloodGroup ?? throw new ArgumentNullException(nameof(bloodGroup));
        }
    }

    public class Real
    {
        public PersonReal CreatePerson(string name, string bloodGroupCode)
        {
            var bloodGroup = BloodGroupReal.FromCode(bloodGroupCode);
            return new PersonReal(name, bloodGroup);
        }
    }
}
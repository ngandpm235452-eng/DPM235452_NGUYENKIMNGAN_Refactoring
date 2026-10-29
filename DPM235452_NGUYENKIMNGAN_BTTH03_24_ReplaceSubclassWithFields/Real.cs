using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_24_ReplaceSubclassWithFields
{
    public enum Gender
    {
        Male,
        Female,
        Other
    }

    // Ứng dụng thực tế: Sử dụng Enum, thuộc tính read-only và kiểm tra điều kiện dữ liệu trong Constructor
    public class PersonReal
    {
        public string Name { get; }
        public Gender Gender { get; }
        public char GenderCode { get; }

        public PersonReal(string name, Gender gender)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException("Tên không được để trống.", nameof(name));

            Name = name.Trim();
            Gender = gender;
            GenderCode = gender switch
            {
                Gender.Male => 'M',
                Gender.Female => 'F',
                _ => 'O'
            };
        }

        public bool IsMale => Gender == Gender.Male;
    }

    public class Real
    {
        public PersonReal CreatePerson(string name, Gender gender)
        {
            return new PersonReal(name, gender);
        }
    }
}
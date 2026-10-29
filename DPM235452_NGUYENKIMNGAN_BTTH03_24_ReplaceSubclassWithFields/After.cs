using System;

namespace DPM235452_NGUYENKIMNGAN_BTTH03_24_ReplaceSubclassWithFields
{
    // Tái cấu trúc: Bỏ các lớp con, đưa dữ liệu hằng số về thành các thuộc tính của lớp cha và khởi tạo qua Factory Method
    public class PersonAfter
    {
        public bool IsMale { get; }
        public char Code { get; }

        protected PersonAfter(bool isMale, char code)
        {
            IsMale = isMale;
            Code = code;
        }

        public static PersonAfter CreateMale() => new PersonAfter(true, 'M');
        public static PersonAfter CreateFemale() => new PersonAfter(false, 'F');
    }

    public class After
    {
        public PersonAfter CreateMale() => PersonAfter.CreateMale();
        public PersonAfter CreateFemale() => PersonAfter.CreateFemale();
    }
}
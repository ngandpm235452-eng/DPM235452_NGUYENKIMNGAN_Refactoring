# BÁO CÁO GIẢI PHÁP REFACTORING OO (SOLUTION)

**Họ và tên:** Nguyễn Kim Ngân  
**Mã sinh viên:** DPM235452  
**Tên môn học:** Thiết kế phần mềm / Refactoring OO  

---

## CHOICE 1: EXTRACT METHOD (TÁCH PHƯƠNG THỨC)
* **Nguồn tham khảo:** Refactoring.Guru (Kỹ thuật Extract Method)
* **Code Smell:** Long Method / Divergent Change  
  * Phương thức `PrintOwing` ở bản `Before` đảm nhận quá nhiều trách nhiệm: vừa thực hiện in tiêu đề (banner) vừa in chi tiết công nợ.
* **Giải pháp Refactoring:**
  * **Before:** Tồn tại 1 phương thức duy nhất chứa toàn bộ dòng lệnh in ấn.
  * **After:** Áp dụng kỹ thuật Extract Method để tách đoạn mã in tiêu đề thành `PrintBanner()` và đoạn mã in dữ liệu thành `PrintDetails()`.
  * **Final:** Tối ưu hóa nguyên lý đóng gói (Encapsulation), sử dụng Constructor để gán dữ liệu và kiểm tra hợp lệ trước khi xuất dữ liệu.

---

## CHOICE 2: REPLACE CONDITIONAL WITH POLYMORPHISM (ĐA HÌNH HÓA CÂU LỆNH ĐIỀU KIỆN)
* **Nguồn tham khảo:** Refactoring.Guru (Kỹ thuật Replace Conditional with Polymorphism)
* **Code Smell:** Switch Statements / Complex Conditional  
  * Việc tính lương dựa trên câu lệnh `switch-case` kiểm tra loại nhân viên (`EmployeeType`), vi phạm nguyên lý Open/Closed Principle (khi thêm loại nhân viên mới phải sửa đổi mã nguồn cũ).
* **Giải pháp Refactoring:**
  * **Before:** Dùng `switch(EmployeeType)` để phân nhánh tính tiền lương.
  * **After:** Tách các nhánh điều kiện thành các lớp con (`FullTimeEmployee`, `PartTimeEmployee`, `InternEmployee`) kế thừa từ lớp trừu tượng `EmployeeAfter` và ghi đè (override) phương thức `CalculateSalary()`.
  * **Final:** Sử dụng Interface `IEmployee` kết hợp lớp cơ sở `BaseEmployee` để đảm bảo tính đóng gói, linh hoạt và dễ mở rộng.---

## CHOICE 3: DECOMPOSE CONDITIONAL (TÁCH ĐIỀU KIỆN PHỨC TẠP)
* **Nguồn tham khảo:** Refactoring.Guru (Decompose Conditional)
* **Code Smell:** Complex Conditional / Decompose Conditional
  * Khối điều kiện `if (date.Month >= 6 && date.Month <= 8)` phức tạp và trực tiếp thực hiện tính toán bên trong khối lệnh làm mã nguồn khó đọc.
* **Giải pháp Refactoring:**
  * **Before:** Trực tiếp ghép nối logic tính toán và kiểm tra ngày tháng trong cùng 1 phương thức.
  * **After:** Tách biểu thức điều kiện thành phương thức `IsSummer()` và các nhánh xử lý thành `SummerCharge()`, `RegularCharge()`.
  * **Final/Real:** Thêm bước kiểm tra dữ liệu đầu vào (Validation) và đưa các tham số tính toán thành hằng số (`SUMMER_RATE`).---

## CHOICE 4: REPLACE MAGIC NUMBER WITH SYMBOLIC CONSTANT (THAY THẾ CON SỐ KỲ LẠ BẰNG HẰNG SỐ)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Magic Number with Symbolic Constant)
* **Code Smell:** Magic Numbers
  * Trong phương thức tính hóa đơn chứa các con số trực tiếp như `1000000`, `0.1`, `0.05` gây khó hiểu bản chất nghiệp vụ và khó bảo trì khi cần đổi mức thuế hay hạn mức.
* **Giải pháp Refactoring:**
  * **Before:** Nhúng trực tiếp số thô vào logic tính toán.
  * **After:** Đặt hằng số có tên rõ ràng như `DISCOUNT_THRESHOLD`, `DISCOUNT_RATE`, `TAX_RATE`.
  * **Final/Real:** Gom các hằng số vào lớp cấu hình `PricingConfig` và bổ sung kiểm tra dữ liệu đầu vào.---

## CHOICE 5: EXTRACT CLASS (TÁCH LỚP)
* **Nguồn tham khảo:** Refactoring.Guru (Extract Class)
* **Code Smell:** Large Class / Single Responsibility Principle Violation
  * Lớp `Person` ban đầu vừa quản lý thông tin tên nhân viên vừa quản lý mã vùng và số điện thoại, vi phạm nguyên lý đơn trách nhiệm (SRP).
* **Giải pháp Refactoring:**
  * **Before:** Nhúng toàn bộ thuộc tính và hàm xử lý số điện thoại trực tiếp trong lớp nhân viên.
  * **After:** Tách các thuộc tính `AreaCode`, `Number` và hàm `GetTelephoneNumber()` sang lớp riêng `TelephoneNumber`.
  * **Final/Real:** Thiết kế lớp `PhoneContact` dưới dạng Value Object không thể thay đổi (Immutable), kiểm tra định dạng dữ liệu đầu vào bằng Regular Expression.---

## CHOICE 6: REPLACE NESTED CONDITIONAL WITH GUARD CLAUSES (THAY THẾ ĐIỀU KIỆN LỒNG NHAU BẰNG GUARD CLAUSES)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Nested Conditional with Guard Clauses)
* **Code Smell:** Complex Conditional / Deep Nesting
  * Khối `if-else` lồng nhau nhiều tầng tạo thành mô hình dạng mũi tên (Arrow Anti-pattern), làm luồng thực thi chính bị ẩn sâu và rất khó đọc.
* **Giải pháp Refactoring:**
  * **Before:** Sử dụng cấu trúc `if-else` lồng nhau để gán biến `result`.
  * **After:** Đưa các trường hợp đặc biệt ra các dòng kiểm tra đầu tiên và `return` sớm (Guard Clauses) để làm phẳng code.
  * **Final/Real:** Chuyển đổi các cờ trạng thái boolean thành `Enum EmployeeStatus` giúp mã nguồn có tính đóng gói cao và kiểm tra dữ liệu đầu vào.---

## CHOICE 7: REPLACE TEMP WITH QUERY (THAY THẾ BIẾN TẠM BẰNG PHƯƠNG THỨC TRUY VẤN)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Temp with Query)
* **Code Smell:** Temporary Variables
  * Phương thức `CalculateTotal` sử dụng các biến tạm `basePrice` và `discountFactor` để lưu kết quả tính toán trung gian, làm phương thức dài hơn và không thể tái sử dụng logic tính toán này ở các hàm khác.
* **Giải pháp Refactoring:**
  * **Before:** Dùng biến tạm chứa giá trị tính toán cục bộ bên trong hàm.
  * **After:** Tách các biểu thức tính toán thành các phương thức private riêng biệt (`GetBasePrice()`, `GetDiscountFactor()`).
  * **Final/Real:** Sử dụng thuộc tính chỉ đọc (Read-only properties), kiểm tra tính hợp lệ của dữ liệu đầu vào trong Constructor.---

## CHOICE 8: REPLACE METHOD WITH METHOD OBJECT (THAY THẾ PHƯƠNG THỨC BẰNG ĐỐI TƯỢNG PHƯƠNG THỨC)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Method with Method Object)
* **Code Smell:** Long Method / Too Many Local Variables
  * Phương thức `Calculate` ban đầu chứa quá nhiều biến cục bộ liên đới làm tắc nghẽn việc tách hàm nhỏ bằng `Extract Method`.
* **Giải pháp Refactoring:**
  * **Before:** Dồn toàn bộ logic và các biến tạm cục bộ trong một phương thức duy nhất.
  * **After:** Chuyển phương thức thành lớp `OrderCalculatorAfter`, đưa các biến cục bộ thành thuộc tính lớp để dễ dàng tách thành các phương thức hỗ trợ nhỏ hơn (`ApplyDiscount`).
  * **Final/Real:** Thiết kế lớp dịch vụ `OrderCalculationService`, sử dụng biến `readonly`, kiểm tra dữ liệu đầu vào và quản lý hằng số `DELTA_ADJUSTMENT`.---

## CHOICE 9: SUBSTITUTE ALGORITHM (THAY THẾ THUẬT TOÁN)
* **Nguồn tham khảo:** Refactoring.Guru (Substitute Algorithm)
* **Code Smell:** Inefficient Algorithm / Complex Code
  * Thuật toán tìm kiếm sử dụng vòng lặp `for` kết hợp nhiều câu lệnh `if` kiểm tra từng giá trị chuỗi thủ công, khiến code dài dòng và khó mở rộng khi cần thêm tên mới.
* **Giải pháp Refactoring:**
  * **Before:** Duyệt mảng bằng vòng lặp `for` và kiểm tra `if-else` thủ công.
  * **After:** Thay thế thuật toán bằng việc khởi tạo danh sách `List<string>` và dùng hàm `Contains()` giúp mã nguồn ngắn gọn, rõ nghĩa hơn.
  * **Final/Real:** Tối ưu hóa hiệu năng bằng `HashSet` (độ phức tạp $O(1)$), kết hợp LINQ `FirstOrDefault()`, kiểm tra an toàn dữ liệu `null` và tìm kiếm không phân biệt chữ hoa/chữ thường (`OrdinalIgnoreCase`).---

## CHOICE 10: MOVE METHOD (DI CHUYỂN PHƯƠNG THỨC)
* **Nguồn tham khảo:** Refactoring.Guru (Move Method)
* **Code Smell:** Feature Envy
  * Phương thức `OverdraftCharge` đặt ở lớp `Account` nhưng lại phụ thuộc chính vào dữ liệu loại tài khoản (`IsPremium` thuộc `AccountType`).
* **Giải pháp Refactoring:**
  * **Before:** Đặt phương thức ở lớp gọi, dẫn đến việc lớp này truy cập liên tục vào thuộc tính của lớp khác.
  * **After:** Di chuyển `OverdraftCharge` sang lớp `AccountTypeAfter` và truyền tham số `daysOverdrawn` từ bên ngoài vào.
  * **Final/Real:** Sử dụng hằng số cho các mức phí thấu chi, đóng gói thuộc tính `readonly` và kiểm tra ngoại lệ số ngày thấu chi không hợp lệ.---

## CHOICE 11: MOVE FIELD (DI CHUYỂN THUỘC TÍNH)
* **Nguồn tham khảo:** Refactoring.Guru (Move Field)
* **Code Smell:** Feature Envy / Inappropriate Intimacy
  * Thuộc tính `InterestRate` nằm ở lớp `Account` nhưng bản chất dữ liệu lãi suất phụ thuộc hoàn toàn vào loại tài khoản (`AccountType`).
* **Giải pháp Refactoring:**
  * **Before:** Đặt thuộc tính `InterestRate` trực tiếp trong lớp `Account`.
  * **After:** Di chuyển thuộc tính `InterestRate` sang lớp `AccountTypeAfter` và truy cập gián tiếp thông qua đối tượng `Type`.
  * **Final/Real:** Thiết kế `AccountTypeReal` với thuộc tính chỉ đọc (`readonly`), bắt lỗi nếu số tiền nhỏ hơn 0 hoặc lãi suất không hợp lệ (ngoài phạm vi 0.0 - 1.0).---

## CHOICE 12: HIDE DELEGATE (CHE GIẤU ỦY THÁC)
* **Nguồn tham khảo:** Refactoring.Guru (Hide Delegate)
* **Code Smell:** Inappropriate Intimacy / Law of Demeter Violation
  * Mã nguồn phía Client phải gọi `person.Department.Manager` để lấy thông tin người quản lý, buộc Client phải biết rõ cấu trúc liên kết bên trong của `Person`.
* **Giải pháp Refactoring:**
  * **Before:** Để lộ đối tượng `Department` ra bên ngoài làm thuộc tính public.
  * **After:** Đưa `Department` về phương thức/thuộc tính private và bổ sung hàm `GetManager()` trực tiếp trong lớp `Person`.
  * **Final/Real:** Thiết kế giao tiếp 1-1 an toàn với thuộc tính read-only, bổ sung kiểm tra null và trả về thông tin phòng ban/quản lý hoàn chỉnh qua getter `DepartmentInfo`.---

## CHOICE 13: REMOVE MIDDLE MAN (THÁO BỎ NGƯỜI TRUNG GIAN)
* **Nguồn tham khảo:** Refactoring.Guru (Remove Middle Man)
* **Code Smell:** Middle Man / Excess Delegation
  * Lớp `Person` chứa quá nhiều phương thức chỉ dùng để gọi tiếp sang lớp `Department` mà không tự làm nhiệm vụ gì, gây dư thừa mã nguồn.
* **Giải pháp Refactoring:**
  * **Before:** Tạo phương thức ủy quyền trung gian `GetManager()` trong lớp `Person`.
  * **After:** Tháo bỏ phương thức trung gian, bộc lộ đối tượng `Department` cho phía Client chủ động gọi trực tiếp `person.Department.Manager`.
  * **Final/Real:** Thiết kế lớp với thuộc tính `readonly`, bổ sung kiểm tra hợp lệ dữ liệu và quản lý null an toàn.---

## CHOICE 14: INLINE CLASS (GỘP LỚP)
* **Nguồn tham khảo:** Refactoring.Guru (Inline Class)
* **Code Smell:** Lazy Class / Speculative Generality
  * Lớp `TelephoneNumber` không thực hiện các chức năng phức tạp, chỉ chứa hai thuộc tính đơn giản nhưng lại tạo thêm một Class riêng khiến hệ thống bị phình to không cần thiết.
* **Giải pháp Refactoring:**
  * **Before:** Duy trì lớp `TelephoneNumber` riêng biệt và gọi thông qua đối tượng `Phone`.
  * **After:** Di chuyển trực tiếp thuộc tính `AreaCode` và `Number` về lớp chính, xóa bỏ lớp `TelephoneNumber`.
  * **Final/Real:** Thiết kế lớp với các thuộc tính chỉ đọc (`readonly`), kiểm tra dữ liệu đầu vào trong Constructor.---

## CHOICE 15: ENCAPSULATE FIELD (ĐÓNG GÓI THUỘC TÍNH)
* **Nguồn tham khảo:** Refactoring.Guru (Encapsulate Field)
* **Code Smell:** Public Field / Violation of Encapsulation
  * Khai báo field dưới dạng `public string Name;` cho phép bên ngoài can thiệp, gán dữ liệu không hợp lệ mà không có cơ chế kiểm soát.
* **Giải pháp Refactoring:**
  * **Before:** Để biến trực tiếp dạng `public`.
  * **After:** Đưa biến về `private` và tạo hai hàm `GetName()`, `SetName()` để kiểm soát quyền truy cập.
  * **Final/Real:** Tận dụng Auto-Properties của C# với `private set`, bổ sung logic kiểm tra dữ liệu rỗng/khoảng trắng và tự động loại bỏ khoảng trắng dư thừa (`Trim()`).---

## CHOICE 16: ENCAPSULATE COLLECTION (ĐÓNG GÓI TẬP HỢP)
* **Nguồn tham khảo:** Refactoring.Guru (Encapsulate Collection)
* **Code Smell:** Direct Collection Exposure
  * Thuộc tính kiểu `List<T>` được mở public getter/setter, khiến đối tượng bên ngoài có thể tự do xóa, chỉnh sửa hoặc thay thế toàn bộ danh sách mà lớp chủ không kiểm soát được.
* **Giải pháp Refactoring:**
  * **Before:** Khai báo `public List<Course> Courses { get; set; }`.
  * **After:** Đưa danh sách về `private readonly List<Course>`, chỉ công khai `IReadOnlyList<Course>` và cung cấp hai phương thức `AddCourse()`, `RemoveCourse()`.
  * **Final/Real:** Sử dụng `IReadOnlyCollection`, tích hợp logic bắt lỗi `null`, chống nạp trùng lặp tên khóa học và hỗ trợ xóa theo tên.---

## CHOICE 17: REPLACE DATA VALUE WITH OBJECT (THAY THẾ GIÁ TRỊ DỮ LIỆU BẰNG ĐỐI TƯỢNG)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Data Value with Object)
* **Code Smell:** Primitive Obsession
  * Đối tượng đơn hàng ban đầu lưu trực tiếp thông tin khách hàng bằng kiểu chuỗi `string`, gây khó khăn khi cần mở rộng thông tin (SĐT, Email, Địa chỉ) hoặc thêm logic xử lý riêng cho khách hàng.
* **Giải pháp Refactoring:**
  * **Before:** Khai báo `public string Customer { get; set; }`.
  * **After:** Đóng gói thông tin vào lớp `CustomerAfter` và thay thuộc tính `string` bằng đối tượng `CustomerAfter`.
  * **Final/Real:** Thiết kế `CustomerReal` dưới dạng Value Object chỉ đọc (`readonly`), bổ sung kiểm tra định dạng email và tên rỗng trong Constructor.---

## CHOICE 18: CHANGE VALUE TO REFERENCE (THAY THẾ GIÁ TRỊ BẰNG THAM CHIẾU)
* **Nguồn tham khảo:** Refactoring.Guru (Change Value to Reference)
* **Code Smell:** Duplicate Value Objects / Memory Waste
  * Mỗi đơn hàng tự khởi tạo một đối tượng `Customer` mới độc lập. Khi thông tin khách hàng cập nhật ở một đơn hàng, các đơn hàng khác của cùng khách hàng đó không được cập nhật theo.
* **Giải pháp Refactoring:**
  * **Before:** Khởi tạo `new Customer()` trực tiếp bên trong lớp `Order`.
  * **After:** Tạo kho lưu trữ `CustomerRepository` dạng Static/Registry để quản lý các đối tượng `Customer`, đảm bảo các đơn hàng của cùng một khách hàng dùng chung một tham chiếu duy nhất.
  * **Final/Real:** Tối ưu hóa đa luồng với `ConcurrentDictionary`, quản lý khách hàng bằng Mã ID duy nhất và bắt lỗi dữ liệu đầu vào.---

## CHOICE 19: CHANGE REFERENCE TO VALUE (THAY THẾ THAM CHIẾU BẰNG GIÁ TRỊ)
* **Nguồn tham khảo:** Refactoring.Guru (Change Reference to Value)
* **Code Smell:** Mutable Reference Object / Side-effects
  * Một đối tượng nhỏ (như `Currency`, `Money`, `Location`) được quản lý dưới dạng tham chiếu có thể thay đổi trạng thái (Mutable). Khi nhiều đối tượng cùng tham chiếu tới nó, việc sửa đổi ở một nơi sẽ làm thay đổi dữ liệu ở tất cả những nơi khác mà không kiểm soát được.
* **Giải pháp Refactoring:**
  * **Before:** Đối tượng cho phép thay đổi dữ liệu bên trong thông qua các Setter public.
  * **After:** Biến đối tượng thành Value Object bất biến (Immutable), loại bỏ các Setter và ghi đè `Equals()`, `GetHashCode()` để so sánh bằng giá trị.
  * **Final/Real:** Tận dụng kiểu dữ liệu `record` hoặc `readonly struct` trong C# nâng cao, đảm bảo an toàn đa luồng (Thread-safety), không side-effect và validate dữ liệu chặt chẽ.---

## CHOICE 20: REPLACE ARRAY WITH OBJECT (THAY THẾ MẢNG BẰNG ĐỐI TƯỢNG)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Array with Object)
* **Code Smell:** Primitive Obsession / Array Abuse
  * Sử dụng mảng `string[]` để chứa các mẩu thông tin có bản chất và kiểu dữ liệu khác nhau (Tên đội, Số trận thắng). Người lập trình buộc phải nhớ chỉ số mảng (`row[0]`, `row[1]`), dễ dẫn đến nhầm lẫn và ép kiểu sai.
* **Giải pháp Refactoring:**
  * **Before:** Trả về dữ liệu dạng mảng `string[]` và truy cập bằng chỉ số cố định.
  * **After:** Tạo lớp `PerformanceAfter` có các thuộc tính `Name` và `Wins` để thay thế mảng.
  * **Final/Real:** Đóng gói thành lớp strongly-typed với thuộc tính chỉ đọc (`readonly`), gán chuẩn kiểu số `int` cho số trận thắng và kiểm tra tính hợp lệ dữ liệu trong Constructor.---

## CHOICE 21: REPLACE TYPE CODE WITH CLASS (THAY THẾ MÃ LOẠI BẰNG LỚP)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Type Code with Class)
* **Code Smell:** Primitive Obsession / Type Code
  * Sử dụng các số nguyên (`int`) nguyên thủy hoặc chuỗi thô để đại diện cho các mã loại (ví dụ: nhóm máu `O=0`, `A=1`, `B=2`, `AB=3`). Điều này dễ dẫn đến lỗi gán nhầm số không hợp lệ mà trình biên dịch không thể kiểm soát.
* **Giải pháp Refactoring:**
  * **Before:** Định nghĩa mã loại bằng các hằng số số nguyên thô.
  * **After:** Đóng gói mã loại thành lớp `BloodGroupAfter` với các instances tĩnh cố định, đảm bảo kiểm tra kiểu an toàn ngay ở mức biên dịch (Compile-time type safety).
  * **Final/Real:** Thiết kế lớp mã loại hoàn chỉnh với thuộc tính chỉ đọc (`readonly`), tích hợp mã đếm, tên hiển thị và kiểm tra ràng buộc dữ liệu nghiêm ngặt trong Constructor.---

## CHOICE 22: REPLACE TYPE CODE WITH SUBCLASSES (THAY THẾ MÃ LOẠI BẰNG LỚP CON)---

## CHOICE 23: REPLACE TYPE CODE WITH STATE/STRATEGY (THAY THẾ MÃ LOẠI BẰNG STATE/STRATEGY)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Type Code with State/Strategy)
* **Code Smell:** Primitive Obsession / Mutable Type Code / Switch Statements
  * Mã loại (Type Code) thay đổi linh hoạt theo thời gian thực (Runtime), dẫn đến việc phải sử dụng các câu lệnh `switch-case` phân nhánh phức tạp để xử lý hành vi theo từng trạng thái.
* **Giải pháp Refactoring:**
  * **Before:** Sử dụng hằng số số nguyên làm mã loại và thay đổi trực tiếp biến này khi trạng thái đối tượng thay đổi.
  * **After:** Tách mã loại thành cấu trúc State/Strategy với lớp trừu tượng `EmployeeType` và các lớp con cụ thể. Lớp chính ủy thác (delegate) xử lý hành vi cho đối tượng State hiện tại.
  * **Final/Real:** Đóng gói chuyển đổi trạng thái an toàn, kiểm tra hợp lệ dữ liệu đầu vào và tuân thủ nguyên lý Open/Closed (OCP).---

## CHOICE 24: REPLACE SUBCLASS WITH FIELDS (THAY THẾ LỚP CON BẰNG THUỘC TÍNH)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Subclass with Fields)
* **Code Smell:** Lazy Class / Subclassing Overhead
  * Khởi tạo các lớp con (`Male`, `Female`) kế thừa từ lớp cha chỉ để ghi đè và trả về các giá trị hằng số cố định (`Code`, `IsMale`), làm phình to sơ đồ lớp một cách không cần thiết.
* **Giải pháp Refactoring:**
  * **Before:** Sử dụng quan hệ kế thừa với các lớp con `MaleBefore`, `FemaleBefore`.
  * **After:** Xóa bỏ các lớp con, đưa dữ liệu thành thuộc tính (`IsMale`, `Code`) ở lớp cha và khởi tạo thông qua các Factory Method tĩnh (`CreateMale()`, `CreateFemale()`).
  * **Final/Real:** Kết hợp với `Enum Gender`, thuộc tính chỉ đọc (`readonly`) và kiểm tra tính hợp lệ dữ liệu đầu vào trong Constructor.---

## CHOICE 25: DECOMPOSE CONDITIONAL (PHÂN RÃ ĐIỀU KIỆN)
* **Nguồn tham khảo:** Refactoring.Guru (Decompose Conditional)
* **Code Smell:** Complex Conditional
  * Khối lệnh `if-else` chứa điều kiện so sánh ngày tháng rườm rà kèm công thức tính toán trực tiếp bên trong, gây khó đọc và giảm khả năng bảo trì.
* **Giải pháp Refactoring:**
  * **Before:** Đặt logic điều kiện so sánh và công thức tính toán trực tiếp trong hàm `CalculateCharge`.
  * **After:** Phân rã biểu thức điều kiện thành phương thức `NotSummer()` và tách 2 nhánh tính toán thành các hàm `SummerCharge()`, `WinterCharge()`.
  * **Final/Real:** Đóng gói thông số giá qua Constructor, bổ sung kiểm tra điều kiện dữ liệu đầu vào và tối ưu hóa logic bằng toán tử ba ngôi.
* **Nguồn tham khảo:** Refactoring.Guru (Replace Type Code with Subclasses)
* **Code Smell:** Primitive Obsession / Switch Statements
  * Sử dụng các mã loại hằng số (`int`) trực tiếp trong lớp để điều khiển hành vi. Khi cần thêm một loại đối tượng mới, người lập trình phải sửa đổi tất cả các câu lệnh `switch-case` hiện có, vi phạm nguyên tắc Open/Closed.
* **Giải pháp Refactoring:**
  * **Before:** Dùng hằng số mã loại kết hợp `switch-case` để phân nhánh logic xử lý.
  * **After:** Biến lớp chính thành lớp trừu tượng và tạo các lớp con kế thừa (`Engineer`, `Salesman`, `Manager`) để ghi đè (`override`) hành vi theo từng loại.
  * **Final/Real:** Đóng gói quá trình khởi tạo thông qua `EmployeeFactory` (Factory Pattern), tích hợp kiểm tra dữ liệu đầu vào và áp dụng tính đa hình hoàn chỉnh trong OOP.---

## CHOICE 26: CONSOLIDATE CONDITIONAL EXPRESSION (HỢP NHẤT BIỂU THỨC ĐIỀU KIỆN)
* **Nguồn tham khảo:** Refactoring.Guru (Consolidate Conditional Expression)
* **Code Smell:** Multiple Conditional Checks
  * Xuất hiện nhiều câu lệnh `if` đứng nối tiếp nhau nhưng đều dẫn đến cùng một kết quả xử lý/trả về, làm rối cấu trúc mã nguồn.
* **Giải pháp Refactoring:**
  * **Before:** Kiểm tra từng điều kiện `Seniority`, `MonthsDisabled`, `IsPartTime` trên nhiều dòng `if` độc lập.
  * **After:** Gộp các điều kiện bằng toán tử logic `||` và tách thành phương thức bổ trợ `IsNotEligibleForDisability()`.
  * **Final/Real:** Thiết kế lớp với thuộc tính chỉ đọc, kiểm tra ràng buộc số âm trong Constructor và sử dụng hàm khẳng định `IsEligibleForDisability()` với toán tử `&&`.
	* ---

## CHOICE 19: CHANGE REFERENCE TO VALUE (THAY THẾ THAM CHIẾU BẰNG GIÁ TRỊ)
* **Nguồn tham khảo:** Refactoring.Guru (Change Reference to Value)
* **Code Smell:** Mutable Reference Object / Side-effects
  * Đối tượng `Currency` được dùng làm Reference Object có thuộc tính có thể thay đổi (`Mutable`). Khi nhiều đối tượng dùng chung một tham chiếu, việc chỉnh sửa dữ liệu ở một vị trí sẽ gây hư hỏng dữ liệu ngoài ý muốn ở các vị trí còn lại (Side-effects).
* **Giải pháp Refactoring:**
  * **Before:** Khai báo `Currency` dạng class mutable với setter công khai.
  * **After:** Chuyển `Currency` thành Value Object bất biến (Immutable) chỉ có getter, đồng thời ghi đè `Equals()` và `GetHashCode()` để so sánh theo giá trị.
  * **Final/Real:** Đóng gói Value Object chuẩn hóa triển khai `IEquatable<T>`, nạp chồng toán tử `==` và `!=`, tự động chuyển mã tiền tệ về chữ hoa và kiểm tra độ dài đúng 3 ký tự (ISO 4217).---

## CHOICE 20: REPLACE ARRAY WITH OBJECT (THAY THẾ MẢNG BẰNG ĐỐI TƯỢNG)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Array with Object)
* **Code Smell:** Primitive Obsession / Array Abuse
  * Sử dụng mảng `string[]` để chứa các mẩu thông tin có bản chất và kiểu dữ liệu khác nhau (Tên đội, Số trận thắng). Người lập trình buộc phải nhớ chỉ số mảng (`row[0]`, `row[1]`), dễ dẫn đến nhầm lẫn và ép kiểu sai.
* **Giải pháp Refactoring:**
  * **Before:** Trả về dữ liệu dạng mảng `string[]` và truy cập bằng chỉ số cố định.
  * **After:** Tạo lớp `PerformanceAfter` có các thuộc tính `Name` và `Wins` để thay thế mảng.
  * **Final/Real:** Đóng gói thành lớp strongly-typed với thuộc tính chỉ đọc (`readonly`), gán chuẩn kiểu số `int` cho số trận thắng và kiểm tra tính hợp lệ dữ liệu trong Constructor.
	* ---

## CHOICE 21: REPLACE TYPE CODE WITH CLASS (THAY THẾ MÃ LOẠI BẰNG LỚP)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Type Code with Class)
* **Code Smell:** Primitive Obsession / Type Code
  * Sử dụng các số nguyên (`int`) nguyên thủy để đại diện cho các mã loại (nhóm máu `O=0`, `A=1`, `B=2`, `AB=3`). Điều này dễ dẫn đến lỗi gán nhầm số không hợp lệ mà trình biên dịch không thể kiểm soát.
* **Giải pháp Refactoring:**
  * **Before:** Định nghĩa mã loại bằng các hằng số số nguyên thô `const int`.
  * **After:** Đóng gói mã loại thành lớp `BloodGroupAfter` với các instances tĩnh cố định, đảm bảo kiểm tra kiểu an toàn ngay ở mức biên dịch (Compile-time type safety).
  * **Final/Real:** Thiết kế lớp mã loại hoàn chỉnh với thuộc tính chỉ đọc (`readonly`), bổ sung phương thức tra cứu từ chuỗi (`FromCode`) và bắt lỗi dữ liệu không hợp lệ.---

## CHOICE 22: REPLACE TYPE CODE WITH SUBCLASSES (THAY THẾ MÃ LOẠI BẰNG LỚP CON)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Type Code with Subclasses)
* **Code Smell:** Primitive Obsession / Switch Statements
  * Sử dụng các mã loại hằng số (`int`) trực tiếp trong lớp để điều khiển hành vi. Khi cần thêm một loại đối tượng mới, người lập trình phải sửa đổi tất cả các câu lệnh `switch-case` hiện có, vi phạm nguyên tắc Open/Closed (OCP).
* **Giải pháp Refactoring:**
  * **Before:** Dùng hằng số mã loại kết hợp `switch-case` để phân nhánh logic xử lý.
  * **After:** Biến lớp chính thành lớp trừu tượng `EmployeeAfter` và tạo các lớp con kế thừa (`EngineerAfter`, `SalesmanAfter`, `ManagerAfter`) để ghi đè (`override`) hành vi theo từng loại.
  * **Final/Real:** Đóng gói quá trình khởi tạo thông qua `EmployeeFactoryReal` kết hợp `Enum EmployeeTypeReal`, thuộc tính chỉ đọc (`readonly`), bắt lỗi dữ liệu đầu vào và áp dụng tính đa hình hoàn chỉnh trong OOP.
	* ---

## CHOICE 23: REPLACE TYPE CODE WITH STATE/STRATEGY (THAY THẾ MÃ LOẠI BẰNG STATE/STRATEGY)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Type Code with State/Strategy)
* **Code Smell:** Primitive Obsession / Mutable Type Code / Switch Statements
  * Mã loại (Type Code) thay đổi linh hoạt theo thời gian thực (Runtime), dẫn đến việc phải sử dụng các câu lệnh `switch-case` phân nhánh phức tạp để xử lý hành vi theo từng trạng thái.
* **Giải pháp Refactoring:**
  * **Before:** Sử dụng hằng số số nguyên làm mã loại và thay đổi trực tiếp biến này khi trạng thái đối tượng thay đổi.
  * **After:** Tách mã loại thành cấu trúc State/Strategy với lớp trừu tượng `EmployeeTypeAfter` và các lớp con cụ thể. Lớp chính ủy thác (delegate) xử lý hành vi cho đối tượng State hiện tại.
  * **Final/Real:** Đóng gói chuyển đổi chiến lược an toàn qua `RoleStrategyReal`, sử dụng thuộc tính chỉ đọc kết hợp Validation chặt chẽ trong Constructor/Setter.
	* ---

## CHOICE 25: DECOMPOSE CONDITIONAL (PHÂN RÃ ĐIỀU KIỆN)
* **Nguồn tham khảo:** Refactoring.Guru (Decompose Conditional)
* **Code Smell:** Complex Conditional
  * Khối lệnh `if-else` chứa điều kiện so sánh ngày tháng rườm rà kèm công thức tính toán trực tiếp bên trong, gây khó đọc và giảm khả năng bảo trì.
* **Giải pháp Refactoring:**
  * **Before:** Đặt logic điều kiện so sánh và công thức tính toán trực tiếp trong hàm `CalculateCharge`.
  * **After:** Phân rã biểu thức điều kiện thành phương thức `NotSummer()` và tách 2 nhánh tính toán thành các hàm `SummerCharge()`, `WinterCharge()`.
  * **Final/Real:** Đóng gói thông số giá qua Constructor, bổ sung kiểm tra điều kiện dữ liệu đầu vào và tối ưu hóa logic bằng toán tử ba ngôi.
	* ---

## CHOICE 27: CONSOLIDATE DUPLICATE CONDITIONAL FRAGMENTS (HỢP NHẤT CÁC ĐOẠN ĐIỀU KIỆN LẶP LẠI)
* **Nguồn tham khảo:** Refactoring.Guru (Consolidate Duplicate Conditional Fragments)
* **Code Smell:** Duplicate Conditional Fragments
  * Một đoạn mã giống hệt nhau (ví dụ: lời gọi hàm `SendInvoice()`) được thực thi ở cả hai nhánh `if` và `else`, gây dư thừa và rủi ro quên cập nhật ở một trong hai nhánh khi bảo trì.
* **Giải pháp Refactoring:**
  * **Before:** Đặt lời gọi hàm `SendInvoice(total)` lặp lại bên trong cả 2 nhánh `if` và `else`.
  * **After:** Đưa lời gọi hàm `SendInvoice(total)` ra ngoài sau khi kết thúc cấu trúc lệnh `if-else`.
  * **Final/Real:** Đóng gói thông số chiết khấu qua Constructor, sử dụng toán tử ba ngôi để tính toán giá trị chiết khấu và tích hợp kiểm tra dữ liệu giá số dư âm.
	* ---

## CHOICE 28: REPLACE NESTED CONDITIONAL WITH GUARD CLAUSES (THAY THẾ ĐIỀU KIỆN LỒNG NHAU BẰNG GUARD CLAUSES)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Nested Conditional with Guard Clauses)
* **Code Smell:** Complex / Nested Conditionals (Arrow Anti-pattern)
  * Sử dụng các khối `if-else` lồng nhau nhiều tầng để xử lý các trường hợp đặc biệt trước khi thực thi nhánh chính, gây khó đọc và tạo ra cấu trúc hình mũi tên (Arrow Anti-pattern).
* **Giải pháp Refactoring:**
  * **Before:** Đặt logic tính toán trong các tầng `if-else` lồng nhau rườm rà.
  * **After:** Áp dụng Guard Clauses (thoát sớm bằng `return`) cho từng trường hợp đặc biệt ở đầu phương thức, trả luồng chính về cuối hàm phẳng và sạch sẽ.
  * **Final/Real:** Tích hợp với `Enum EmployeeStatus`, kiểm tra dữ liệu đầu vào và tách biệt phương thức trợ cấp riêng cho từng trạng thái nhân sự.
	* ---

## CHOICE 29: REPLACE CONDITIONAL WITH POLYMORPHISM (THAY THẾ ĐIỀU KIỆN BẰNG ĐA HÌNH)
* **Nguồn tham khảo:** Refactoring.Guru (Replace Conditional with Polymorphism)
* **Code Smell:** Switch Statements / Complex Conditionals
  * Hàm chứa các câu lệnh `switch` hoặc `if-else` phức tạp để thực thi các hành vi khác nhau dựa trên loại/trạng thái đối tượng, vi phạm nguyên tắc Single Responsibility (SRP) và Open/Closed (OCP).
* **Giải pháp Refactoring:**
  * **Before:** Dùng cấu trúc `switch-case` phân nhánh tính toán tốc độ chim dựa vào hằng số loại.
  * **After:** Chuyển từng nhánh `switch` vào phương thức ghi đè (`override`) của các lớp con (`EuropeanBirdAfter`, `AfricanBirdAfter`, `NorwegianBlueBirdAfter`) kế thừa từ `BirdAfter`.
  * **Final/Real:** Thiết kế bài toán tính phí vận chuyển hàng hóa đa hình (`StandardShippingReal`, `ExpressShippingReal`, `SameDayShippingReal`), đóng gói thuộc tính chỉ đọc và kiểm tra tính hợp lệ trọng lượng.
	* ---

## CHOICE 30: INTRODUCE NULL OBJECT (GIỚI THIỆU ĐỐI TƯỢNG NULL)
* **Nguồn tham khảo:** Refactoring.Guru (Introduce Null Object)
* **Code Smell:** Null Checks / Repeated Null Checks
  * Thực hiện kiểm tra `null` lặp đi lặp lại ở nhiều nơi trước khi gọi phương thức hoặc truy xuất thuộc tính của đối tượng, làm mã nguồn cồng kềnh và dễ dẫn đến lỗi `NullReferenceException`.
* **Giải pháp Refactoring:**
  * **Before:** Dùng `if (customer == null)` ở mọi nơi để xử lý trường hợp không có dữ liệu khách hàng.
  * **After:** Tạo lớp `NullCustomerAfter` kế thừa từ `CustomerAfter` để trả về các giá trị mặc định an toàn thay vì `null`.
  * **Final/Real:** Triển khai `ICustomerReal` kết hợp thiết kế `NullCustomerReal` dạng Singleton (`Instance`), kiểm tra tham số đầu vào và định nghĩa giá trị chiết khấu mặc định chuẩn OOP.
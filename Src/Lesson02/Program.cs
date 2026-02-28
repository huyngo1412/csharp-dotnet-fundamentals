using System.Text;

namespace Lesson02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /*
             * 1) Kiểu dữ liệu số nguyên (Integral types)
             *
             * - Có 8 kiểu số nguyên trong C#:
             *   Có dấu   : sbyte, short, int, long
             *   Không dấu: byte, ushort, uint, ulong
             *
             * - Kích thước phổ biến: 8-bit, 16-bit, 32-bit, 64-bit (cả có dấu và không dấu).
             *
             * - Phạm vi:
             *   + byte  (8-bit, không dấu)  : 0 .. 255
             *   + sbyte (8-bit, có dấu)     : -128 .. 127
             *   + short (16-bit, có dấu)    : -32768 .. 32767
             *   + ushort(16-bit, không dấu): 0 .. 65535
             *   + int   (32-bit, có dấu)    : -2,147,483,648 .. 2,147,483,647
             *   + uint  (32-bit, không dấu): 0 .. 4,294,967,295
             *   + long  (64-bit, có dấu)
             *   + ulong (64-bit, không dấu)
             *
             * - Mẹo: literal cho kiểu không dấu thường thêm hậu tố:
             *   u/ U (uint), ul/ UL (ulong)
             */

            // Có dấu
            sbyte sb = -127;
            short sh = 32767;
            int i = -2147483647;
            long l = 23L;

            // Không dấu
            byte b = 255;
            ushort us = 65535;
            uint ui = 4294967295u;  // cần hậu tố u
            ulong ul = 23UL;        // cần hậu tố UL (hoặc uL)

            Console.WriteLine("------------- Kiểu dữ liệu số nguyên -------------");
            Console.WriteLine($"sbyte : {sb}");
            Console.WriteLine($"short : {sh}");
            Console.WriteLine($"int   : {i}");
            Console.WriteLine($"long  : {l}");
            Console.WriteLine($"byte  : {b}");
            Console.WriteLine($"ushort: {us}");
            Console.WriteLine($"uint  : {ui}");
            Console.WriteLine($"ulong : {ul}");
            Console.WriteLine();

            /*
             * 2) Kiểu dữ liệu số thực (Floating-point / Decimal)
             *
             * - float   (32-bit): hậu tố f/F
             * - double  (64-bit): mặc định cho số thực (vd: 3.2 là double)
             * - decimal (128-bit): hậu tố m/M (hay dùng cho tiền tệ vì chính xác theo hệ 10 tốt hơn)
             *
             * Lưu ý:
             * - float/double là dạng nhị phân nên có thể sai số (vd 0.1 + 0.2).
             * - decimal thường “chính xác” hơn cho tiền tệ nhưng chậm hơn.
             */

            double d = 3.2;      // mặc định là double
            float f = 3.4f;      // cần hậu tố f
            decimal dec = 5.2m;  // cần hậu tố m

            Console.WriteLine("------------- Kiểu dữ liệu số thực -------------");
            Console.WriteLine($"Kiểu mặc định của 3.2 là: {(3.2).GetType()}");
            Console.WriteLine($"double : {d}");
            Console.WriteLine($"float  : {f}");
            Console.WriteLine($"decimal: {dec}");

            // Minh họa sai số của double
            Console.WriteLine($"double 0.1 + 0.2 = {0.1 + 0.2}");     // thường ra 0.30000000000000004

            // Minh họa decimal (phải dùng literal decimal ngay từ đầu)
            Console.WriteLine($"decimal 0.1m + 0.2m = {0.1m + 0.2m}"); // ra 0.3

            Console.WriteLine();

            /*
             * 3) Kiểu dữ liệu ký tự: char
             * - char trong C# là ký tự Unicode 16-bit
             */
            char c = 'a';
            Console.WriteLine("------------- Kiểu dữ liệu Char -------------");
            Console.WriteLine($"char: {c}");
            Console.WriteLine();

            /*
             * 4) Kiểu dữ liệu Boolean: bool
             * - chỉ nhận true hoặc false
             * - kết quả của phép so sánh là bool
             */
            bool bo = true;

            Console.WriteLine("------------- Kiểu dữ liệu Boolean -------------");
            Console.WriteLine($"bo: {bo}");
            Console.WriteLine($"5 > 2 ? {5 > 2}");
            Console.WriteLine();

            /*
             * 5) Kiểu dữ liệu chuỗi: string
             *
             * - string là Reference Type nhưng là kiểu BẤT BIẾN (Immutable):
             *   + Không thể sửa nội dung chuỗi đã tạo.
             *   + Mọi “thay đổi” thực chất là tạo chuỗi mới và trỏ biến sang chuỗi mới.
             *
             * - String Intern Pool:
             *   + String literal (vd "abc") thường được intern (dùng chung 1 instance trong pool).
             *   + new string(...) tạo một object string mới (thường nằm trên heap thông thường), không tự động intern.
             *
             * - So sánh chuỗi:
             *   + Trong C#: toán tử == của string được overload để so sánh NỘI DUNG.
             *   + So sánh tham chiếu (reference) dùng object.ReferenceEquals(a, b).
             */

            //Cả hai đều là object trên managed heap
            string str1 = "abc"; // literal -> thường nằm trong intern pool
            string str2 = new string(new[] { 'a', 'b', 'c' }); // tạo object mới (không tự động intern)

            Console.WriteLine("------------- Kiểu dữ liệu String -------------");
            Console.WriteLine($"str1: {str1}");
            Console.WriteLine($"str2: {str2}");

            // Immutable demo
            string str3 = str1 + "d"; // tạo chuỗi mới "abcd"
            Console.WriteLine($"str3 = str1 + \"d\" => {str3}");
            Console.WriteLine($"str1 vẫn là => {str1}");

            // So sánh nội dung vs tham chiếu
            Console.WriteLine($"str1 == str2 (so nội dung): {str1 == str2}"); // true
            Console.WriteLine($"ReferenceEquals(str1, str2) (so reference): {object.ReferenceEquals(str1, str2)}"); // thường false

            Console.WriteLine();

            
            /*
             * 6) Kiểu dữ liệu object
             *
             * - object là kiểu cơ sở của tất cả kiểu trong C# (cả value type và reference type).
             * - Boxing: chuyển value type -> object (đóng gói)
             * - Unboxing: chuyển object -> value type (mở đóng gói)
             * - Boxing/Unboxing tốn chi phí (tạo object, copy dữ liệu, ép kiểu).
             */

            object o = 10;        // boxing tự động (int -> object)
            int value = 20;
            object boxed = value; // boxing
            int unboxed = (int)boxed; // unboxing (cần cast)

            Console.WriteLine("------------- Kiểu dữ liệu Object -------------");
            Console.WriteLine($"o: {o}");
            Console.WriteLine($"o.GetType(): {o.GetType()}");
            Console.WriteLine($"Boxing (boxed): {boxed}");
            Console.WriteLine($"Unboxing (unboxed): {unboxed}");

            /*
             * 7) Từ khóa var trong C#
             * 
             * - Var là từ khóa hổ trợ khai báo biến mà không cần kiểu dữ liệu. Kiểu dữ liệu sẽ được xác định ngay sau khi gán giá trị cho biến
             * Lúc đó chương trình sẽ ép kiểu cho biến
             * - Việc khai báo biến bằng từ khóa var bắc buộc phải khởi tạo giá trị ngay tại thời điểm khai báo và giá trị khai báo không thể là null.
             * - Ví dụ:
             *      var a;//Lỗi không khởi tạo giá trị cho biến
             *      var a = null;//Lỗi không thể khởi tạo giá trị null cho biến
             * - var chỉ là từ khóa hổ trợ khi khai báo, var không phải kiểu dữ liệu.
             * - Thông thường từ khóa var được sử dụng trong vòng lặp foreach và LinQ
             */

            Console.WriteLine("------------- Từ khóa var -------------");
            var v = 20;
            Console.WriteLine($"Var: {v}");
        }
    }
}

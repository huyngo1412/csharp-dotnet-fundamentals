using System.Text;

namespace Lesson03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            /*
             * 1) Toán tử số học (Arithmetic Operators)
             *  (Arithmetic operators)
             *   Cộng (+_), 
             *   Trừ (-), 
             *   Nhân (*), 
             *   Chia (/), 
             *   Chia lấy phần dư (%)
             */
            int a = 8, b = 4;
            Console.WriteLine("------------- Toán tử số học -------------");
            Console.WriteLine($"Phép cộng: {a} + {b} = {a + b}");
            Console.WriteLine($"Phép trừ: {a} - {b} = {a - b}");
            Console.WriteLine($"Phép nhân: {a} * {b} = {a * b}");
            Console.WriteLine($"Phép chia: {a} / {b} = {a / b}");
            Console.WriteLine($"Phép chia: {a} % {b} = {a % b}");

            /*
             * 2) Toán tử gán (Assignment Operators)
             *  (Assignment operators)
             *   Cộng gán (+=): Lấy giá trị hiện tại + giá trị mới -> rồi gán lại cho biến 
             *      Ví dụ: a +=b tương đương a = a + b
             *   Trừ gán (-=): Lấy giá trị hiện tại - giá trị mới -> rồi gán lại cho biến 
             *      Ví dụ: a -=b tương đương a = a - b
             *   Nhân gán (*=) : Lấy giá trị hiện tại * giá trị mới -> rồi gán lại cho biến
             *      Ví dụ: a *=b tương đương a = a * b
             *   Chia gán (/=): Lấy giá trị hiện tại / giá trị mới -> rồi gán lại cho biến
             *      Ví dụ: a /=b tương đương a = a / b
             *   Chia lấy phần dư gán (%=) : Lấy giá trị hiện tại % giá trị mới -> rồi gán lại cho biến
             *      Ví dụ: a %=b tương đương a = a % b
             */
            int c = 10, d = 20, e = 30, f = 40, g = 50;
            Console.WriteLine("\n------------- Toán tử gán -------------");
            Console.WriteLine($"Toán tử cộng gán c+= : {c += 5}");
            Console.WriteLine($"Toán tử trừ gán c-= : {d -= 3}");
            Console.WriteLine($"Toán tử nhân gán c*= : {e *= 2}");
            Console.WriteLine($"Toán tử chia gán c/= : {f /= 4}");
            Console.WriteLine($"Toán tử chia lấy phần dư gán c%= : {g %= 3}");

            /*
             * 3) Toán tử tăng giảm giá trị (Increment and Decrement Operators)
             * ++: Tăng 1 giá trị
             *  Ví dụ: ++a: tăng a lên 1 đơn vị, tương đương a = a + 1 (hoặc a += 1), nhưng trả về giá trị sau khi tăng (gọi là tiền tố)
             *         a++: tăng a lên 1 đơn vị, nhưng trả về giá trị trước khi tăng (gọi là hậu tố)
             * --: Giảm 1 giá trị
             *  Ví dụ: --a: giảm a xuống 1 đơn vị, tương đương a = a - 1 (hoặc a -= 1), nhưng trả về giá trị sau khi giảm (gọi là tiền tố)
             *         a--: giảm a xuống 1 đơn vị, nhưng trả về giá trị trước khi giảm (gọi là hậu tố)
             */

            int h = 5;
            Console.WriteLine("\n------------- Toán tử tăng giảm giá trị -------------");
            //pre - increment
            Console.WriteLine($"++h return: {++h}");
            //post - increment
            Console.WriteLine($"h++ return: {h++}");
            Console.WriteLine($"Giá trị cuối cùng của h: {h}");
            int i = 1;
            //pre - decrement
            Console.WriteLine($"--i return: {--i}");
            //post - decrement
            Console.WriteLine($"i-- return: {i--}");
            Console.WriteLine($"Giá trị cuối cùng của i: {i}");

            /*
             * 4) Toán tử so sánh (Comparison Operators)
             * ==: So sánh bằng
             * !=: So sánh khác
             * > : Lớn hơn
             * < : Nhỏ hơn
             * >=: Lớn hơn hoặc bằng
             * <=: Nhỏ hơn hoặc bằng
             */
             int j = 10, k = 20;
            Console.WriteLine("\n------------- Toán tử so sánh -------------");
            Console.WriteLine($"j: {j}, k: {k}");
            Console.WriteLine($"j == k: {j == k}");
            Console.WriteLine($"J != k: {j != k}");
            Console.WriteLine($"j > k: {j > k}");
            Console.WriteLine($"j < k: {j < k}");
            Console.WriteLine($"j >= k: {j >= k}");
            Console.WriteLine($"j <= k: {j <= k}");

            /*
             * 5) Toán tử logic (Logical Operators)
             * &&: AND logic - Trả về giá trị true nếu cả hai biểu thức đều đúng, ngược lại trả về false
             * ||: OR logic - Trả về giá trị true nếu ít nhất một trong hai biểu thức đúng, chỉ trả về false khi cả hai biểu thức đều sai
             * ! : NOT logic - Đảo ngược giá trị của biểu thức, nếu biểu thức đúng sẽ trả về false, nếu biểu thức sai sẽ trả về true (Chỉ dùng cho kiểu dữ liệu boolean)
             */
             bool yes = true, no = false;
            Console.WriteLine("\n------------- Toán tử logic -------------");
            Console.WriteLine("yes: true, no: false");
            Console.WriteLine(yes && yes);
            Console.WriteLine(yes && no);
            Console.WriteLine(yes || no);
            Console.WriteLine(no || no);

            
        }
    }
}

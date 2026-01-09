using System.Text;

namespace Lesson02
{

    class Program
    {
        static void Main(string[] args)//function
        {

            Console.OutputEncoding = Encoding.UTF8;
            /*  
             *  1. Kiểu dữ liệu số nguyên
             *  - Kiểu dữ liệu số nguyên âm và nguyên dương: sbyte, short, int, long 
             *  - Kiểu dữ liệu chỉ có thể chứa giá trị là số nguyên dương: byte, ushort, uint, ulong
             *  - Mẹo: Đối với kiểu dữ liệu số nguyên dương chỉ cần thêm kí tự 'u' phía trước tên của kiểu dữ liệu số nguyên
             *  - Có tất cả 8 kiểu dữ liệu số nguyên: sbyte, short, int, long, byte, ushort, uint, ulong
             * hổ trợ các giá trị có kích thước 8bits, 16bits, 32bit và 64bit ở cả hai dạng có dấu và không có dấu
             *  - Phạm vi dữ liệu sẽ bằng 2^n với n là số bit
             *  - Ví dụ kiểu dữ liệu byte có 8bit tương ứng có thể lưu giá trị từ 0-255 tương ứng với 2^8 = 256 giá trị
             *  - sbyte = 200; có thể lưu giá trị
             *  - sbyte = 300; không thể lưu giá trị vì sbyte chỉ có thể lưu giá trị từ 0 - 255
             */

            // Kiểu dữ liệu có thể chứa số nguyên âm, 0 và số nguyên dương
            sbyte sb = -127;

            short s = 32767;

            int i = -2147483647;

            long l = 23L;

            //Kiểu dữ liệu số nguyên dương 
            byte b = 255;

            ushort us = 65535;

            uint ui = 4294967295;

            ulong ul = 23L;

            Console.WriteLine("----------------Kiểu dữ liệu số nguyên--------------");
            Console.WriteLine("Sbyte: " + sb);
            Console.WriteLine("Short: " + s);
            Console.WriteLine("Interger: " + i);
            Console.WriteLine("Long: " + l);
            Console.WriteLine("Byte: " + b);
            Console.WriteLine("Unsigned short: " + us);
            Console.WriteLine("Usigned int: " + ui);
            Console.WriteLine("Unsigned long: " + ul);

            /*
             *   2.Kiểu dữ liệu số thực:
             *   - Float (32bit), double(64bit), decimal(128bit)
             *   - Kiểu dữ liệu mặc định trong c# là double khi giá trị là số thực với float 
             *   khi khai báo dữ liệu là float cần thêm hậu tố 'f' sau giá trị khai báo và kí tự 'm' đối với kiểu dữ liệu decimal
             *   - Ví dụ: float a = 3.2f;
             *   - Ví dụ: decimal m = 3.1m;
             */
            double d = 3.2;

            float f = 3.4f;

            decimal dec = 5.2m;

            Console.WriteLine("----------------Kiểu dữ liệu số thực--------------");
            Console.WriteLine("Kiểu dữ liệu mặc định của số thực: " + (3.2).GetType());
            Console.WriteLine("Double: " + d);
            Console.WriteLine("Float: " + f);
            Console.WriteLine("Decimal: " + dec);
            //Với kiểu dữ liệu số thực sẽ không chính xác tuyệt đối;
            //Vi Dụ:
            Console.WriteLine((double)(0.1 + 0.2));//Kết quả 0.30000000000000004
            //Với kiểu dữ liệu Decimal sẽ lưu chính xác số thực hơn nhưng sẽ làm ứng dụng chậm hơn
            //Kiểu dữ liệu decimal chỉ phù hợp cho các ứng dụng liên quan đến tiền tệ cần sự chính xác cao
            Console.WriteLine("Decimal: " + (decimal)(0.1 + 0.2));


            /*
             * 3. Kiểu dữ liệu dùng để lưu ký tự: char
             */
            char c = 'a';
            Console.WriteLine("Char: " + c);

            /*
             * 4. Kiểu dữ liệu Boolean:
             *  - Kiểu dữ liệu boolean chỉ nhận giá trị true(đúng) hoặc false (sai)
             */

            bool bo = true;

            Console.WriteLine("------------ Kiểu dữ liệu Boolean ------------");
            Console.WriteLine("Giá trị của biến bo: " + bo);

            // Kết quả của phép so sánh là một giá trị Boolean
            Console.WriteLine(5 > 2);

        }
    }
}

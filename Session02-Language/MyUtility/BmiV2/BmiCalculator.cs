namespace BmiV2
{
    /// <summary>
    /// Class này chứa các hàm tính toán chỉ số BMI, là chỉ số dựa trên chiều cao và cân nặng giúp đánh giá 1 ai đó có mập ốm hay không
    /// </summary>
    public class BmiCalculator
    {
        //khai báo biến và hàm => gọi chung là member của 1 class
        //biến: gọi là: field, property, attribute, instance variable (non-static), class-variable (static)
        //Math.sqrt() Math.Sqrt()

        //tên hàm trong Java: verb + object, chữ hoa từng đầu từ, từ đầu tiên chữ thường, gọi là cú pháp con lạc đà
        //camel Case Notation, ví dụ: sqrt(), toString, getGPA()
        //Tên hàm trong C#: verb + object, chữ hoa từng đầu từ kể cả từ đầu tiên, gọi là cú pháp Pascal
        //Pascal Case Notation, ví dụ: Sqrt(), ToString, GetGpa

        /// <summary>
        /// Hàm này tính chỉ số BMI của 1 cá nhân bất kỳ và trả về con số đó. Phép tính BMI dựa trên chiều cao và cân nặng
        /// </summary>
        /// <param name="weigth">Cân nặng đo bằng kg</param>
        /// <param name="height">Chiều cao đo bằng m</param>
        /// <returns></returns>
        public static double GetBmi(double weigth, double height) => weigth / (height * height);
        //nếu hàm chỉ có 1 câu lệnh duy nhất; cho phép ăn bớt, rút gọn code
        //bỏ luôn { bỏ luôn return bỏ luôn }
        //kỹ thuật viết thân hàm {...} theo style rút gọn được gọi là expression body - thân hàm như 1 biểu thức
        //cấm không được nhầm lẫn với biểu thức LAMBDA cũng xài chung =>
        //học sau

        //static double GetBmi(double weigth, double height) 
        //    =>
        //        weigth / (height * height);

        //static double GetBmi(double weigth, double height) =>
        //weigth / (height * height);

        //static double GetBmi(double weigth, double height)
        //{
        //    //quy tắc đặt tên biến - biến local
        //    //cú pháp con lạc đà, noun
        //    return weigth / (height * height);
        //}

        //viết thử nghiệm thêm 1 cái hàm khác, hàm void, style expression body
        static void PrintBmiString() => Console.WriteLine("BMI stands for Dody Mass Index - chỉ số khối của cơ thể - Con số được tính dựa trên chiều cao và cân nặng");
        

        //static void PrintBmiString()
        //{
        //    Console.WriteLine("BMI stands for Dody Mass Index - chỉ số khối của cơ thể - Con số được tính dựa trên chiều cao và cân nặng");
        //}

    }
}

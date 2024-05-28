using StudentManagerV4.Entities;

namespace StudentManagerV4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new("SE1", "An");

            //nếu class không có constructor thì java và c# sẽ tự sinh ra cho mình 1 constructor rỗng - constructor default để giúp ta clone 1 vùng ram chứa object toàn là thông tin default giống như xin 1 cái form để điềm sau
            //nếu đã có 1 constructor có tham số hoặc nhiều constructor thì java và c# không sinh ra nữa
            //lý do: cần constructor để đúc object mà có rồi thì không cần sinh ra nữa

            //NHƯNG...
            //EM THÍCH LÀM CONSTRUCTOR 1 CÁCH CHỦ ĐỘNG 
            //EXPLICIT - TƯỜNG MINH, RÕ RÀNG
        }
    }
}

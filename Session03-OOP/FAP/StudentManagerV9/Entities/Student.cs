using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV9.Entities
{
    internal class Student
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Yob { get; set; }
        public double Gpa { get; set; }

        //RUNTIME TỰ SINH RA GIÚP TA _id, _name, _yob, _gpa LÚC CHẠY APP
        //GIÚP VIẾT CODE TIỆN HƠN, TRÁNH NHỮNG CODE NHÀM CHÁN

        //lỡ quên cú pháp: prop tab tab

        //java ko có trò này, muốn có phải cài dependency bên ngoài - lombok
    }
}


//CHỐT HẠ: CÁC THIẾT KẾ 1 CLASS LƯU TRỮ INFO THEO OBJECT
//CÁCH 1: KHAI BÁO CÁC BACKING FIELD NHƯ BÊN JAVA (_)
//      SAU ĐÓ LÀM CÁC HÀM GET() SET() NHƯ JAVA

//CÁCH 2: KHAI BÁO CÁC BACKING FIELD NHƯ JAVA
//      SAU ĐÓ LÀM CÁC HÀM GET() SET() THEO STYLE VIẾT GỘP
//      VÀ XỬ LÝ TRÊN BACKING FIELD, DÙNG THÊM EXPRESSION BODY NẾU CẦN
//      public string Name { get => _name ; set _name = value }
//      NẾU QUÊN CÚ PHÁP THÌ GÕ propfull tab
//      CÁCH NÀY ĐƯỢC GỌI LÀ FULL PROPERTY (HÀM + BACKING FIELD)

//CÁCH 3: KHAI BÁO HÀM GET() SET() STYLE NGẮN GỌN, KHÔNG THÈM XÀI BACKING FIELD, RUNTIME SẼ TỰ TẠO RA BACKING FIELD
//      public string Name { get; set; }
//      NẾU QUÊN CÚ PHÁP THÌ GÕ prop tab tab
//      CÁCH NÀY ĐƯỢC GỌI LÀ AUTO IMPLEMENTED PROPERTY
//      RUNTIME SẼ TỰ SINH RA BACKING FIELD CHO TA

//CÁCH 4: KHAI BÁO BACKING FIELD NHƯ BÌNH THƯỜNG (GIỐNG JAVA) VÀ CHỦ ĐỘNG LÀM CÁC HÀM GET() SET() TRUYỀN THỐNG 
//      HOẶC KHÔNG CÓ HÀM GET() SET() NHƯNG CÓ CÁC HÀM KHÁC ĐỂ XỬ LÍ BACKING FIELD BÌNH THƯỜNG
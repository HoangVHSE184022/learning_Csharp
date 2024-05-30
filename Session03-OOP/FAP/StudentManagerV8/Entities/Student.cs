using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerV8.Entities
{
    internal class Student
    {
		//propfull tab
		//KỸ THUẬT THIẾT KẾ CLASS MÀ XÀI BACKING FIELD ĐI KÈM GET() SET() KIỂU MỚI GỌI LÀ FULL PROPERTY
		private string _id;
        private string _name;
        private int _yob;
        private double _gpa;

        public string Id
		{
			get { return _id; }
			set { _id = value; }
		}

		public string Name
		{
			get { return _name; }
			set { _name = value; }
		}

		public int Yob
		{
			get { return _yob; }
			set { _yob = value; }
		}

		public double Gpa
		{
			get { return _gpa; }
			set { _gpa = value; }
		}

	}
}

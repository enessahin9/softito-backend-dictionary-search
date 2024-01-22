using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softito_backend_dictionary_search;

	public interface IStudent : IUser
	{
		string _studentNo { get; set; }
		int _absenteeism { get; set; }
		byte _marks { get; set; }

	}
	public class Student : User, IStudent
	{
		public string _studentNo { get; set; }
		public int _absenteeism { get; set; }
		public byte _marks { get; set; }
		public  Student() { }
		public Student(string userName, string password, bool isActive, string identityNo, int absenteeism, byte marks, string studentNo) : base(identityNo, userName, password, isActive )

	{
		_studentNo = studentNo;
		_absenteeism = absenteeism;
		_marks = marks;
	}
}

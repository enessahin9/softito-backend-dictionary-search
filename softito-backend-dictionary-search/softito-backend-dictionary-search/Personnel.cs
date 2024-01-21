using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace softito_backend_dictionary_search
{
	public interface IPersonnel : IUser
	{
		string _ssn { get; set; }
		decimal _salary { get; set; }
		void CalculateSalary(short workingHours);
	}
	public class Personnel : User, IPersonnel
	{
		public string _ssn { get; set; }
		public decimal _salary { get; set; }
		public void CalculateSalary(short workingHours)
		{
			Console.WriteLine(@$"Calculated salary: {_salary * workingHours} ₺");
		}
		public Personnel() { }
		public Personnel(string userName, string password, bool isActive, string ssn, decimal salary, string identityNo) : base(identityNo, userName, password, isActive)
		{
			_ssn = ssn;
			_salary = salary;
		}
	}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softito_backend_dictionary_search;

public interface IJobber : IUser
{
	string _workArea { get; set; }
	string _licensePlate { get; set; }
}
public class Jobber : User, IJobber
{
	public string _workArea { get; set; }
	public string _licensePlate { get; set; }
	public Jobber() { }
	public Jobber(string userName, string password, bool isActive, string identityNo, string workArea, string licensePlate) : base(identityNo, userName, password, isActive)
	{
		_workArea = workArea;
		_licensePlate = licensePlate;
	}
}


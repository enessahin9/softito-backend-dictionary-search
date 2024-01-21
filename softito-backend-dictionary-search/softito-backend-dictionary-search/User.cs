using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softito_backend_dictionary_search;

	public interface IUser
	{
		string _identityNo { get; set; }
		string _userName { get; set; }
		string _password { get; set; }
		string _firstName { get; set; }
		string _lastName { get; set; }
		bool _isActive { get; set; }

	}
	public class User : IUser
	{
		public string _identityNo { get; set; }
		public string _userName { get; set; }
		public string _password { get; set; }
		public string _firstName { get; set; }
		public string _lastName { get; set; }
		public bool _isActive { get; set; }
		
		public User() { }
		public User(string identityNo, string userName, string password, bool isActive)
		{
			_identityNo = identityNo;
			_userName = userName;
			_password = password;
			_isActive = isActive;
		}

	
	public enum UserTypeEnum
		{
			Personal,
			Student,
			Jobber
		}
		public static class UserFactory
		{
			public static IUser GetInstance(UserTypeEnum userType)
		{
			if(userType == UserTypeEnum.Personal)
			{
				return new Personnel();
			}
			if(userType == UserTypeEnum.Student)
			{
				return new Student();
			}
			return new Jobber();
		}

		}
	}


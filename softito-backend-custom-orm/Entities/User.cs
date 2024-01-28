using softito_backend_custom_orm.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softito_backend_custom_orm.Entities
{
	public class User
	{
		[Id]
		public int Id { get; set; }

		[Column(ColumnName = "Username")]
		public string Username { get; set; }

		[Column(ColumnName = "Pass")]
		public string Password { get; set; }

		[Column(ColumnName = "Age")]
		public int Age { get; set; }

		[Column(ColumnName = "RegistrationDate")]
		public DateTime RegistrationDate { get; set; }

		[Column(ColumnName = "LastLoginTime")]
		public DateTime LastLoginTime { get; set; }

		[Column(ColumnName = "IsActive")]
		public bool IsActive { get; set; }

		public User(string username, string password, int age, DateTime registrationDate, DateTime lastLoginTime, bool isActive)
		{
			Username = username;
			Password = password;
			Age = age;
			RegistrationDate = registrationDate;
			LastLoginTime = lastLoginTime;
			IsActive = isActive;
		}

		// Ekstra Özellik: Expression-bodied Members
		public string DisplayInfo() => $"Username: {Username}, Age: {Age}, Registration Date: {RegistrationDate}, " +
									  $"Last Login Time: {LastLoginTime}, IsActive: {IsActive}";

		// Ekstra Özellik: Null-forgiving Operator
		public string GetUsernameOrUnknown() => Username ?? "Unknown Username";
	}
}

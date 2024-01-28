// See https://aka.ms/new-console-template for more information

using Microsoft.EntityFrameworkCore;
using softito_backend_custom_orm.Entities;
using System.Data.Common;

namespace softito_backend_custom_orm
{
 class Program
	{
		static void Main()
		{
			string connectionString = new ConnectionStringBuilder("TestDatabase").ConnectionString;
			IDbContext context = new EntityManager(connectionString, true);

			#region //Task 11 Fetch Users  
			IEnumerable<User> users = context.FindAll<User>("Age >= 18 ");
			foreach (var user in users)
			{
				Console.WriteLine(user.Username);
			}
			#endregion

			#region //Task 12 Add New Entity 
			// List<Book> books = new List<Book>()
			// {
			//     new Book("Harry Potter and the Cursed Child - Parts I & II", "J.K. Rowling , Jack Thorne , John Tiffany", new DateTime(2015, 10, 2), "English", true),
			//     new Book("Merchant of Venice", "Shakespeare W.", new DateTime(2013, 11, 3), "English", false),
			//     // Diğer kitaplar...
			// };
			//
			// foreach (Book book in books)
			// {
			//     context.Persist(book);
			// }
			//
			// int lengthOfTitle = int.Parse(Console.ReadLine());
			// IEnumerable<Book> wantedBooks = context.FindAll<Book>($"LEN(Title) >= {lengthOfTitle} AND IsHardCovered = 1");
			//
			// int numberOfBooksWithGivenLen = 0;
			// foreach (Book book in wantedBooks)
			// {
			//     book.Title = book.Title.Substring(0, lengthOfTitle);
			//     context.Persist(book);
			//     numberOfBooksWithGivenLen++;
			// }
			//
			// Console.WriteLine($"{numberOfBooksWithGivenLen} books now have title with length of {lengthOfTitle}");
			#endregion

			// Diğer görev blokları...

		}

		private static double ConvertSecondsToYears(double seconds)
		{
			return ConvertSecondsToMonths(seconds) / 365;
		}

		private static double ConvertSecondsToMonths(double seconds)
		{
			return ConvertSecondsToDays(seconds) / 30;
		}

		private static double ConvertSecondsToDays(double seconds)
		{
			return ConvertSecondsToHours(seconds) / 24;
		}

		private static double ConvertSecondsToHours(double seconds)
		{
			return ConvertSecondsToMinutes(seconds) / 60;
		}

		private static double ConvertSecondsToMinutes(double seconds)
		{
			return seconds / 60;
		}
	}
}

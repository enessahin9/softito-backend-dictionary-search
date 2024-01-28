using softito_backend_custom_orm.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace softito_backend_custom_orm.Entities
{
	[Entity(TableName = "Books")]
	public class Book
	{
		[Id]
		public int Id { get; set; }

		[Column(ColumnName = "Title")]
		public string Title { get; set; }

		[Column(ColumnName = "Author")]
		public string Author { get; set; }

		[Column(ColumnName = "PublishedOn")]
		public DateTime PublishedOn { get; set; }

		[Column(ColumnName = "Language")]
		public string Language { get; set; }

		[Column(ColumnName = "IsHardCovered")]
		public bool IsHardCovered { get; set; }

		[Column(ColumnName = "Rating")]
		public decimal Rating { get; set; }

		public Book(string title, string author, DateTime publishedOn, string language, bool isHardCovered, decimal rating)
		{
			Title = title;
			Author = author;
			PublishedOn = publishedOn;
			Language = language;
			IsHardCovered = isHardCovered;
			Rating = rating;
		}

		// Ekstra Özellik: Expression-bodied members
		public string DisplayInfo() => $"Title: {Title}, Author: {Author}, Published On: {PublishedOn}, Language: {Language}, " +
									  $"Is Hard Covered: {IsHardCovered}, Rating: {Rating}";

		// Ekstra Özellik: Null-forgiving Operator
		public string GetAuthorOrUnknown() => Author ?? "Unknown Author";
	}
}

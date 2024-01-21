using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace softito_backend_dictionary_search;

public static class MicrosoftExtensions
{
	public static void WriteLine(this string text, string addText = "")
	{
		Console.WriteLine(addText + text);
	}
	public static List<T> FindAll<T>(this IList<T> values, Predicate<T> predicate)
	{
		return values.ToList().FindAll(predicate);
	}
	public static T? Find<T>(this IList<T> values, Predicate<T> predicate)
	{
		return values.ToList().Find(predicate);
	}

	public static void AddToDictionary<TKey, TValue>(
		this IDictionary<TKey, TValue> values,
		IList<TValue> users,
		IDictionary<TKey, IList<TKey>> indexes
		)
		where TKey : notnull
		where TValue : IUser
	{
		TKey castToKey(object key)
		{
			return (TKey)key;
		};
		void addIndex(object findKeyObject, TKey dataKey)
		{
			TKey findKey = castToKey(findKeyObject);
			if (indexes.ContainsKey(findKey))
			{
				indexes[findKey].Add(dataKey);
			}
			else
			{
				indexes.Add(findKey, new List<TKey>() { dataKey });
			}
		};
		users?.ToList().ForEach(user =>
		{
			TKey key = castToKey(user._userName);
			values.Add(key, user);

			addIndex(user._userName, key);
			addIndex(user._firstName, key);
			addIndex(user._lastName, key);
			addIndex(user._identityNo, key);


			var personal = user.CastTo<IPersonnel>();
			var student = user.CastTo<IStudent>();
			var jobber = user.CastTo<IJobber>();
			if (personal != null)
			{
				addIndex(personal._ssn, key);
				addIndex(personal._salary.ToString(), key);
			}
			if (student != null)
			{
				addIndex(student._studentNo, key);
				addIndex(student._absenteeism.ToString(), key);
				addIndex(student._marks.ToString(), key);
			}
			if (jobber != null)
			{
				addIndex(jobber._workArea, key);
				addIndex(jobber._licensePlate, key);
			}
		});
	}
	public static TObject? CastTo<TObject>(this object value)
		where TObject : class
	{
		if (value is TObject)
		{
			return value as TObject;
		}
		return null;
	}
}

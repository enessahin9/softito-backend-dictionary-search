// See https://aka.ms/new-console-template for more information

using Example.Datas;
using Newtonsoft.Json;
using softito_backend_dictionary_search;

var personnelUsers = JsonConvert.DeserializeObject<IList<Personnel>>(PersonnelDatas.PersonnelJson);
var studentUsers = JsonConvert.DeserializeObject<IList<Student>>(StudentDatas.StudentJson);
var jobberUsers = JsonConvert.DeserializeObject<IList<Jobber>>(JobberDatas.JobberJson);

IDictionary<string, IList<string>> indexes = new Dictionary<string, IList<string>>();
IDictionary<string, IUser> fastList = new Dictionary<string, IUser>();

fastList.AddToDictionary(personnelUsers.Select(user => (user as IUser)).ToList(), indexes);
fastList.AddToDictionary(studentUsers.Select(user => (user as IUser)).ToList(), indexes);
fastList.AddToDictionary(jobberUsers.Select(user => (user as IUser)).ToList(), indexes);

var findAll = FindByIndex("ejeannequin4z");
JsonConvert.SerializeObject(findAll).WriteLine();
//Console.ReadKey(); //TODO

JsonConvert.SerializeObject(indexes).WriteLine();
Console.ReadKey();

IList<IUser>? FindByIndex(string search)
{
	if (indexes.ContainsKey(search))
	{
		var findedKeys = indexes[search];
		return findedKeys.Select(key => fastList[key]).ToList();
	}
	return null;
}
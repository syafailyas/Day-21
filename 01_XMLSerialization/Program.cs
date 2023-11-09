using System.IO;
using System.Xml.Serialization;

public class Person
{
	public string? Name { get; set; }
	public int Age { get; set; }

}

class Program
{
	static void Main()
	{
		Person person = new Person { Name = "Bob", Age = 11 };
		
		XmlSerializer serializer = new XmlSerializer(typeof(List<Person>));
		
		// using (StreamWriter writer = new StreamWriter("person.xml"))
		// {
		// 	serializer.Serialize(writer, person);
		// }

		List<Person> deserializedPerson;
		using (StreamReader reader = new StreamReader("person.xml"))
		{
			deserializedPerson = (List<Person>)serializer.Deserialize(reader);
		}
		foreach(var x in deserializedPerson) 
		{
			Console.WriteLine(x.Name);
		}
		//Console.WriteLine($"Deserialized Person: {deserializedPerson?.Name}, {deserializedPerson.Age}");
	}
}

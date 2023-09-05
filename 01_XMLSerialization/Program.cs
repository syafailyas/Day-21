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
		Type type = typeof(Person);
		XmlSerializer serializer = new XmlSerializer(type);
		using (StreamWriter writer = new StreamWriter("person.xml"))
		{
			serializer.Serialize(writer, person);
		}

		Person deserializedPerson;
		using (StreamReader reader = new StreamReader("person.xml"))
		{
			deserializedPerson = (Person)serializer.Deserialize(reader);
		}

		Console.WriteLine($"Deserialized Person: {deserializedPerson?.Name}, {deserializedPerson.Age}");
	}
}

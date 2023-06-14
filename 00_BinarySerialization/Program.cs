using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// Attribute to mark it as serializable
// Serialization is the process of converting an object's state (data) into a format that can be stored or transmitted. This is useful for saving data to a file, sending it over a network, or working with different data formats like XML or JSON.
[Serializable]
public class Person
{
	public string Name { get; set; }
	public int Age { get; set; }
}

class Program
{
	static void Main(string[] args)
	{
		Person person = new Person { Name = "Alice", Age = 10 };

		// Serialize the object
		BinaryFormatter formatter = new BinaryFormatter();
		using (FileStream stream = new FileStream("person.bin", FileMode.Create))
		{
			formatter.Serialize(stream, person);
		}

		// Deserialize the object
		Person deserializedPerson;
		using (FileStream stream = new FileStream("person.bin", FileMode.Open))
		{
			deserializedPerson = (Person)formatter.Deserialize(stream);
		}

		Console.WriteLine($"Deserialized Person: {deserializedPerson.Name}, {deserializedPerson.Age}");
	}
}

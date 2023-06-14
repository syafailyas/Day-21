using System.IO;
using System.Text.Json;

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Person person = new Person { Name = "Charlie", Age = 12 };

        // Serialize the object
        string jsonString = JsonSerializer.Serialize(person);

        // Save JSON to a file
        File.WriteAllText("person.json", jsonString);

        // Read JSON from a file
        string jsonFromFile = File.ReadAllText("person.json");

        // Deserialize the object
        Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonFromFile);

        Console.WriteLine($"Deserialized Person: {deserializedPerson.Name}, {deserializedPerson.Age}");
    }
}

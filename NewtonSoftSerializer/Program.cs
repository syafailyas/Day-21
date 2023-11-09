using Newtonsoft.Json;

class Player
{
	[JsonProperty]
	public string name;
	[JsonProperty]
	public int id;
}
class Card 
{
	[JsonProperty]
	public int id;
}
class MyDictionary
{
	Dictionary<Player, Card> playerCard = new();
}
class Program 
{
	static void Main() 
	{
		Player player = new Player() { name = "yusuf", id = 3 };
		Player player2 = new Player() { name = "andi", id = 4 };
		Player player3 = new Player() { name = "yanto", id = 5 };
		Card c = new Card() { id = 4 };
		
		
		playerCard.Add(player, c);
		playerCard.Add(player2, c);
		playerCard.Add(player3, c);

		string result = JsonConvert.SerializeObject(playerCard);
		Console.WriteLine(result);
		
		// DataContractJsonSerializer serialize = new(typeof(Dictionary<Player, Card>));
		// using (FileStream sw = new FileStream("myXml.json",FileMode.Create))
		// {
		// 	using(var writer = JsonReaderWriterFactory.CreateJsonWriter(sw,Encoding.UTF8,true,true," ")) 
		// 	{
		// 		serialize.WriteObject(writer, playerCard);
		// 	}
		// }
	}
}

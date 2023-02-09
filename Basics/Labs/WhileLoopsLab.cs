using System;
					
public class Program
{
	public static void Main()
	{
		string[] playerTypes = {"King", "Soldier", "Poet"};
		
		for (var i = 0; i < playerTypes.Length ; i++) {
			playerTypes[i] = "Jester";
		}
		
		foreach(var playerType in playerTypes) {
			Console.WriteLine(playerType);
		}
	}
}

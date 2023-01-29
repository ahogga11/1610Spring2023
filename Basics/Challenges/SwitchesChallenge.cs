using System;
					
public class Program
{
	public CharacterRelationship characterRelationship;
	
	public void Main()
	{
		characterRelationship = new CharacterRelationship();
		characterRelationship.currentRelationship = CharacterRelationship.Relationship.Two;
		characterRelationship.CheckRelationship();
	}
}

public class CharacterRelationship {
	
	public enum Relationship {
		Five,
		Four,
		Three,
		Two,
		One
	}
	
	public Relationship currentRelationship = Relationship.Five;
	
	public void CheckRelationship () {
		switch (currentRelationship) {
			case Relationship.Five:
				Console.WriteLine("I made you your favorite food.");
				break;
			case Relationship.Four:
				Console.WriteLine("Would you like to go see a movie with me?");
				break;
			case Relationship.Three:
				Console.WriteLine("Your hair looks really nice today.");
				break;
			case Relationship.Two:
				Console.WriteLine("The weather is nice today.");
				break;
			case Relationship.One:
				Console.WriteLine("Do I know you?");
				break;
		}
	}
}

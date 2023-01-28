using System;
					
public class Program
{
	public GameStates gameStates;
	
	public void Main()
	{
		gameStates = new GameStates();
		gameStates.currentState = GameStates.States.Two;
		gameStates.CheckState();
	}
}

public class GameStates {
	
	public enum States {
		Five,
		Four,
		Three,
		Two,
		One
	}
	
	public States currentState = States.Five;
	
	public void CheckState () {
		switch (currentState) {
			case States.Five:
				Console.WriteLine("I made you your favorite food.");
				break;
			case States.Four:
				Console.WriteLine("Would you like to go see a movie with me?");
				break;
			case States.Three:
				Console.WriteLine("Your hair looks really nice today.");
				break;
			case States.Two:
				Console.WriteLine("The weather is nice today.");
				break;
			case States.One:
				Console.WriteLine("Do I know you?");
				break;
		}
	}
}

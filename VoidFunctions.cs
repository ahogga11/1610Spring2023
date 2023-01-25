using System;

public class Program
{
	public Operations myOperator;
		
    public void Main ()
    {
		myOperator = new Operations();
		
        Console.WriteLine("Welcome");
		myOperator.DoMath(10, 4);
		myOperator.DoMath(20, 7);
		myOperator.DoMath(30, 15);
		myOperator.Compare(4,3);
		myOperator.Compare(3,4);
		myOperator.CheckPassword("SevenOF9");
		myOperator.CheckPassword("OU812");
		myOperator.ConditionalLab(50, 10);
		myOperator.ConditionalLab2(50, 50);
		myOperator.ConditionalLab3(20);
    }
	
    
}

public class Operations {
	public void DoMath (int value, int value2) {
        var number = value + value2;
        Console.WriteLine(number);
    }
	public void Compare (int value, int value2) {
		if(value > value2) {
			Console.WriteLine("True, the first is greater");
		} else {
			Console.WriteLine("False, the second is greater");
		}
	}
	public void CheckPassword (string password) {
		if(password == "OU812") {
			Console.WriteLine("Correct Password");
		} else {
			Console.WriteLine("Incorrect Password");
		}
	}
	public void ConditionalLab (int value, int value2) {
	int x = 50;
	int y = 10; 
	if(x > y) {
		Console.WriteLine("Hello World");
		}
	}
	public void ConditionalLab2 (int value, int value2) {
	int x = 50;
	int y = 50;
	if(x == y) {
		Console.WriteLine("1");
		} else if (x > y) {
			Console.WriteLine("2");
		} else {
			Console.WriteLine("3");
		}
	}
	public void ConditionalLab3 (int value) {
	int time = 20;
	string result = (time < 18) ? "Good day." : "Good evening.";
		Console.WriteLine(result);
	}
}
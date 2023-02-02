using System;
					
public class Program
{
	public void Main()
	{
		flower[] flowersObjs = {new flower (), new flower(), new flower()};
		flowersObjs[1].flowerName = "Lily";
		flowersObjs[2].flowerName = "Dahlia";
		
		for(var i=0; i <flowersObjs.Length; i++) {
			flowersObjs[i].scentLevel = 4; 
		}
		foreach(var item in flowersObjs){
			Console.WriteLine(item.flowerName);
			Console.WriteLine(item.scentLevel);
		}
	}
}
								
public class flower {
	public string flowerName = "Lavender";
	public int scentLevel =1;
	
}

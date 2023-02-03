using System;
					
public class Program
{
	public void Main()
	{
		animal[] animalsObjs = {new animal (), new animal(), new animal(), new animal()};
		animalsObjs[1].animalBreed = "Preying Mantis";
		animalsObjs[2].animalBreed = "Crow";
		animalsObjs[3].animalBreed = "Cheetah";
		
		for(var i=0; i <animalsObjs.Length; i++) {
			animalsObjs[i].instinctsLevel = 4; 
		}
		foreach(var item in animalsObjs){
			Console.WriteLine(item.animalBreed);
			Console.WriteLine(item.instinctsLevel);
		}
	}
}
								
public class animal {
	public string animalBreed = "Shark";
	public int instinctsLevel =5;
	
}

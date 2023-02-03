using System;
					
public class Program
{
	public static void Main()
	{
		string[] musicGenres = {"Metal", "Rock", "Classical", "Pop Grunge"};
		
		for (var i = 0; i < musicGenres.Length ; i++) {
			musicGenres[i] = "Music feeds the soul";
		}
		
		foreach(var musicGenre in musicGenres) {
			Console.WriteLine(musicGenre);
		}
	}
}

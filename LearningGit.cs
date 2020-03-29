using System;
namespace LearningGit {
	class Program {
		public static void Main() {
			
			//empty C# program
			
			//printing a message, adding, merging, and pushing
			Console.WriteLine("Knock Knock!");
			
			//responding from another file
			Console.WriteLine("..Who's there?");
			
			//creating a conflict and fixing
			Console.WriteLine("K. Waguespack");
			
			KnockKnock();
			
			
		}
		
		//adding a knock feature on a seperate branch
		public static void KnockKnock() {
			for(int i = 0; i < 5; i++){
				Console.WriteLine("Knock");
			}
		}
	}
}
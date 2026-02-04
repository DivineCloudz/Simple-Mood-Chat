using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace HelloWorld
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("How are you feeling today");
			while (true){
			  
			 string a = Console.ReadLine();
			  
			  if (a == "happy"){
			    
			    Console.WriteLine("Looks like something happened good with you");
			    
			  }
			  
			  else if (a == "sad"){
			    
			    Console.WriteLine("I feel sorry for you");
			    
			  }
			  
			  else{
			    
			    Console.WriteLine("Can you repeat");
			    
			  }
			  
			  Console.WriteLine("Do you want to change your mood\nY/N");
			  string b = Console.ReadLine();
			  
			  if (b == "Y"){
			    
			    Console.WriteLine("Okay so how do you feel now");
			    
			  }
			  
			  else{
			    
			    Console.WriteLine("Okay bye");
			    break;
			  }
			  
			  
			}
		}
	}
}

using System;

namespace DataStructuresDemo.Modules{
	class Menu {
		private string title;
		private string[] items;
		private string backText;
	
		public Menu(string title, string[] items, string backText) {
			this.items = items;
			this.title = title;
			this.backText = backText;
		}
		
		public Menu(string title, string[] items) {
			this.items = items;
			this.title = title;
			this.backText = "Back";
		}
	
		public void show() {
			Console.WriteLine($"{title}\n--------------------------------");
			int i = 1;
			foreach (string item in items) {
				Console.WriteLine($"{i} - {item}");
				i++;
			}
			Console.WriteLine($"\n0 - {this.backText}\n--------------------------------");
		}
	
		public int getInput() {
			int choice = -1;
			while (choice > items.Length || choice < 0) {
				Console.Write("Enter choice: ");
				try { choice = Int32.Parse(Console.ReadLine()); }
				catch (FormatException) { Console.WriteLine("Invalid input!"); }
				if (choice > items.Length) {
					Console.WriteLine($"Must be a number between 0 and {items.Length}!");
				}
			}
			return choice;
		}
	}
}
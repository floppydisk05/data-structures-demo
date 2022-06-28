//@Project:	Data Structures Demonstration
//@Author:	Frankie B. (floppydisk05)
//@Contact:	floppydisk05@aol.com
//@Created:	09:34 AM Tuesday, March 22, 2022
//@Updated:	10:09 PM Tuesday, June 28, 2022

using System;

using DataStructuresDemo.Demos;
using DataStructuresDemo.Modules;

namespace DataStructuresDemo
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu mainMenu = new Menu("Main Menu", new string[] {"Queues", "Lists", "Stacks", "Hashtables", "Dictionaries"}, "Exit");
			while (true) {
				Console.Clear();
				mainMenu.show();
				switch (mainMenu.getInput()) {
					case 1:
						QueuesDemo.run();
						break;
					case 2:
						ListsDemo.run();
						break;
					case 3:
						StacksDemo.run();
						break;
					case 4:
						HashtablesDemo.run();
						break;
					case 5:
						DictionariesDemo.run();
						break;
					case 0:
						Console.Clear();
						Console.WriteLine("Exiting...");
						Environment.Exit(0); // Exits with code 0
						break;
				}
			}
		}
	}
}

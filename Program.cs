// Data Structures Demonstation by Frankie (floppydisk05)
// A demonstration of stacks, queues, lists and more!
// Created:		22 March 2022
// Modified:	01 April 2022

using System;

using data_structures_demo.Demos;
using data_structures_demo.Modules;

namespace data_structures_demo
{
	class Program
	{
		static void Main(string[] args)
		{
			Menu mainMenu = new Menu("Main Menu", new string[] {"Queues", "Lists", "Stacks", "Hashtables"}, "Exit");
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

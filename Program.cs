using System;

using data_structures_demo.Demos;

namespace data_structures_demo
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] mainMenuItems = {"Queues"};
			Menu mainMenu = new Menu("Main Menu", mainMenuItems);
			while (true) {
				Console.Clear();
				mainMenu.show();
				switch (mainMenu.getInput()) {
					case 1:
						QueuesDemo.run();
						break;
					case 0:
						Console.Clear();
						Console.WriteLine("Exiting...");
						// Exits with code 0
						Environment.Exit(0);
						break;
				}
			}
		}
	}
}

using System;

namespace DataStructuresDemo.Modules {
	class Util {
		public static string getInput(string prompt) {
			Console.Write(prompt);
			return Console.ReadLine();
		}

		public static void waitForEnter() {
			Console.WriteLine("Press ENTER to continue");
			Console.ReadLine();
		}

		public static void waitForEnter(string message) {
			Console.WriteLine($"{message}\nPress ENTER to continue");
			Console.ReadLine();
		}
	}
}
using System;
using System.Collections.Generic;

using data_structures_demo.Modules;

namespace data_structures_demo.Demos {
	class StacksDemo {
		public static void run() {
			string size = Util.getInput("Enter 0 for predefined data or anything else for blank: ");
			Stack<string> stack = new Stack<string>();
			if (size == "0") stack = new Stack<String>(new string[] {"This", "is", "a", "test", "stack"});

			bool running = true;
			while (running) {
				Console.Clear();
				Menu stackMenu = new Menu("Stacks Demo", new string[] {"Push to stack", "Pop from stack", "Clear stack", "Show stack", "Show size"});
				stackMenu.show();
				switch (stackMenu.getInput()) {
					case 1:
						string item = Util.getInput("Enter string to push: ");
						stack.Push(item);
						Console.WriteLine($"Pushed \"{item}\" to stack");
						Util.waitForEnter();
						break;
					case 2:
						string poppedItem = stack.Pop();
						Console.WriteLine($"Popped \"{poppedItem}\" from the stack");
						Util.waitForEnter();
						break;
					case 3:
						stack.Clear();
						Console.WriteLine("Cleared stack");
						Util.waitForEnter();
						break;
					case 4:
						if (stack.Count > 0) {
							string items = "";
							foreach (string stackItem in stack) {
								items += $"{stackItem}, ";
							}
							Console.WriteLine($"Stack: {items.Substring(0, items.Length - 2)}");
						} else {
							Console.WriteLine("Stack is empty");
						}
						Util.waitForEnter();
						break;
					case 5:
						Console.WriteLine($"Stack size: {stack.Count}");
						Util.waitForEnter();
						break;
					case 0:
						running = false;
						return;
				}
			}
		}
	}
}
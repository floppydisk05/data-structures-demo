using System;
using System.Collections.Generic;

using DataStructuresDemo.Modules;

namespace DataStructuresDemo.Demos {
	class ListsDemo {
		public static void run() {
			int size = -1;
			while (size < 0 || size > 20) {
				try {
					size = Int32.Parse(Util.getInput("Enter list size or 0 for predefined data: "));
				} catch (Exception) {
					Console.WriteLine("Must be a valid integer!");
				} finally {
					if (size > 20 || size < 0) Console.WriteLine("Must be between 0 and 20!");
				}
			}
			
			bool running = true;
			List<string> list;
			if (size == 0) list = new List<string>(15) {"This", "is", "a", "test", "list"};
			else list = new List<string>(size);

			while (running) {
				Console.Clear();
				Menu listMenu = new Menu("Lists Demo", new string[] {"Add element", "Add by index", "Remove element", "Remove by index", "Check elements", "Show list"});
				listMenu.show();
				string item;
				int idx;
				switch (listMenu.getInput()) {
					case 1:
						item = Util.getInput("Enter item to add: ");
						list.Add(item);
						Console.WriteLine($"Added {item} to the list");
						Util.waitForEnter();
						break;
					case 2:
						item = Util.getInput("Enter item to add: ");
						idx = -1;
						while (idx < 0 || idx > list.Count - 1) {
							try { idx = Int32.Parse(Util.getInput("Enter index: ")); }
							catch (Exception) { Console.WriteLine($"Must be an integer between 0 and {list.Count - 1}!"); }
						}
						list.Insert(idx, item);
						Console.WriteLine($"Added {item} at index {idx}");
						Util.waitForEnter();
						break;
					case 3:
						item = Util.getInput("Enter item to remove: ");
						bool rem = list.Remove(item);
						if (rem) Console.WriteLine($"Removed first occurance of \"{item}\"");
						else Console.WriteLine($"\"{item}\" was not found in the list");
						Util.waitForEnter();
						break;
					case 4:
						idx = -1;
						while (idx < 0 || idx > list.Count - 1) {
							try { idx = Int32.Parse(Util.getInput("Enter index: ")); }
							catch (Exception) { Console.WriteLine($"Must be an integer between 0 and {list.Count - 1}!"); }
						}
						list.RemoveAt(idx);
						Console.WriteLine($"Removed item at index {idx}");
						Util.waitForEnter();
						break;
					case 5:
						item = Util.getInput("Enter item to search for: ");
						bool found = list.Contains(item);
						if (found) Console.WriteLine($"List contains \"{item}\"");
						else Console.WriteLine($"List does not contain \"{item}\"");
						Util.waitForEnter();
						break;
					case 6:
						Console.WriteLine($"Contains {list.Count} items");
						string itm = "[";
						list.ForEach(item => itm += $"{item}, ");
						itm = $"{itm.Substring(0, itm.Length - 2)}]";
						Console.WriteLine(itm);
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
using System;
using System.Collections;

using data_structures_demo.Modules;

namespace data_structures_demo.Demos {
	class HashtablesDemo {
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
			Hashtable ht;
			if (size == 0) {
                ht = new Hashtable(){
                    {"x", "20"},
                    {"y", "4"},
                {   "z", "15"}
                };
            } else {
                ht = new Hashtable();
            }

			while (running) {
				Console.Clear();
				Menu htMenu = new Menu("Hashtables Demo", new string[] {"Add element", "Remove by key", "Clear hashtable", "Search for key", "Search for value", "Show hashtable", "Show total pairs"});
				htMenu.show();
                bool valid = false;
				switch (htMenu.getInput()) {
                    case 1:
                        Console.Write("Enter key: ");
                        string key = Console.ReadLine();
                        Console.Write("Enter value: ");
                        string value = Console.ReadLine();
                        ht.Add(key, value);
                        break;
                    case 2:
                        while (!valid) {
                            Console.Write("Enter key to remove: ");
                            string keyToRemove = Console.ReadLine();
                            if (ht.ContainsKey(keyToRemove)) {
                                Console.WriteLine($"Removed key pair \"{keyToRemove}\" : \"{ht[keyToRemove]}\"");
                                ht.Remove(keyToRemove);
                                valid = true;
                            } else {
                                Console.WriteLine("Key does not exist in hashtable!");
                            }
                        }
                        Util.waitForEnter();
                        break;
                    case 3:
                        ht.Clear();
                        Console.WriteLine("Cleared hashtable");
                        break;
                    case 4:
                        Console.Write("Key to search for: ");
                        string keyToSearchFor = Console.ReadLine();
                        if (ht.ContainsKey(keyToSearchFor))
                            Console.WriteLine($"Key \"{keyToSearchFor}\" exists with value \"{ht[keyToSearchFor]}\"");
                        else
                            Console.WriteLine($"Key \"{keyToSearchFor}\"does not exist in hashtable");
                        Util.waitForEnter();
                        break;
                    case 5:
                        Console.Write("Value to search for: ");
                        string valueToSearchFor = Console.ReadLine();
                        if (ht.ContainsValue(valueToSearchFor))
                            Console.WriteLine($"Hashtable contains value \"{valueToSearchFor}\"");
                        else
                            Console.WriteLine($"Hashtable does not contain value \"{valueToSearchFor}\"");
                        Util.waitForEnter();
                        break;
                    case 6:
                        ICollection keys = ht.Keys;
                        Console.WriteLine("{");
                        foreach (string k in keys) {
                            Console.WriteLine($"\t{k}: {ht[k]}");
                        }
                        Util.waitForEnter("}");
                        break;
                    case 7:
                        Console.WriteLine($"Hashtable size: {ht.Count}");
                        if (ht.IsFixedSize) Console.WriteLine("Hashtable has fixed size.");
                        Util.waitForEnter();
                        break;
                    case 0:
                        return;
				}
			}
		}
	}
}
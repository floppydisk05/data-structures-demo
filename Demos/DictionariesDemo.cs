using System;
using System.Collections.Generic;

using DataStructuresDemo.Modules;

namespace DataStructuresDemo.Demos {
	class DictionariesDemo {
		public static void run() {
			string size = "x";
			while (size != "" && size != "0") {
				try {
					size = Util.getInput("Enter 0 for predefined data or nothing for empty: ");
				} catch (Exception) {
					Console.WriteLine("Must be empty or 0!");
				}
			}

            Dictionary<string, string> dict;

            if (size == "0") {
                dict = new Dictionary<string, string>(){
                    {"key", "value"},
                    {"this", "is"},
                    {"an", "example"}
                };
            } else {
                dict = new Dictionary<string, string>();
            }
			
			bool running = true;

			while (running) {
				Console.Clear();
				Menu dictMenu = new Menu("Dictionaries Demo", new string[] {"Add element", "Remove by key", "Clear dictionary", "Search for key", "Search for value", "Show dictionary", "Show total pairs"});
				dictMenu.show();
                bool valid = false;
				switch (dictMenu.getInput()) {
                    case 1:
                        Console.Write("Enter key to add: ");
                        string keyToAdd = Console.ReadLine();
                        Console.Write($"Enter value for key \"{keyToAdd}\": ");
                        string valueToAdd = Console.ReadLine();
                        dict.Add(keyToAdd, valueToAdd);
                        Console.WriteLine($"Added \"{keyToAdd}\" : \"{valueToAdd}\" to the dictionary");
                        Util.waitForEnter();
                        break;
                    case 2:
                        while (!valid) {
                            Console.Write("Enter key to remove: ");
                            string keyToRemove = Console.ReadLine();
                            if (dict.ContainsKey(keyToRemove)) {
                                Console.WriteLine($"Removed key pair \"{keyToRemove}\" : \"{dict[keyToRemove]}\"");
                                dict.Remove(keyToRemove);
                                valid = true;
                            } else {
                                Console.WriteLine("Key does not exist in dictionary!");
                            }
                        }
                        break;
                    case 3:
                        dict.Clear();
                        Util.waitForEnter("Cleared dictionary!");
                        break;
                    case 4:
                        Console.Write("Key to search for: ");
                        string keyQuery = Console.ReadLine();
                        if (dict.ContainsKey(keyQuery))
                            Util.waitForEnter($"Key \"{keyQuery}\" exists in dictionary with value \"{dict[keyQuery]}\"");
                        else
                            Util.waitForEnter($"Key \"{keyQuery}\" does not exist in dictionary");
                        break;
                    case 5:
                        List<string> keys = new List<string>();
                        Console.Write("Key to search for: ");
                        string valueQuery = Console.ReadLine();
                        if (dict.ContainsValue(valueQuery)) {
                            keys = keysWithValue(dict, valueQuery);
                            string msg = "";
                            foreach (string item in keys) {
                                msg += $"\"{item}\", ";
                            }
                            msg = msg.Substring(0, msg.Length - 2);
                            Util.waitForEnter($"Keys with value \"{valueQuery}\" are {msg}");
                        } else {
                            Util.waitForEnter($"Key \"{valueQuery}\" does not exist in dictionary");
                        }
                        break;
                    case 6:
                        if (dict.Count == 0) {
                            Console.WriteLine("Dictionary is empty!");
                            Util.waitForEnter();
                            break;
                        }
                        Console.WriteLine("\n{");
                        foreach (KeyValuePair<string, string> pair in dict) {
                            Console.WriteLine($"\t\"{pair.Key}\": \"{pair.Value}\"");
                        }
                        Util.waitForEnter("}");
                        break;
                    case 7:
                        Console.WriteLine($"Total key-value pairs: {dict.Count}");
                        Util.waitForEnter();
                        break;
                    case 0:
                        return;
				}
			}
		}

        public static List<string> keysWithValue (Dictionary<string, string> dict, string value) {
            List<string> exists = new List<string>();
            foreach (KeyValuePair<string, string> pair in dict) {
                if (pair.Value == value) {
                    exists.Add(pair.Key);
                }
            }
            return exists;
        }
	}
}
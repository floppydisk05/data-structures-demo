using System;

namespace data_structures_demo.Modules {
    class Util {
        public static string getInput(string prompt) {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static void waitForEnter() {
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }
    }
}
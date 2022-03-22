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
            mainMenu.show();
            int choice = mainMenu.getInput();
            switch (choice) {
                case 1:
                    QueuesDemo.runDemo();
                    return;
                case 0:
                    Environment.Exit(0);
                    return;
            }
        }
    }
}

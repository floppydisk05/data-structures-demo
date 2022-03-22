using System;

class Menu {
    private string title;
    private string[] items;

    public Menu(string title, string[] items) {
        this.items = items;
        this.title = title;
    }

    public void show() {
        Console.WriteLine($"{title}\n--------------------------------");
        int i = 1;
        foreach (string item in items) {
            Console.WriteLine($"{i} - {item}");
            i++;
        }
        Console.WriteLine("\n0 - Exit\n--------------------------------");
    }

    public int getInput() {
        int choice = -1;
        while (choice > items.Length || choice < 0) {
            Console.Write("Enter choice: ");
            try { choice = Int32.Parse(Console.ReadLine()); }
            catch (FormatException) { Console.WriteLine("Invalid input!"); }
            if (choice > items.Length) {
                Console.WriteLine($"Must be a number between 0 and {items.Length}!");
            }
        }
        return choice;
    }
}
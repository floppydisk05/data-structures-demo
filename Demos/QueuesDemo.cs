using System;
using data_structures_demo.Modules;

namespace data_structures_demo.Demos {
	class QueuesDemo {
		public static void run() {
			int queueSize = -1;
			
			while (queueSize < 2 || queueSize > 20) {
				Console.Write("Enter queue size: ");
				try {
					queueSize = Int32.Parse(Console.ReadLine());
				} catch (Exception) {
					Console.WriteLine("Invalid queue size!");
				}
				if (queueSize < 2 || queueSize > 20)
					Console.WriteLine("Queue size must be in range 2 - 20!");
			}
			bool running = true;
			Queue q = new Queue(queueSize);
			while (running) {
				Console.Clear();
				string[] queueMenuOptions = {"Enqueue", "Dequeue", "Show size", "Show Queue"};
				Menu queueMenu = new Menu("Queues Demo", queueMenuOptions);
				queueMenu.show();
				switch (queueMenu.getInput()) {
					case 1:
						if (q.isFull()) {
							Console.WriteLine("Queue full!");
							waitForEnter();
							break;
						}
						Console.Write("Enter item to queue: ");
						string itemToQueue = stringInput();
						q.enQueue(itemToQueue);
						Console.WriteLine($"\"{itemToQueue}\" enqueued");
						waitForEnter();
						break;
					case 2:
						if (q.isEmpty()) {
							Console.WriteLine("Queue is already empty!");
							waitForEnter();
							break;
						}
						Console.WriteLine($"\"{q.raw()[0]}\" dequeued");
						q.deQueue();
						waitForEnter();
						break;
					case 3:
						Console.WriteLine($"\nQueue size: {q.size()}\nMax size: {q.maxQueueSize()}");
						waitForEnter();
						break;
					case 4:
						q.show();
						waitForEnter();
						break;
					case 0:
						running = false;
						return;
				}
			}
		}

		static void waitForEnter() {
			Console.WriteLine("Press ENTER to continue");
			Console.ReadLine();
		}

		static string stringInput() {
			string output = null;
			while (output == null) {
				try { output = Console.ReadLine(); }
				catch {
					Console.WriteLine("Not a valid string!");
					output = null;
				}
			}

			return output;
		}

		static int intInput() {
			int output = -1;
			while (output == -1) {
				try { output = int.Parse(Console.ReadLine()); }
				catch {
					Console.Write("Not a valid choice!\nTry again: ");
					output = -1;
				}
			}

			return output;
		}
	}
}

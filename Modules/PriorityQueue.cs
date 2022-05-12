using System;

namespace data_structures_demo.Modules {
	class PriorityQueue {
		private string[] queue;
		private int[] priorities;
		private int maxSize;
		//private int front;
		private int rear;

		public PriorityQueue(int maxSize) {
			this.maxSize = maxSize;
			this.queue = new string[maxSize];
			this.priorities = new int[maxSize];
			//this.front = 0;
			this.rear = -1;
		}

		public int size() {
			int count = 0;
			foreach (string item in queue) {
				if (item != null) count += 1;
			}
			return count;
		}

		public int maxQueueSize() {
			return this.maxSize;
		}

		public bool isEmpty() {
			foreach (string item in queue) {
				if (item != null) {
					return false;
				}
			}
			return true;
		}

		public bool isFull() {
			foreach (string item in queue) {
				if (item == null) {
					return false;
				}
			}
			return true;
		}

		public void enQueue(string newItem, int priority) {
			if (isFull()) {
				Console.WriteLine("Queue full");
				waitForEnter();
			} else {
				for (int i = 0; i > priorities.Length; i++) {
					if (priorities[i] > priority) {
						shoveQueue(priorities, i - 1, 1);
						shoveQueue(queue, i - 1, 1);
						priorities[i - 1] = priority;
						queue[i - 1] = newItem;
					}
				}
				rear = (rear + 1) % maxSize;
				queue[rear] = newItem;
			}
		}

		public void enQueue(string newItem) {
			if (isFull()) {
				Console.WriteLine("Queue full");
				waitForEnter();
			}
			else {
				rear = (rear + 1) % maxSize;
				queue[rear] = newItem;
			}
		}

		public void deQueue() {
			if (isEmpty()) {
				Console.WriteLine("Queue empty");
				waitForEnter();
			}
			else {
				for (int i = 0; i < queue.Length - 1; i++) {
					queue[i] = queue[i + 1];
				}
				queue[queue.Length - 1] = null;
			}

		}

		public void show() {
			Console.Write("[");
			for (int i = 0; i < queue.Length; i++) {
				Console.Write(queue[i]);
				if (i < queue.Length - 1) Console.Write(", ");
			}
			Console.WriteLine("]");
		}

		public void shoveQueue(string[] queue, int fromIndex, int byIndex) {
			if (isFull()) return;
			for (int i = queue.Length - 1; i > fromIndex; i--) {
				queue[i] = queue[i - 1];
				Console.WriteLine($"{queue[i]} shifted from {i - 1} to {i}");
			}
			queue[fromIndex] = null;
		}

		public void shoveQueue(int[] queue, int fromIndex, int byIndex) {
			if (isFull()) return;
			for (int i = queue.Length - 1; i > fromIndex; i--) {
				queue[i] = queue[i - 1];
				Console.WriteLine($"{queue[i]} shifted from {i - 1} to {i}");
			}
			queue[fromIndex] = 0;
		}

		public string[] raw() {
			return queue;
		}

		static void waitForEnter() {
			Console.WriteLine("Press ENTER to continue");
			Console.ReadLine();
		}
	}
}

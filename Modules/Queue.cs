using System;

namespace data_structures_demo.Modules {
    class Queue {
        private string[] queue;
        private int[] priorities;
        private int maxSize;
        private int front;
        private int rear;

        public Queue(int maxSize) {
            this.maxSize = maxSize;
            this.queue = new string[maxSize];
            this.priorities = new int[maxSize];
            this.front = 0;
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

        /*public async void enQueue(string newItem, int priority) {
            if (isFull()) {
                Console.WriteLine("Queue full");
                waitForEnter();
            } else {
                for (int i = 0; i > priorities.Length; i++) {
                    if (currentPriority > priority) {
                        for (int i = queue.Length - 1; i > )
                    }
                }
                rear = (rear + 1) % maxSize;
                queue[rear] = newItem;
            }
        }*/

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

        /*public void shoveQueue(int fromIndex, int byIndex) {
            for (int i = fromIndex; i < queue.Length - 1; i++) {
                queue[i] = queue[i + 1];
            }
            queue[queue.Length - 1] = null;
        }*/

        public string[] raw() {
            return queue;
        }

        static void waitForEnter() {
            Console.WriteLine("Press ENTER to continue");
            Console.ReadLine();
        }
    }
}

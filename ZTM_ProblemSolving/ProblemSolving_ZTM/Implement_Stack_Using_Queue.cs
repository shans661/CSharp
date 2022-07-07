using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolving_ZTM
{
    public class MyStack
    {
        Queue<int> myQueue;
        public MyStack()
        {
            myQueue = new Queue<int>();
        }

        public void Push(int x)
        {
            if(myQueue.Count == 0)
            {
                myQueue.Enqueue(x);
            }
            else
            {
                int existingCount = myQueue.Count;
                myQueue.Enqueue(x);
                for (int count = 0; count < existingCount; count++)
                {
                    myQueue.Enqueue(myQueue.Dequeue());
                }
            }
        }

        public int Pop()
        {
           return myQueue.Dequeue();
        }

        public int Top()
        {
            return myQueue.Peek();
        }

        public bool Empty()
        {
            return !myQueue.Any();
        }
    }

    /**
     * Your MyStack object will be instantiated and called as such:
     * MyStack obj = new MyStack();
     * obj.Push(x);
     * int param_2 = obj.Pop();
     * int param_3 = obj.Top();
     * bool param_4 = obj.Empty();
     */
}

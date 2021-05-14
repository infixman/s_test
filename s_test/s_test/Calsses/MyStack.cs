using System.Collections.Generic;
using System.Linq;

namespace s_test.Calsses
{
    public class MyStack
    {
        public Stack<int> myStack;
        public Stack<int> maxStack;

        public MyStack()
        {
            myStack = new Stack<int>();
            maxStack = new Stack<int>();
        }

        public MyStack(IEnumerable<int> sequence)
        {
            myStack = new Stack<int>(sequence);
            maxStack = new Stack<int>(sequence.OrderBy(x => x));
        }

        public void Push(int val)
        {
            myStack.Push(val);
            if (maxStack.Count == 0 || maxStack.Peek() < val)
                maxStack.Push(val);
        }

        public void Pop()
        {
            if (myStack.Peek() == maxStack.Peek())
                maxStack.Pop();

            myStack.Pop();

        }

        public int Top()
        {
            return myStack.Peek();
        }

        public int GetMax()
        {
            return maxStack.Peek();
        }
    }
}

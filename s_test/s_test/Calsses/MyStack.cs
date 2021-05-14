using System.Collections.Generic;

namespace s_test.Calsses
{
    public class MyStack
    {
        public Stack<int> myStack;

        public MyStack()
        {
            myStack = new Stack<int>();
        }

        public MyStack(IEnumerable<int> sequence)
        {
            myStack = new Stack<int>(sequence);
        }

        public void Push(int val)
        {
            myStack.Push(val);
        }

        public void Pop()
        {
            myStack.Pop();
        }

        public int Top()
        {
            return myStack.Peek();
        }
    }
}

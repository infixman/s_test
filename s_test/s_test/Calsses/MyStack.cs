using System.Collections.Generic;

namespace s_test.Calsses
{
    public class MyStack
    {
        Stack<int> myStack;

        public MyStack()
        {

        }

        public MyStack(IEnumerable<int> sequence)
        {
            myStack = new Stack<int>(sequence);
        }

        public void Push(int val)
        { 
        }
    }
}

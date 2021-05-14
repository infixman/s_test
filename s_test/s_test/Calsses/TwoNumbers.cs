namespace s_test.Calsses
{
    public class TwoNumbers
    {
        public int[] NumberArray;
        public int Target;

        public TwoNumbers()
        {
            NumberArray = new int[] { };
        }

        public TwoNumbers(int[] arr, int target)
        {
            NumberArray = arr;
            Target = target;
        }

        public int[] GetTwoNumbers()
        {
            foreach (var val1 in NumberArray)
            {
                foreach (var val2 in NumberArray)
                {
                    if (val1 + val2 == Target)
                        return new int[] { val1, val2 };
                }
            }
            return null;
        }
    }
}

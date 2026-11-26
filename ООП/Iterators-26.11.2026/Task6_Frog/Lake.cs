using System;
using System.Collections;
using System.Collections.Generic;

namespace Task6_Frog
{
    public class Lake : IEnumerable<int>
    {
        private List<int> stones;

        public Lake(List<int> stones)
        {
            this.stones = stones;
        }

        public IEnumerator<int> GetEnumerator()
        {
            // Първо четните индекси във възходящ ред
            for (int i = 0; i < stones.Count; i += 2)
            {
                yield return stones[i];
            }

            // После нечетните индекси в низходящ ред
            int lastOdd = stones.Count - 1;
            if (lastOdd % 2 == 0)
            {
                lastOdd--;
            }
            for (int i = lastOdd; i >= 1; i -= 2)
            {
                yield return stones[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}

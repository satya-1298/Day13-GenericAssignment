using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Maximum<T> where T : IComparable
    {
        private T[] values;

        public Maximum(T[] values)
        {
            this.values = values;
        }

        public T Number()
        {
            T max = values[0];

            for (int i = 1; i < values.Length; i++)
            {

                if (values[i].CompareTo(max) > 0)
                {
                    max = values[i];
                }
            }
            return max;
        }
    }
}


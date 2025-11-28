using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace persec_test
{
    public class test06
    {
        public int[] tribonacci(int[] input, int size)
        {
            int[] result = new int[size];
            Array.Copy(input, result, input.Length);
            if (input.Length == 0)
            {
                return input;
            }

            if (input.Length == 1 && size == 1)
            {
                return input;
            }
            else if (input.Length == 1 && size > 1 && size < 3)
            {
                result[1] = result[0];
                return result;
            }
            else if (input.Length == 1 && size >= 3)
            {
                result[1] = result[0];
                result[2] = result[0] + result[1];
            }

            if (input.Length == 2 && size == 2)
            {
                return input;
            }
            else if (input.Length == 2 && size == 3)
            {
                result[2] = result[0] + result[1];
                return result;
            }
            else if (input.Length == 2 && size > 3)
            {
                result[2] = result[0] + result[1];
            }

            if (size >= 4)
            {
                for (int i = 3; i < size; i++)
                {
                    result[i] = result[i - 3] + result[i - 2] + result[i - 1];
                }
            }


            return result;
        }
    }
}
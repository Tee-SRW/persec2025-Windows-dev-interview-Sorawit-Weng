using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace persec_test
{
    public class test05
    {
        public int max(int input)
        {
            int result = -1;
            string temp = "";
            char[] splited = input.ToString().ToCharArray();
            Array.Sort(splited);

            for (int i = splited.Length - 1; i >= 0; i--)
            {
                temp += splited[i];
            }
            result = int.Parse(temp);
            return result;
        }
    }
}
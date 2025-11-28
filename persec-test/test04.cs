using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace persec_test
{
    public class test04
    {
        public string toRoman(int number)
        {
            string result = "";
            Dictionary<int, string> map = new Dictionary<int, string>()
            {
                {1000, "M"}, {900, "CM"}, {500, "D"}, {400, "CD"},
                {100, "C"}, {90, "XC"}, {50, "L"}, {40, "XL"},
                {10, "X"}, {9, "IX"}, {5, "V"}, {4, "IV"},
                {1, "I"}
            };


            foreach (var kv in map)
            {
                while (number >= kv.Key)
                {
                    result += kv.Value;
                    number -= kv.Key;
                }
            }

            return result;
        }


        public int toNumber(string roman)
        {
            int result = 0;
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                {'I', 1},
                {'V', 5},
                {'X', 10},
                {'L', 50},
                {'C', 100},
                {'D', 500},
                {'M', 1000}
            };
            for (int i = 0; i < roman.Length; i++)
            {
                int value = map[roman[i]];

                if (value < map[roman[i + 1]] && i + 1 < roman.Length)
                {
                    result -= value;
                }
                else
                {
                    result += value;
                }
            }

            return result;
        }
    }
}
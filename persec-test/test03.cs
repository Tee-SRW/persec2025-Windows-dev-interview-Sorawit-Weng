using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace persec_test
{
    public class test03
    {
        public string[] autoComplete(string search, string[] items, int maxResult)
        {
            search = search.ToLower();

            var startsWith = new List<string>();
            var contains = new List<string>();
            var endsWith = new List<string>();

            foreach (var item in items)
            {
                var text = item.ToLower();

                if (text.StartsWith(search))
                {
                    startsWith.Add(item);
                }
                else if (text.Contains(search))
                {
                    contains.Add(item);
                }
                else if (text.EndsWith(search))
                {
                    endsWith.Add(item);
                }
            }

            return startsWith
                .Concat(contains)
                .Concat(endsWith)
                .Take(maxResult)
                .ToArray();
        }



    }
}
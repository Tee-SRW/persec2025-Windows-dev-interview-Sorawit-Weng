using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace persec_test
{
    public class test02
    {
        public string[] sort(string[] input)
        {
            return input
                .OrderBy(x =>
                {
                    var prefix = Regex.Match(x, @"^[A-Za-z]+").Value;

                    var number = int.Parse(Regex.Match(x, @"\d+").Value);

                    return (prefix, number);
                })
                .ToArray();
        }

    }
}


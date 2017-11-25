using System;
using System.Collections.Generic;
using System.Text;

namespace NumberToTextConversion
{
    public static class NumberTranslator
    {
        private static Dictionary<int, string> _translations = new Dictionary<int, string>();

        private static Dictionary<int, string> _bases = new Dictionary<int, string>()
        {
            {1,"one"},
            {2,"two"},
            {3,"three"},
            {4,"four"},
            {5,"five"},
            {6,"six"},
            {7,"seven"},
            {8,"eight"},
            {9,"nine"},
            {10,"ten" },
            {11,"eleven"},
            {12,"twelve" },
            {13,"thirteen" },
            {14,"fourteen" },
            {15,"fifteen"},
            {16,"sixteen"},
            {17,"seventeen"},
            {18,"eighteen"},
            {19,"nineteen"},
            {20,"twenty"},
            {30,"thirty"},
            {40,"forty" },
            {50,"fifty" },
            {60,"sixty" },
            {70,"seventy" },
            {80,"eighty" },
            {90,"ninety" },
            {100,"hundred" },
            {1000,"thousand" }
        };

        public static string GetTranslation(int input)
        {

            if (input < 0 && input > 1000000)
                throw new ArgumentException("Input is out of range.");

            if (!_translations.ContainsKey(input))
                _translations.Add(input, Translate(input));

            return _translations[input];
        }

        private static string Translate(int input)
        {
            StringBuilder sb=new StringBuilder();

            var countOfThousands = input / 1000;
            if (countOfThousands>0)
            {
                sb.Append($"{GetTranslation(countOfThousands)} {_bases[1000]}");
                input -= countOfThousands * 1000;
            }

            var countOfHundredts = input / 100;
            if (countOfHundredts>0)
            {
                AddSeparatorIfNessesary(sb);

                sb.Append($"{GetTranslation(countOfHundredts)} {_bases[100]}");
                input -= countOfHundredts * 100;
            }


            var countOfTens = input / 10;
            if (countOfTens>=2)
            {
                AddSeparatorIfNessesary(sb);

                sb.Append(_bases[countOfTens*10]);
                input -= countOfTens * 10;
            }


            if (input > 0)
            {
                AddSeparatorIfNessesary(sb,countOfTens<2);

                sb.Append(_bases[input]);

            }

            return sb.ToString();
        }

        private static void AddSeparatorIfNessesary(StringBuilder sb,bool longSeparator=true)
        {
            if (longSeparator)
            {
                if (sb.Length > 0)
                    sb.Append(" and ");
            }
            else
            {
                if (sb.Length > 0)
                    sb.Append(" ");
            }
        }

    }
}

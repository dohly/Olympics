using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1002
{
    class TelephonesSolution
    {
        static Dictionary<string, string> DigitToChar = new Dictionary<string, string>()
            {
                {"1","ij"},
                {"2","abc"},
                {"3","def"},
                {"4","gh"},
                {"5","kl"},
                {"6","mn"},
                {"7","prs"},
                {"8","tuv"},
                {"9","wxy"},
                {"0","oqz"}
            };

        public string Telephone;
        public List<string> Words = new List<string>();
        public string GetResult()
        {
            IEnumerable<KeyValuePair<string, string>> wordsInTelephone = (from word in Words
                                                                          let digital = WordToDigits(word)
                                                                          where Telephone.Contains(digital)
                                                                          select new KeyValuePair<string, string>(digital, word));
            if (wordsInTelephone.Any())
            {
                var solution = FindSolution(Telephone, wordsInTelephone);
                if (solution != null)
                {
                    solution.Reverse();
                    return string.Join(" ", solution.Select(x => x.Value));
                }
            }
            return "No solution.";
        }

        private List<KeyValuePair<string, string>> FindSolution(string telephone, IEnumerable<KeyValuePair<string, string>> wordsInTelephone)
        {
            if (string.IsNullOrEmpty(telephone))
            {
                return null;
            }
            if (wordsInTelephone.Any(x => x.Key == telephone))
            {
                var first = wordsInTelephone.First(x => x.Key == telephone);
                return new List<KeyValuePair<string, string>>() { first };
            }
            var startWith = wordsInTelephone.Where(x => telephone.StartsWith(x.Key)).OrderByDescending(x => x.Key.Length);
            foreach (var pair in startWith)
            {
                string cut = telephone.Substring(pair.Key.Length);
                var solution = FindSolution(cut, wordsInTelephone);
                if (solution != null)
                {
                    solution.Add(pair);
                    return solution;
                }
            }
            return new List<KeyValuePair<string, string>>();
        }


        private string WordToDigits(string word)
        {
            string result = "";
            foreach (char c in word)
            {
                var pair = DigitToChar.FirstOrDefault(x => x.Value.Contains(c));
                result = result + pair.Key;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<TelephonesSolution> solutions = new List<TelephonesSolution>();
            while (true)
            {
                TelephonesSolution telephones = new TelephonesSolution();
                telephones.Telephone = Console.ReadLine();
                if (telephones.Telephone == "-1")
                {
                    break;
                }
                int count = int.Parse(Console.ReadLine());
                for (int i = 0; i < count; i++)
                {
                    telephones.Words.Add(Console.ReadLine());
                }
                solutions.Add(telephones);
            }
            foreach (var telephonesSolution in solutions)
            {
                Console.WriteLine(telephonesSolution.GetResult());
            }
        }
    }
}

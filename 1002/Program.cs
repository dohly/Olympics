using System;
using System.Collections.Generic;
using System.Linq;

namespace _1002
{

    class Word
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
        private static string WordToDigits(string word)
        {
            string result = "";
            foreach (char c in word)
            {
                var pair = DigitToChar.FirstOrDefault(x => x.Value.Contains(c));
                result = result + pair.Key;
            }
            return result;
        }
        public string Text { get; private set; }
        public string Digits { get; private set; }
        public int CountInTelephone { get; set; }
        public Word(string text)
        {
            Text = text;
            Digits = WordToDigits(text);
        }

        public void CalculateCount(string telephone)
        {
            CountInTelephone = 0;
            while (telephone.IndexOf(Digits)!=-1)
            {
                telephone = telephone.Remove(telephone.IndexOf(Digits), Digits.Length);
                CountInTelephone++;
            }
        }
    }
    class TelephonesSolution
    {
        public string Telephone;
        public List<Word> Words = new List<Word>();
       
        public string GetResult()
        {
            List<List<Word>> result = new List<List<Word>>();
            Words = Words.OrderByDescending(x => x.Digits.Length).ToList();
            foreach (var word in Words)
            {
                word.CalculateCount(Telephone);
            }
            if (result.Any())
            {
                var best = result.OrderBy(x => x.Count).First();
                return string.Join(" ", best.Select(x => x.Text));
            }
            return "No solution.";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<TelephonesSolution> solutions = new List<TelephonesSolution>();
            bool enableConsoleInput = true;
            if (!enableConsoleInput)
            {
                TelephonesSolution ts = new TelephonesSolution()
                    {
                        Telephone = "7325189087",
                        Words = new List<Word>()
                            {
                                new Word("it"),
                                new Word("your"),
                                new Word("reality"),
                                new Word("real"),
                                new Word("our")
                            }
                    };
                solutions.Add(ts);
                ts = new TelephonesSolution()
                {
                    Telephone = "4294967296",
                    Words = new List<Word>()
                            {
                                new Word("it"),
                                new Word("your"),
                                new Word("reality"),
                                new Word("real"),
                                new Word("our")
                            }
                };
                solutions.Add(ts);
            }
            while (true && enableConsoleInput)
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
                    string text = Console.ReadLine();
                    if (text.Length > telephones.Telephone.Length)
                    {
                        continue;
                    }
                    Word word = new Word(text);
                    if (telephones.Telephone.Contains(word.Digits))
                    {
                        telephones.Words.Add(word);
                    }
                }
                solutions.Add(telephones);
            }
            foreach (var telephonesSolution in solutions)
            {
                string result = telephonesSolution.GetResult();
                Console.WriteLine(result);
            }
        }
    }
}

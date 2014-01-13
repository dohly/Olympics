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
        public int Weight { get { return Text.Length; } }
        public Word(string text)
        {
            Text = text;
            Digits = WordToDigits(text);
        }
        public override string ToString()
        {
            return string.Format("{0} - {1}", Text, Digits);
        }
    }

    class TelephonesSolution
    {
        public string Telephone;
        public List<Word> Words = new List<Word>();


        public string GetResult()
        {
            string noSolution = "No solution.";
            Dictionary<int, List<Word>> result = new Dictionary<int, List<Word>>();
            for (int i = 0; i < Telephone.Length; i++)
            {
                string tel = Telephone.Substring(i);
                var start = Words.Where(x => tel.StartsWith(x.Digits));
                bool any = start.Any();
                if (i == 0)
                {
                    //Есть ли первое слово
                    if (!any)
                    {
                        return noSolution;
                    }
                    //Есть ли решение в одно слово
                    Word singleWord = start.FirstOrDefault(x => x.Digits == Telephone);
                    if (singleWord != null)
                    {
                        return singleWord.Text;
                    }
                }
                if (any)
                {
                    result.Add(i, new List<Word>(start));
                }
            }
            int maxWordCount = result.Count;
            if (maxWordCount != 0)
            {
                var start = result[0];

                int maxLength = Telephone.Length;
                List<List<Word>> solutions=new List<List<Word>>();
                foreach (var word in start)
                {
                    string tel = Telephone.Substring(word.Weight);
                    List<Word> solution = new List<Word>();
                    solution.Add(word);
                    int totalLength = word.Weight;
                    foreach (var pair in result)
                    {
                        if (pair.Key < totalLength)
                        {
                            continue;
                        }
                        var words = pair.Value;
                        foreach (Word nextWord in words)
                        {
                            int l = totalLength + nextWord.Weight;
                            if (l > maxLength)
                            {
                                continue;
                            }
                            totalLength = l;
                            solution.Add(nextWord);
                            break;
                        }
                        if (totalLength == maxLength)
                        {
                            break;
                        }
                    }
                    if (totalLength == maxLength)
                    {
                        solutions.Add(solution);
                    }
                }
                var best = solutions.OrderBy(x => x.Count).FirstOrDefault();
                if (best != null)
                {
                    return string.Join(" ", best.Select(x => x.Text));
                }
            }
            return noSolution;
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
                                new Word("real"),
                                new Word("reality"),
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

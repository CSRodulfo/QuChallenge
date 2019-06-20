using QuBeyond.Backend.Bussiness.Entities;
using QuBeyond.Backend.Bussiness.Matrixes;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QuBeyond.Backend.Bussiness.Finds
{
    public class Search
    {
        private string vector = string.Empty;

        private IList<string> words = null;
        public Search(Vector vectorValue)
        {
            this.vector = vectorValue.GetVector();
            words = new List<string>();
        }

        public IEnumerable<string> FindWords(IEnumerable<string> wordstream)
        {
            foreach (string item in wordstream)
            {
                this.FindWord(item);
            }

            return this.GetFindWords();
        }

        private void FindWord(string wordFind)
        {
            for (int i = 0; i < vector.Length; i++)
            {
                if (String.Compare(vector, i, wordFind, 0, wordFind.Length, true) == 0)
                {
                    this.words.Add(wordFind);
                }
            }
        }

        private IEnumerable<string> GetFindWords()
        {
            return this.words.GroupBy(x => x).Select(group => new Word()
            {
                Text = group.Key,
                Quantity = group.Count()
            }).OrderByDescending(x => x.Quantity).Take(10).Select(z => z.Text);
        }
    }
}

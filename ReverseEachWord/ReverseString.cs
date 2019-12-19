using System;
using System.Linq;
using Xunit;

namespace ReverseEachWord
{
    public class ReverseString
    {
        [Fact]
        public void Reverse_LINQ()
        {
            string text = "This is a text";

            string reversedWords = ReverseLINQ(text);

            Assert.Equal("sihT si a txet", reversedWords);
        }

        [Fact]
        public void Reverse_For_Loop()
        {
            string text = "This is a text";

            string reversedWords = ReverseFor(text);

            Assert.Equal("sihT si a txet", reversedWords);
        }

        private static string ReverseLINQ(string text)
        {
            return string.Join(" ", text.Split(' ')
                .Select(x => new string(x.Reverse().ToArray())));
        }

        private static string ReverseFor(string text)
        {
            string result = string.Empty;

            string[] array = text.Split(' ');

            for (int i = 0; i < array.Length; i++)
            {
                string reversedWord = new string(array[i].Reverse().ToArray());
                result += i != (array.Length - 1) ? reversedWord + " " : reversedWord;
            }

            return result;
        }
    }
}

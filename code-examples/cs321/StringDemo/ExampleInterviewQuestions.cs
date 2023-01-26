using Newtonsoft.Json.Bson;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Xml;

namespace StringDemoTests
{
    public static class Tests
    {
    }

    public static class ExampleInterviewQuestions_Step1
    {
        // 1. Get all duplicated characters in a string.
        // 2. Get all unique characters in a string.
        // 3. Reverse a string.
        // 4. Reverse each word in a string
        // 5. Get the word count in a string
        // 6. Check if a string is a palindrome or not
        // 7. Check max occurrence of a character in the string.
        // 8. Get all possible substring in a string.
        // 9. Get the first char of each word in capital letter
        // 10. Check if two strings are anagrams
        // 11. Remove duplicated characters
        // 12. Check if a function has all unique characters
    }

    public static class ExampleInterviewQuestions_Step2
    {
        // 1. Get all duplicated characters in a string.
        // Characters which occur more than once. 
        // int GetOccurence(char) > 1 

        // 2. Get all unique characters in a string.
        // Chracters which occur exactly once 
        // int GetOccurence(char) == 1

        // 3. Reverse a string.
        // Swapping? 
        // Swap first and last char
        // Swap next char and next to last char
        // Be careful because after the middle you are swapping again. 
        // Iteration? 
        // Iterate through the chars in reverse order, build a new string.
        // string Reverse(string) 

        // 4. Reverse each word in a string
        // Get each word in the string, and reverse it, and rebuild the string
        // string[] Words(string) 
        // string[] ReverseStrings(string[] strings)
        // string RebuildString(string[] strings) 
        // How to deal with commas and stuff? "Split" doesn't quite work. 
        // Idea: funny characters are treated as strings of length 1. Rever

        // 5. Get the word count in a string
        // Need to get the words in a string. 
        // Something like Words(string).Length
        // However we don't want to count the punctuation. 

        // 6. Check if a string is a palindrome or not
        // Iterate over the characters
        // Is each character the same as the nth character from the end? 
        // Tricky because of one-off problem.
        // Write a function to get the "nth from last function".
        // Why? Because it is hard to remember. 

        // 7. Check max occurrence of a character in the string.
        // Get the counts of all characters.   
        // The one that is the most is the character 

        // 8. Get all possible substring in a string.
        // Go through all indices
        // Get substrings of length 1
        // Repeat: get sustrings of length n
        // Be careful, each time we do the loop we have to get fewer characters. 

        // 9. Get the first char of each word in capital letter
        // need something like string[] Words(string)
        // need to use char.ToUpper(char)

        // 10. Check if two strings are anagrams
        // Every letter from first string exists in second string.
        // What if a letter occurs twice? Makes algorithm tricky. 

        // 11. Remove duplicated characters
        // Build a string from orginal characters.
        // Only add a character if it is the first time it is seen. 

        // 12. Check if a function has all unique characters
        // Use the GetOccurences function
    }

    public static class ExampleInterviewQuestions_Step3
    {
        public static string Banana = "banana";
        public static string CatsAndDogs = "cats and dogs";
        public static string Sentence = "I don't like asparagus, brocoli, or carrots, however, Émile does!";

        [Test]
        public static void TestGetOccurences()
        {
            Assert.AreEqual(1, GetOcurrence('b', Banana));
            Assert.AreEqual(0, GetOcurrence('c', Banana));
            Assert.AreEqual(3, GetOcurrence('a', Banana));
        }

        // Returns the number of occurences of the letter c in the string s
        public static int GetOcurrence(char c, string s)
        {
            var n = 0;
            for (var i=0; i < s.Length; i++) 
                if (s[i] == c) 
                    n++;
            return n;
        }

        [Test]
        public static void TestDuplicatedChars()
        {
            Assert.AreEqual(1, GetOcurrence('b', Banana));
            Assert.AreEqual(0, GetOcurrence('c', Banana));
            Assert.AreEqual(3, GetOcurrence('a', Banana));
        }


        // 1. Get all duplicated characters in a string.
        // banana => { 'a', 'n' }
        public static List<char> GetAllDuplicatedChars(string s)
        {
            var r = new List<char>();
            foreach (var c in s)
            {
                if (GetOcurrence(c, s) > 1)
                    r.Add(c);
            }

            // Note: r will contain repetitions of a letter.
            // e.g. banana wll return "anana".  
            // Solve this in a second step. 
            return r;
        }

        // 2. Get all unique characters in a string.
        // banana => { 'b' }
        public static List<char> GetAllUniqueChars(string s)
        {
            var r = new List<char>();
            foreach (var c in s)
            {
                if (GetOcurrence(c, s) == 1)
                    r.Add(c);
            }

            // banana will "b"
            return r;
        }

        // 3. Reverse a string.
        // banana => ananab
        public static string Reverse(string s)
        {
            var xs = new List<char>();
            for (var i=s.Length-1; i >= 0; --i)
            {
                xs.Add(s[i]);
            }
            return new string(xs.ToArray());
        }

        // banana => true
        // 12 => false
        // don't => false
        // a,b => false
        // a => true
        public static bool IsWord(string s)
        {
            foreach (var c in s)
                if (!char.IsLetter(c))
                    return false;
            return true;
        }

        // I don't like apples, bananas, or carrots.
        // => "I", "don't", "like", "apples", ",", "bananas", ",", "or", "carrots", "." 
        public static List<string> GetWords(string s)
        {
            var r = new List<string>();

            if (s.Length == 0)
                return r;

            var wordChars = new List<char>();
              
            for (var i=0; i < s.Length; ++i)
            {
                var c = s[i];
                if (char.IsLetter(c))
                {
                    wordChars.Add(c);
                }
                else
                {
                    if (wordChars.Count > 0)
                    {
                        var word = new string(wordChars.ToArray());
                        r.Add(word);
                        wordChars.Clear();
                    }
                    r.Add(c.ToString());
                }
            }
            if (wordChars.Count > 0)
            {
                var word = new string(wordChars.ToArray());
                r.Add(word);
            }
            return r;           
        }

        // 4. Reverse each word in a string
        public static List<string> ReverseWords(string s)
        {
            var words = GetWords(s);
            var r = new List<string>();
            foreach (var word in words)
            {
                if (IsWord(word))
                {
                    var tmp = Reverse(word);
                    r.Add(tmp);
                }
                else
                {
                    r.Add(word);
                }
            }
            return r;
        }

        // 5. Get the word count in a string
        public static int WordCount(string s)
        {
            var words = GetWords(s);
            var n = 0;
            foreach (var word in words)
                if (IsWord(word))
                    n++;
            return n;
        }

        // 6. Check if a string is a palindrome or not
        // tacocat, tacocat => true
        // abba, abba => true
        // a, a => true
        // taco, oact => false
        public static bool IsPalindrome(string s)
        {
            for (var i=0; i < s.Length / 2; ++i)
            {
                var c1 = s[i];
                var c2 = s[s.Length - 1 - i];
                if (c1 != c2)
                    return false;
            }
            return true;
        }

        // 7. Check max occurrence of a character in the string.
        // Get the counts of all characters.   
        // The one that is the most is the character 
        public static char MaxOccurrenceChar(string s)
        {
            var maxCount = -1;
            var maxChar = '\0';
            foreach (var c in s)
            {
                var count = GetOcurrence(c, s);
                if (count > maxCount)
                {
                    maxCount = count;
                    maxChar = c;
                }
            }
            return maxChar;
        }

        // 8. Get all possible substring in a string.
        // Cat => c, a, t, ca, at, cat
        public static List<string> Substrings(string s)
        {
            var xs = new List<string>();
            for (var len=1; len < s.Length; ++len)
            {
                for (var i=0; i < s.Length - 1 - len; ++i)
                {
                    var sub = s.Substring(i, len);
                    xs.Add(sub);
                }
            }
            return xs;
        }

        // 9. Get the first char of each word in capital letter
        public static List<char> FirstCharOfEachWordAsCapital(string s)
        {
            var r = new List<char>();
            var words = GetWords(s);
            foreach (var word in words)
            {
                if (word.Length > 0)
                {
                    var firstLetter = word[0];
                    r.Add(char.ToUpper(firstLetter));
                }
            }
            return r;
        }

        // 10. Check if two strings are anagrams
        // (cat, tac) => true
        // (cat, dog) => false
        // The following fails to evaluate as we expect. Why? 
        // (banana, baaaan) => false
        public static bool IsAnagram(string s1, string s2)
        {
            if (s1.Length != s2.Length) 
                return false;
            foreach (var c in s1)
                if (!s1.Contains(c))
                    return false;
            return true;
        }

        public static bool IsFirstOccurence(string s, int index)
        {

            var c = s[index]; 
                
            // Iterate over the characters. 
            // Make sure we don't see the character before the index 
            for (var i = 0; i < index; ++i)
            {
                if (s[i] == c) 
                    return false;
            }

            return true;
        }

        // 11. Remove duplicated characters
        // banana => ban
        public static string RemoveDuplicatedChars(string s)
        {
            var list = new List<char>();
            for (var i = 0; i < s.Length; ++i)
            {
                if (IsFirstOccurence(s, i))
                {
                    list.Add(s[i]);
                }
            }
            return new string(list.ToArray());
        }

        // 12. Check if a function has all unique characters
        // Use the GetOccurences function
        public static bool HasOnlyUniqueChars(string s)
        {
            for (var i = 0; i < s.Length; ++i)
                if (!IsFirstOccurence(s, i))
                    return false;
            return true;
        }
    }
}

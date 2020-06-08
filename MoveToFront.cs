using System;
using System.Collections.Generic;


namespace MovetoFront
{
    /// <summary>
    /// Class of  MTF algorithm.
    /// </summary>
    public class MoveToFront
    {
        /// <summary>
        /// Method of MoveToFront alogorithm.
        /// </summary>
        /// <param name="input">Current string</param>
        /// <returns>Sequence of numbers.</returns>
        public List<int> StringCoding(string input)
        {
            if (input == null)
            {
                throw new ArgumentNullException();
            }

            var List = new List<char>();

            for (char letter = 'a'; letter < 'z'; letter++)
            {
                List.Add(letter);
            }

            var PartsLine = input.ToCharArray();
            var Result = new List<int>();
            for (int i = 0; i < PartsLine.Length; i++)
            {
                for (int j = 0; j < List.Count; j++)
                {
                    var Current = List[j];
                    if (PartsLine[i] == Current)
                    {
                        List.RemoveAt(j);
                        List.Insert(0, Current);
                        Result.Add(j);
                    }
                }
            }
            return Result;
        }
    }
}
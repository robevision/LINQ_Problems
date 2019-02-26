using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Problem_Four
    {
        public void LongForm()
        {
            //
            List<string> deconstructed = new List<string>();
            List<int> lettersCount= new List<int>();
            string name = "Terrill";
            foreach(char letter in name)
            {
                deconstructed.Add(letter.ToString());
            }
            //deconstructed.Count();
            //foreach(string symbol in deconstructed)
            //{
            //    Console.WriteLine(symbol);
            //    Console.ReadKey();
            //}
            //lettersCount = deconstructed.GetEnumerator();
            for (int i = 0; i < deconstructed.Count; i++)
            {
                //if (deconstructed[i] == )
                //{

                //}
                lettersCount.Add(i);
            }
            foreach (int number in lettersCount)
            {
                Console.WriteLine(number);
                Console.ReadKey();
            }
            //var deconstructed = name.GroupBy(n => n).Where(n => n.Count() > 1).Select(n => n.Key);
            //foreach (string item in deconstructed)
            //{
            //    Console.WriteLine(item);
            //}

        }
        public void LINQForm()
        {
            string name = "Terrill";
            List<string> newString = new List<string>();
           
            var deconstructed = new List<string>();
            var numbers = new List<int>();
            foreach (char letter in name)
            {
                deconstructed.Add(letter.ToString().ToUpper());
            }
            //var q = from x in deconstructed group x by x into g let count = g.Count() orderby count descending select new { Value = g.Key, Count = count };
            //var count = Convert.ToInt16(deconstructed.Count());
            //Console.WriteLine(count);
            var group = deconstructed.GroupBy(d => d);
            var listOne = deconstructed.OrderBy(d=>d).Distinct().ToList();
            //var countedLetters = deconstructed.OrderBy(d => d).Count();
            //var countedLetters = deconstructed.Select(d => d).Count();
            //var countedLetters = name.OrderBy(n => n).ToString();

            //foreach (var number in wtf)
            //{
            //    Console.WriteLine(number);
            //    Console.ReadKey();
            //}
            var countLetters = deconstructed.GroupBy(d => d).Select(d => d.Count()).ToList();
            var listTwo = countLetters.OrderBy(l => l);
            var result = listOne.Zip(listTwo,(x,y) => x+y).ToList();
            foreach (var x in result)
            {
                Console.WriteLine(x);
                
                newString.Add(x);
            }
            string solution = "";
            foreach (string thing in newString)
            {
                solution += thing;
            }
            Console.WriteLine(solution);
            Console.ReadKey();

            //CountLetters = deconstructed.GroupBy(d => d.Count());

            //foreach (string letter in deconstructed)
            //{

            //}
            //CountLetters = deconstructed;

            //IEnumerable <string> nonDuplicates = CountLetters.Distinct();
            //Console.WriteLine(nonDuplicates);
            //Console.ReadKey();
            //foreach (string letter in CountLetters)
            //{
            //    Console.WriteLine(letter);
            //    Console.ReadKey();
            //}

        }
    }
}

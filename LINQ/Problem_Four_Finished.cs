using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Problem_Four_Finished
    {
        public void LINQForm()
        {
            string name = "Terrill";
            List<string> newString = new List<string>();

            var deconstructed = new List<string>();
            foreach (char letter in name)
            {
                deconstructed.Add(letter.ToString().ToUpper());
            }

            var group = deconstructed.GroupBy(d => d);
            var listOne = deconstructed.OrderBy(d => d).Distinct().ToList();

            var countLetters = deconstructed.GroupBy(d => d).Select(d => d.Count()).ToList();
            var listTwo = countLetters.OrderBy(l => l);
            var result = listOne.Zip(listTwo, (x, y) => x + y).ToList();
            foreach (var x in result)
            {
                newString.Add(x);
            }
            string solution = "";
            foreach (string item in newString)
            {
                solution += item;
            }
            Console.WriteLine(solution);
            Console.ReadKey();
        }
    }
}

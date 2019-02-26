using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    //public delegate string GrabTH(string s);
    class Program
    {
        static void Main(string[] args)
        {

            //foreach through the list and return the, this, and tenth
            //LINQ commands are WHERE ORDERBY SELECT

            //GrabTH GrabTH;
            //GrabTH = 

            //var wordProblem = new Problem_One().GrabTH();


            // var result = wordProblem.Select(w => w.word == "t" && "h");

            //Console.WriteLine(result);
            //TestForDictionaryNullQuery test = new TestForDictionaryNullQuery();
            //test.TestMethod();
            Problem_One problemOneSolution = new Problem_One();
            Problem_Two problemTwoSolution = new Problem_Two();
            //Problem_Three problemThreeSolution = new Problem_Three();
            Problem_Four_Finished problemFourSolution = new Problem_Four_Finished();
            problemOneSolution.LINQForm();
            Console.ReadKey();
            problemTwoSolution.LINQForm();
            Console.ReadKey();
            //problemThreeSolution.LINQForm();
            //Console.ReadKey();
            problemFourSolution.LINQForm();
        }
   
    }
}

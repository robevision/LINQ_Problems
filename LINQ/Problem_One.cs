using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Problem_One
    {
        //List<string> word = new List<string>();
        //List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth" };
        //public List<string> GrabTH()
        //{   
        //    foreach (string w in words)
        //    {
        //        word.Add(w);
        //    }
        //    return word; 
        //    //for (int i = 0; i < words[5]; i++)
        //    //{
        //    //    yield return word;
        //    //}
        //}
       //public void LongForm()
       // {
       //     List<string> words = new List<string>() { "the","bike", "this", "it", "tenth", "mathematics" };
       //     List<string> thWords = new List<string>();
       //     foreach (string word in words)
       //     {
       //         if (word.Contains("th"))
       //             {
       //             Console.WriteLine(word);
                    
       //             }
       //     }
       // }
        public void LINQForm()
        {
            List<string> words = new List<string>() { "the", "bike", "this", "it", "tenth", "mathematics" };
            var THwords = words.Where(w => w.Contains("th"));
            foreach(string word in THwords)
            {
                Console.WriteLine(word);
                Console.ReadKey();

            }
         }
    }
}

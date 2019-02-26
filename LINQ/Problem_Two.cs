using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Problem_Two
    {
        public void LINQForm()
        {
            //List<string> temp= new List<string>();
            //List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike"};
            //var noDuplicates = names.GroupBy(n => n).Where(n => n.Count() > 1).Select(n => n.Key);

            //foreach (string name in noDuplicates)
            //{
            //    //Console.WriteLine(name);
            //    //Console.ReadKey();

            //        temp.Add(name);

            //}
            //List<string> removeName = names;
            //for (int i = 0; i == removeName.Count; i++)
            //{
            //    removeName.Remove(temp[i]);
            //}
            ////removeName.Remove(temp);
            //foreach(string remove in removeName)
            //{
            //    Console.WriteLine(remove);
            //    Console.ReadKey();
            //}
            List<string> names = new List<string>() { "Mike", "Brad", "Nevin", "Ian", "Mike" };
            var nameWithOutDuplicates = names.Distinct();
            foreach (var name in nameWithOutDuplicates)
            {
                Console.WriteLine(name);
            }
          
        }

    }
}

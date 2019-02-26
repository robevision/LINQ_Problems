using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class TestForDictionaryNullQuery
    {
        Dictionary<int, string> updates = new Dictionary<int, string>();
        public void TestMethod()
        {
            var adoptionStatus = updates.Where(u => u.Key == 7).Select(u => u.Value).Single();
            Console.WriteLine(adoptionStatus);
            Console.ReadKey();
        }
       

    }
}

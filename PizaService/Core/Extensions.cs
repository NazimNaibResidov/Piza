using System.Collections.Generic;
using System.Linq;
namespace PizaService.Core
{
     public static class Extensions{
        public static Dictionary<string, int> DictionaryGrouping(this IEnumerable<IGrouping<string, string>> Grouping)
        {
            Dictionary<string, int> _ToppingCounts = new Dictionary<string, int>();


            foreach (var g in Grouping)
            {
                _ToppingCounts.Add(g.Key, g.Count());
            }
            return _ToppingCounts;
        }
}
}
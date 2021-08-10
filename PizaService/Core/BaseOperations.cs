using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using PizaService.Models;
namespace PizaService.Core
{
public class BaseOperations
    {
          private static ToppingConfiguration [] GetFileWithDeserialize()
        {
            
            try
            {
                var json = File.ReadAllText("pizzas.json");
                return JsonConvert.DeserializeObject<ToppingConfiguration[]>(json);
            }
            catch{ return null; }
           
          
        }
      
       
        public static List<Result> Toppings(int count=10)
        {

            Dictionary<string, int> _ToppingCounts =  GetFileWithDeserialize().Select(x => string.Join(",", x.Toppings.OrderBy(y => y)))
                .GroupBy(x => x)
                .DictionaryGrouping();
         

            return _ToppingCounts.OrderByDescending(x => x.Value)
                .Take(count)
                .Select(x => new Result
                {
                    name = x.Key,
                    value = x.Value
                }).ToList();


        }
    }
}
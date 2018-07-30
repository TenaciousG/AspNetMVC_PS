using System.Collections.Generic;

namespace DemoMVC_PS.Models
{
    public class TechItemFetcher
    {
        public static IEnumerable<TechItem> GetItems()
        {
            return new List<TechItem>
            {
                new TechItem{Name = "ASP"},
                new TechItem{Name = "ASP.NET"},
                new TechItem{Name = "ASP.NET Core"}
            };
        }
    }
}
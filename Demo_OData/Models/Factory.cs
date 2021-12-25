using System.Collections.Generic;

namespace Demo_OData.Models
{
    public class Factory
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int YearsInMarket { get; set; }
        public List<Product> Products { get; set; }
    }
}

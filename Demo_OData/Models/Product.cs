using System.ComponentModel.DataAnnotations.Schema;

namespace Demo_OData.Models
{
    public class Product
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Description { get; set; }
        public float Weight { get; set; }
        public float Price { get; set; }
        public float Cost { get; set; }
        public float Stock { get; set; }
        public string MeasureUnit { get; set; }

        [ForeignKey("Factory")]
        public int FactoryId { get; set; }

        public Factory Factory { get; set; }
    }
}

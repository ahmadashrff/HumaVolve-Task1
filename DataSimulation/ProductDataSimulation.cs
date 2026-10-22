using HumaVolve_Task1.Model;

namespace HumaVolve_Task1.DataSimulation
{
    public class ProductDataSimulation
    {
        public static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "Dell Laptop",
                Price = 25000,
                CategoryName = "Electronics"
            },

            new Product
            {
                Id = 2,
                Name = "HP Laptop",
                Price = 22000,
                CategoryName = "Electronics"
            },

            new Product
            {
                Id = 3,
                Name = "Lenovo Laptop",
                Price = 20000,
                CategoryName = "Electronics"
            }
        };
    }
}
